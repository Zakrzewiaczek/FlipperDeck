using System;
using System.IO.Ports;

namespace FlipperDeck
{
    internal class FlipperHandler : IDisposable
    {
        private readonly SerialPort _serialPort = new();

        public SerialPort SerialPort => _serialPort;

        public void SetSerialPortData(string? portName, int baudRate)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            _serialPort.PortName = portName ?? throw new ArgumentNullException(nameof(portName));
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
        }

        public bool TryOpenPort()
        {
            try
            {
                _serialPort.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TryClosePort()
        {
            try
            {
                _serialPort.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsOpen() => _serialPort.IsOpen;

        public void Dispose()
        {
            _serialPort?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
