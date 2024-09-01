using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FlipperDeck
{
    internal partial class CustomTitleBarHandler
    {
        [LibraryImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool ReleaseCapture();

        [LibraryImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true)]
        private static partial IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const uint WM_NCLBUTTONDOWN = 0xA1;
        private const nint HTCAPTION = 0x2;

        private readonly Control _control;
        private readonly Form _form;

        public CustomTitleBarHandler(Control control, Form form)
        {
            _control = control ?? throw new ArgumentNullException(nameof(control));
            _form = form ?? throw new ArgumentNullException(nameof(form));
            _control.MouseDown += TitleBarPanel_MouseDown;
        }

        private void TitleBarPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!ReleaseCapture())
                {
                    throw new InvalidOperationException("Failed to release capture.");
                }
                _ = SendMessage(_form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, IntPtr.Zero);
            }
        }
    }
}

