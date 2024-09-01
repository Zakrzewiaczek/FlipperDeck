using System;
using System.Management;

namespace FlipperDeck
{
    internal class COMWatcher : IDisposable
    {
        public event EventHandler<DeviceChangedEventArgs>? DeviceChanged;

        private readonly ManagementEventWatcher _arrivalWatcher;
        private readonly ManagementEventWatcher _removalWatcher;
        private bool _disposed;

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _arrivalWatcher.Dispose();
                _removalWatcher.Dispose();
            }

            _disposed = true;
        }
    }

    public class DeviceChangedEventArgs : EventArgs
    {
        public bool IsConnected { get; set; }
    }
}

