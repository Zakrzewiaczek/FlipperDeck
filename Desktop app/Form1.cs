using FlipperDeck.Properties;
using System.IO.Ports;

namespace FlipperDeck
{
    public partial class Form1 : Form
    {
        private readonly COMWatcher COMWatcher = new();
        private readonly FlipperHandler FlipperHandler = new();
        private readonly UserEventsManager userEventsManager;

        // From user_prefs.settings
        private readonly int baudRate = user_prefs.Default.baud_rate;

        public Form1()
        {
            InitializeComponent();

            COMWatcher.DeviceChanged += COMPortsChanged;
            COMWatcher.StartWatching();
            COMPortsChanged(new object(), new DeviceChangedEventArgs());

            FlipperHandler.SerialPort.DataReceived += FlipperDataReceived;
            CustomTitleBarHandler titleBarHandler = new(title_bar_panel, this);

            userEventsManager = new UserEventsManager();
            userEventsManager.LoadUserEventsFromFile();


        }
        private void MinimizeApplication(object sender, EventArgs e)
        {
            BGWorker.ChangeWindowState(Handle, BGWorker.WindowState.Minimize);
        }
        private void CloseApplication(object sender, EventArgs e)
        {
            if (FlipperHandler.IsOpen())
                FlipperHandler.TryClosePort();
            FlipperHandler.Dispose();

            userEventsManager.SaveUserEventsToFile();
            userEventsManager.Dispose();

            Application.Exit();
        }

        [STAThread]
        private void COMPortsChanged(object? sender, DeviceChangedEventArgs e)
        {
            // For System.InvalidOperationException exception
            if (com_list.InvokeRequired)
            {
                com_list.Invoke(new MethodInvoker(() => COMPortsChanged(sender, e)));
                return;
            }

            com_list.ClearSelected();
            com_list.Items.Clear();
            com_list.SelectionMode = SelectionMode.One;

            string[] ports = SerialPort.GetPortNames();

            if (ports.Length == 0)
            {
                com_list.Items.Add("   No COM ports active");
                com_list.SelectionMode = SelectionMode.None;
                connect_btn.Enabled = false;
            }
            else
            {
                foreach (string port in ports)
                    com_list.Items.Add("   " + port);

                com_list.SelectedIndex = 0;
                connect_btn.Enabled = true;
            }
        }
        private void ConnectToFlipper(object sender, EventArgs e)
        {
            FlipperHandler.SetSerialPortData(com_list.SelectedItem?.ToString()?.Trim(), baudRate);

            if (!FlipperHandler.TryOpenPort())
            {
                MessageBox.Show("Failed to connect to Flipper", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection_panel.Visible = false;
            disconnect_btn.Visible = true;
            connection_state.Text = "Connected";
            connection_state.ForeColor = Color.Green;

            #region Thread to close COM if device is disconnected

            new Thread(async () =>
            {
                while (true)
                {
                    if (!FlipperHandler.SerialPort.IsOpen && connection_state.Text == "Connected")
                        com_list.Invoke(new Action(() => DisconnectFromFlipper(new object(), new EventArgs())));

                    await Task.Delay(10);
                }
            }).Start();

            #endregion
        }
        private void DisconnectFromFlipper(object sender, EventArgs e)
        {
            if (!FlipperHandler.TryClosePort())
            {
                MessageBox.Show("Failed to disconnect from Flipper", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection_panel.Visible = true;
            disconnect_btn.Visible = false;
            connection_state.Text = "Disconnected";
            connection_state.ForeColor = Color.Red;

            #region Reset navigation buttons

            PictureBox[] nav_buttons = [up_arrow, down_arrow, left_arrow, right_arrow, nav_ok, nav_back];

            foreach (PictureBox button in nav_buttons)
                button.Visible = false;

            #endregion
        }

        [STAThread]
        private void FlipperDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (com_list.InvokeRequired)
            {
                com_list.Invoke(new MethodInvoker(() => FlipperDataReceived(sender, e)));
                return;
            }

            SerialPort sp = (dynamic)sender;
            string data = sp.ReadLine();

            string key = data.Split(' ')[0];
            string state = data.Split(' ')[1];

            PictureBox pictureBox = key switch
            {
                "UP" => up_arrow,
                "DOWN" => down_arrow,
                "LEFT" => left_arrow,
                "RIGHT" => right_arrow,
                "OK" => nav_ok,
                "__SHOW_CONSOLE" => nav_back,
                _ => new PictureBox()
            };

            pictureBox.Visible = state == "pressed";
        }


        private void ChangePressedOrHeldPNG(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            string btn_name = radioButton.Name.Split('_')[0];
            bool isPressedSelected = radioButton.Checked;
            string context = string.Empty;

            string[] names_list = ["up", "down", "left", "right", "ok"];
            int index_of = Array.IndexOf(names_list, btn_name);
            int index_to_saving = isPressedSelected ? index_of + 4 : index_of;
            
            ComboBox comboBox = (ComboBox)Controls.Find($"{btn_name}_event_set", true)[0];
            //userEventsManager.SaveUserEvent(index_to_saving, comboBox.Text, context);

            // Reading data from class
            LoadComboBoxesAndContexts(userEventsManager);

            _ = context;

            #region Replacing image

            PictureBox pictureBox = (PictureBox)Controls.Find($"{btn_name}_mode_lbl", true)[0];
            pictureBox.BackgroundImage = isPressedSelected ?
                Resources.pressed_lbl :
                Resources.held_lbl;

            #endregion
        }

        private void LoadComboBoxesAndContexts(UserEventsManager userEventsManager)
        {
            //List<ComboBox> comboBoxes = [up_event_set, down_event_set, left_event_set, right_event_set, ok_event_set];
            bool[] isHeldChecked = [up_held_rb.Checked, down_held_rb.Checked, left_held_rb.Checked, right_held_rb.Checked, ok_held_rb.Checked];
            string[] names_list = ["up", "down", "left", "right", "ok"];
            int index = 0;

            foreach (string name in userEventsManager.GetAllSavedEventBoxes(isHeldChecked))
            {
                ComboBox comboBox = (ComboBox?)settingsTableLayoutPanel.Controls[$"{names_list[index]}_event_set"] ?? new ComboBox();
                comboBox.Text = "XXX";
                ++index;
            }

            index = 0;
            foreach (string context in userEventsManager.GetAllSavedEventContents(isHeldChecked))
            {
                // Do something with context
                ++index;
            }
        }
    }
}
