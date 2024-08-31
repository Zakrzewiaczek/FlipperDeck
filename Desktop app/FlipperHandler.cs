using System;
using System.IO.Ports;

namespace FlipperDeck
{
    internal class FlipperHandler
    {
        private readonly SerialPort _serialPort = new();

        public SerialPort SerialPort
        {
            get => _serialPort;
        }

        public void SetSerialPortData(string? portName, int baudRate)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }

            SerialPort.PortName = portName;
            SerialPort.BaudRate = baudRate;
            SerialPort.Parity = Parity.None;
            SerialPort.DataBits = 8;
            SerialPort.StopBits = StopBits.One;
        }

        public bool TryOpenPort()
        {
            try
            {
                SerialPort.Open();
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
                SerialPort.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool IsOpen()
        {
            return SerialPort.IsOpen;
        }

        public void Dispose()
        {
            SerialPort?.Dispose();
        }
    }
}
