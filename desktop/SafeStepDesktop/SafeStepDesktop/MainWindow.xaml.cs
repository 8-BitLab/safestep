using System.IO.Ports;
using System.Windows;
namespace SafeStepDesktop
{
    public partial class MainWindow : Window
    {
        // This object talks to the dongle
        private SerialPort _serialPort;
        // Available baud rate (speed)
        private readonly int[] _baudRates =
        { 9600, 19200, 38400,
 57600, 115200 };
        // Runs when app starts
        public MainWindow()
        {
            InitializeComponent();
            cmbBaudRate.ItemsSource = _baudRates;
            cmbBaudRate.SelectedItem = 115200;
            RefreshPorts();
        }
        // Find all COM ports on this PC
        private void RefreshPorts()
        {
            cmbPorts.ItemsSource =
            SerialPort.GetPortNames();
            if (cmbPorts.Items.Count > 0)
                cmbPorts.SelectedIndex = 0;
        }
        // Refresh button clicked
        private void BtnRefresh_Click(
        object sender, RoutedEventArgs e)
        => RefreshPorts();
        // Connect button clicked
        private void BtnConnect_Click(
        object sender, RoutedEventArgs e)
        {
            if (cmbPorts.SelectedItem == null)
                return;
            _serialPort = new SerialPort
            {
                PortName = cmbPorts
            .SelectedItem.ToString(),
                BaudRate = (int)cmbBaudRate
            .SelectedItem,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                ReadTimeout = 500
            };
            // When data arrives from dongle
            _serialPort.DataReceived +=
            SerialPort_DataReceived;
            try
            {
                _serialPort.Open();
                txtStatus.Text =
                $"Connected: "
                + _serialPort.PortName;
                btnConnect.IsEnabled = false;
                btnDisconnect.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                "Connection failed: "
                + ex.Message);
            }
        }
        // Disconnect button clicked
        private void BtnDisconnect_Click(
        object sender, RoutedEventArgs e)
        {
            if (_serialPort?.IsOpen == true)
            {
                _serialPort.Close();
                _serialPort.Dispose();
            }
            txtStatus.Text = "Disconnected";
            btnConnect.IsEnabled = true;
            btnDisconnect.IsEnabled = false;
        }
        // Data arrived from dongle!
        private void SerialPort_DataReceived(
        object sender,
        SerialDataReceivedEventArgs e)
        {
            string data =
            _serialPort.ReadLine();
            // Send to UI thread
            Dispatcher.Invoke(() =>
            ProcessIncomingData(data));
        }
        // We will fill this in on Day 3!
        private void ProcessIncomingData(
        string rawData)
        {
            // TODO: parse dongle messages
        }
    }
}
