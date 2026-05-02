#include <stdio.h>
#include <stdlib.h>
#include "driver/gpio.h"
#include "driver/uart.h"
#include "freertos/idf_additions.h"
#include "freertos/task.h"
#include "freertos/event_groups.h"
#include "nvs_flash.h"
#include "esp_log.h"
#include "nimble/nimble_port.h"
#include "host/ble_hs.h"
#include "portmacro.h"
#include "services/gap/ble_svc_gap.h"

uint8_t ble_addr_type;

#define SAMPLES_FOR_AVERAGE 10

int rssi_samples[SAMPLES_FOR_AVERAGE] = {};
int next_sample_index = 0;
int taken_samples = 0; // max = SAMPLES_FOR_AVERAGE
int cumulative_rssi = 0;

SemaphoreHandle_t mutex;

#define TXD_PIN (GPIO_NUM_1)
#define RXD_PIN (GPIO_NUM_3)

static int ble_gap_event(struct ble_gap_event *event, void *arg){
    struct ble_hs_adv_fields fields;

    switch (event->type){
        case BLE_GAP_EVENT_DISC:
            ESP_LOGI("GAP", "GAP EVENT DISCOVERY");
            ble_hs_adv_parse_fields(&fields, event->disc.data, event->disc.length_data);
            if (fields.name_len > 0){

				xSemaphoreTake(mutex, portMAX_DELAY);
				{
					// Smooth RSSI with moving averages and send info to PC
					cumulative_rssi -= rssi_samples[next_sample_index];
					rssi_samples[next_sample_index] = event->disc.rssi;
					cumulative_rssi += rssi_samples[next_sample_index];

					next_sample_index = (next_sample_index+1)%SAMPLES_FOR_AVERAGE;

					taken_samples = (taken_samples+1 < SAMPLES_FOR_AVERAGE)? taken_samples+1: SAMPLES_FOR_AVERAGE;

					int smoothed_rssi = cumulative_rssi/taken_samples;
					char data[256];
					snprintf(data, 256, "Name=%.*s;RSSI=%d;TEMP=36.5;PING=1\r\n", fields.name_len, fields.name, smoothed_rssi);
					uart_write_bytes(UART_NUM_0, data, strlen(data));

					/*printf("Name: %.*s\n", fields.name_len, fields.name);
					  printf("RSSI: %d\n", smoothed_rssi);*/
				}
				xSemaphoreGive(mutex);
			}
			break;
		default:
			printf("EVENT OF TYPE: %d\n", event->type);
	}
	return 0;
}

void ble_app_on_sync(void){
	ble_hs_id_infer_auto(0, &ble_addr_type);

	printf("Start scanning ...\n");

	struct ble_gap_disc_params disc_params;
	disc_params.filter_duplicates = 0;
	disc_params.passive = 0;
	disc_params.itvl = 0;
	disc_params.window = 0;
	disc_params.filter_policy = 0;
	disc_params.limited = 0;

	ble_gap_disc(ble_addr_type, BLE_HS_FOREVER, &disc_params, ble_gap_event, NULL);
}

void app_main(){

	// Init UART
	const uart_config_t uart_config = {
		.baud_rate = 115200,
		.data_bits = UART_DATA_8_BITS,
		.parity    = UART_PARITY_DISABLE,
		.stop_bits = UART_STOP_BITS_1,
		.flow_ctrl = UART_HW_FLOWCTRL_DISABLE
	};
	uart_param_config(UART_NUM_0, &uart_config);

	uart_set_pin(UART_NUM_0, TXD_PIN, RXD_PIN, UART_PIN_NO_CHANGE, UART_PIN_NO_CHANGE);
	uart_driver_install(UART_NUM_0, 2048, 0, 0, NULL, 0);

	// Start Scanning
	mutex = xSemaphoreCreateMutex();

	nvs_flash_init();
	nimble_port_init();

	ble_svc_gap_init();
	ble_svc_gap_device_name_set("BLE-Scan-Client");

	ble_hs_cfg.sync_cb = ble_app_on_sync;
	nimble_port_run();
}
