using System;
using System.IO.Ports;
using System.Management;

namespace FlipperDeck
{
    internal class COMWatcher
    {
        public event EventHandler<DeviceChangedEventArgs>? DeviceChanged;

        private readonly ManagementEventWatcher _arrivalWatcher;
        private readonly ManagementEventWatcher _removalWatcher;

        public COMWatcher()
        {
            _arrivalWatcher = new ManagementEventWatcher(
                new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2"));
            _arrivalWatcher.EventArrived += (sender, args) =>
                OnDeviceChanged(new DeviceChangedEventArgs { IsConnected = true });

            _removalWatcher = new ManagementEventWatcher(
                new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3"));
            _removalWatcher.EventArrived += (sender, args) =>
                OnDeviceChanged(new DeviceChangedEventArgs { IsConnected = false });
        }

        protected virtual void OnDeviceChanged(DeviceChangedEventArgs e)
        {
            DeviceChanged?.Invoke(this, e);
        }

        public void StartWatching()
        {
            _arrivalWatcher.Start();
            _removalWatcher.Start();
        }

        public void StopWatching()
        {
            _arrivalWatcher.Stop();
            _removalWatcher.Stop();
        }
    }

    public class DeviceChangedEventArgs : EventArgs
    {
        public bool IsConnected { get; set; }
    }
}
