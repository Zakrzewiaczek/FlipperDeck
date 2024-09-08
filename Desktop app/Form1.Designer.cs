namespace FlipperDeck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flipper_body_img = new PictureBox();
            settings_btn = new PictureBox();
            close_btn = new PictureBox();
            minimize_icon = new PictureBox();
            lbl_logo = new PictureBox();
            title_bar_panel = new Panel();
            png_logo = new PictureBox();
            connection_state = new Label();
            left_arrow = new PictureBox();
            right_arrow = new PictureBox();
            up_arrow = new PictureBox();
            down_arrow = new PictureBox();
            nav_ok = new PictureBox();
            nav_back = new PictureBox();
            com_list = new ListBox();
            connect_btn = new Button();
            connection_panel = new Panel();
            disconnect_btn = new Button();
            up_event_set = new ComboBox();
            settingsTableLayoutPanel = new TableLayoutPanel();
            panel5 = new Panel();
            ok_pressed_rb = new RadioButton();
            ok_held_rb = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            panel4 = new Panel();
            right_pressed_rb = new RadioButton();
            right_held_rb = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            panel3 = new Panel();
            left_pressed_rb = new RadioButton();
            left_held_rb = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            panel2 = new Panel();
            down_pressed_rb = new RadioButton();
            down_held_rb = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            up_rb_panel = new Panel();
            up_pressed_rb = new RadioButton();
            up_held_rb = new RadioButton();
            ok_event_set = new ComboBox();
            right_event_set = new ComboBox();
            left_event_set = new ComboBox();
            down_event_set = new ComboBox();
            ok_png = new PictureBox();
            right_png = new PictureBox();
            left_png = new PictureBox();
            down_png = new PictureBox();
            up_png = new PictureBox();
            up_mode_lbl = new PictureBox();
            down_mode_lbl = new PictureBox();
            left_mode_lbl = new PictureBox();
            right_mode_lbl = new PictureBox();
            ok_mode_lbl = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)flipper_body_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settings_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimize_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lbl_logo).BeginInit();
            title_bar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)png_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left_arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right_arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)up_arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)down_arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nav_ok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nav_back).BeginInit();
            connection_panel.SuspendLayout();
            settingsTableLayoutPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            up_rb_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ok_png).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right_png).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left_png).BeginInit();
            ((System.ComponentModel.ISupportInitialize)down_png).BeginInit();
            ((System.ComponentModel.ISupportInitialize)up_png).BeginInit();
            ((System.ComponentModel.ISupportInitialize)up_mode_lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)down_mode_lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left_mode_lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right_mode_lbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ok_mode_lbl).BeginInit();
            SuspendLayout();
            // 
            // flipper_body_img
            // 
            flipper_body_img.BackgroundImage = Properties.Resources.flipper_body;
            flipper_body_img.BackgroundImageLayout = ImageLayout.Zoom;
            flipper_body_img.Location = new Point(209, 92);
            flipper_body_img.Name = "flipper_body_img";
            flipper_body_img.Size = new Size(431, 196);
            flipper_body_img.TabIndex = 0;
            flipper_body_img.TabStop = false;
            // 
            // settings_btn
            // 
            settings_btn.BackgroundImage = Properties.Resources.settings_icon;
            settings_btn.BackgroundImageLayout = ImageLayout.Zoom;
            settings_btn.Cursor = Cursors.Hand;
            settings_btn.Location = new Point(12, 12);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(30, 30);
            settings_btn.TabIndex = 2;
            settings_btn.TabStop = false;
            // 
            // close_btn
            // 
            close_btn.BackgroundImage = Properties.Resources.close_icon;
            close_btn.BackgroundImageLayout = ImageLayout.Zoom;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Location = new Point(849, 16);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(20, 20);
            close_btn.TabIndex = 3;
            close_btn.TabStop = false;
            close_btn.Click += CloseApplication;
            // 
            // minimize_icon
            // 
            minimize_icon.BackgroundImage = Properties.Resources.minimize_icon;
            minimize_icon.BackgroundImageLayout = ImageLayout.Zoom;
            minimize_icon.Cursor = Cursors.Hand;
            minimize_icon.Location = new Point(814, 16);
            minimize_icon.Name = "minimize_icon";
            minimize_icon.Size = new Size(20, 20);
            minimize_icon.TabIndex = 4;
            minimize_icon.TabStop = false;
            minimize_icon.Click += MinimizeApplication;
            // 
            // lbl_logo
            // 
            lbl_logo.BackgroundImage = Properties.Resources.logo;
            lbl_logo.BackgroundImageLayout = ImageLayout.Zoom;
            lbl_logo.Location = new Point(375, 9);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(172, 35);
            lbl_logo.TabIndex = 5;
            lbl_logo.TabStop = false;
            // 
            // title_bar_panel
            // 
            title_bar_panel.BackColor = Color.FromArgb(22, 22, 22);
            title_bar_panel.Controls.Add(png_logo);
            title_bar_panel.Controls.Add(lbl_logo);
            title_bar_panel.Controls.Add(settings_btn);
            title_bar_panel.Controls.Add(minimize_icon);
            title_bar_panel.Controls.Add(close_btn);
            title_bar_panel.Location = new Point(0, 0);
            title_bar_panel.Name = "title_bar_panel";
            title_bar_panel.Size = new Size(884, 54);
            title_bar_panel.TabIndex = 6;
            // 
            // png_logo
            // 
            png_logo.BackgroundImage = Properties.Resources.flipperdeck_icon_white;
            png_logo.BackgroundImageLayout = ImageLayout.Zoom;
            png_logo.Location = new Point(324, 9);
            png_logo.Name = "png_logo";
            png_logo.Size = new Size(35, 35);
            png_logo.TabIndex = 6;
            png_logo.TabStop = false;
            // 
            // connection_state
            // 
            connection_state.AutoSize = true;
            connection_state.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            connection_state.ForeColor = Color.Red;
            connection_state.Location = new Point(381, 64);
            connection_state.Name = "connection_state";
            connection_state.Size = new Size(110, 21);
            connection_state.TabIndex = 7;
            connection_state.Text = "Disconnected";
            connection_state.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // left_arrow
            // 
            left_arrow.BackgroundImage = Properties.Resources.left_arrow;
            left_arrow.BackgroundImageLayout = ImageLayout.Zoom;
            left_arrow.Location = new Point(501, 158);
            left_arrow.Name = "left_arrow";
            left_arrow.Size = new Size(15, 15);
            left_arrow.TabIndex = 8;
            left_arrow.TabStop = false;
            left_arrow.Visible = false;
            // 
            // right_arrow
            // 
            right_arrow.BackgroundImage = Properties.Resources.right_arrow;
            right_arrow.BackgroundImageLayout = ImageLayout.Zoom;
            right_arrow.Location = new Point(558, 158);
            right_arrow.Name = "right_arrow";
            right_arrow.Size = new Size(15, 15);
            right_arrow.TabIndex = 10;
            right_arrow.TabStop = false;
            right_arrow.Visible = false;
            // 
            // up_arrow
            // 
            up_arrow.BackgroundImage = Properties.Resources.up_arrow;
            up_arrow.BackgroundImageLayout = ImageLayout.Zoom;
            up_arrow.Location = new Point(530, 130);
            up_arrow.Name = "up_arrow";
            up_arrow.Size = new Size(15, 15);
            up_arrow.TabIndex = 11;
            up_arrow.TabStop = false;
            up_arrow.Visible = false;
            // 
            // down_arrow
            // 
            down_arrow.BackgroundImage = Properties.Resources.down_arrow;
            down_arrow.BackgroundImageLayout = ImageLayout.Zoom;
            down_arrow.Location = new Point(530, 186);
            down_arrow.Name = "down_arrow";
            down_arrow.Size = new Size(15, 15);
            down_arrow.TabIndex = 12;
            down_arrow.TabStop = false;
            down_arrow.Visible = false;
            // 
            // nav_ok
            // 
            nav_ok.BackgroundImage = Properties.Resources.ok;
            nav_ok.BackgroundImageLayout = ImageLayout.Zoom;
            nav_ok.Location = new Point(523, 152);
            nav_ok.Name = "nav_ok";
            nav_ok.Size = new Size(28, 28);
            nav_ok.TabIndex = 13;
            nav_ok.TabStop = false;
            nav_ok.Visible = false;
            // 
            // nav_back
            // 
            nav_back.BackgroundImage = Properties.Resources.back;
            nav_back.BackgroundImageLayout = ImageLayout.Zoom;
            nav_back.Location = new Point(586, 181);
            nav_back.Name = "nav_back";
            nav_back.Size = new Size(28, 28);
            nav_back.TabIndex = 14;
            nav_back.TabStop = false;
            nav_back.Visible = false;
            // 
            // com_list
            // 
            com_list.BackColor = Color.FromArgb(25, 25, 25);
            com_list.BorderStyle = BorderStyle.FixedSingle;
            com_list.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            com_list.ForeColor = Color.White;
            com_list.FormattingEnabled = true;
            com_list.ItemHeight = 17;
            com_list.Items.AddRange(new object[] { " " });
            com_list.Location = new Point(39, 3);
            com_list.Name = "com_list";
            com_list.RightToLeft = RightToLeft.No;
            com_list.Size = new Size(133, 87);
            com_list.TabIndex = 16;
            // 
            // connect_btn
            // 
            connect_btn.BackColor = Color.FromArgb(22, 22, 22);
            connect_btn.BackgroundImage = Properties.Resources.connect;
            connect_btn.BackgroundImageLayout = ImageLayout.Zoom;
            connect_btn.Cursor = Cursors.Hand;
            connect_btn.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            connect_btn.FlatAppearance.BorderSize = 0;
            connect_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 25);
            connect_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 25);
            connect_btn.FlatStyle = FlatStyle.Flat;
            connect_btn.Location = new Point(-1, 111);
            connect_btn.Name = "connect_btn";
            connect_btn.Size = new Size(219, 67);
            connect_btn.TabIndex = 17;
            connect_btn.UseVisualStyleBackColor = false;
            connect_btn.Click += ConnectToFlipper;
            // 
            // connection_panel
            // 
            connection_panel.Controls.Add(com_list);
            connection_panel.Controls.Add(connect_btn);
            connection_panel.Location = new Point(881, 182);
            connection_panel.Name = "connection_panel";
            connection_panel.Size = new Size(211, 184);
            connection_panel.TabIndex = 18;
            // 
            // disconnect_btn
            // 
            disconnect_btn.BackColor = Color.FromArgb(22, 22, 22);
            disconnect_btn.BackgroundImage = Properties.Resources.disconnect;
            disconnect_btn.BackgroundImageLayout = ImageLayout.Zoom;
            disconnect_btn.Cursor = Cursors.Hand;
            disconnect_btn.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
            disconnect_btn.FlatAppearance.BorderSize = 0;
            disconnect_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 25);
            disconnect_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 25);
            disconnect_btn.FlatStyle = FlatStyle.Flat;
            disconnect_btn.Location = new Point(944, 492);
            disconnect_btn.Name = "disconnect_btn";
            disconnect_btn.Size = new Size(119, 35);
            disconnect_btn.TabIndex = 18;
            disconnect_btn.UseVisualStyleBackColor = false;
            disconnect_btn.Visible = false;
            disconnect_btn.Click += DisconnectFromFlipper;
            // 
            // up_event_set
            // 
            up_event_set.Anchor = AnchorStyles.None;
            up_event_set.DropDownStyle = ComboBoxStyle.DropDownList;
            up_event_set.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            up_event_set.FormattingEnabled = true;
            up_event_set.Items.AddRange(new object[] { "None", "Open program", "Run cmd command" });
            up_event_set.Location = new Point(19, 78);
            up_event_set.Name = "up_event_set";
            up_event_set.Size = new Size(121, 23);
            up_event_set.TabIndex = 19;
            // 
            // settingsTableLayoutPanel
            // 
            settingsTableLayoutPanel.AutoSize = true;
            settingsTableLayoutPanel.ColumnCount = 5;
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.Controls.Add(panel5, 4, 2);
            settingsTableLayoutPanel.Controls.Add(panel4, 3, 2);
            settingsTableLayoutPanel.Controls.Add(panel3, 2, 2);
            settingsTableLayoutPanel.Controls.Add(panel2, 1, 2);
            settingsTableLayoutPanel.Controls.Add(up_rb_panel, 0, 2);
            settingsTableLayoutPanel.Controls.Add(ok_event_set, 4, 3);
            settingsTableLayoutPanel.Controls.Add(right_event_set, 3, 3);
            settingsTableLayoutPanel.Controls.Add(left_event_set, 2, 3);
            settingsTableLayoutPanel.Controls.Add(down_event_set, 1, 3);
            settingsTableLayoutPanel.Controls.Add(ok_png, 4, 0);
            settingsTableLayoutPanel.Controls.Add(right_png, 3, 0);
            settingsTableLayoutPanel.Controls.Add(left_png, 2, 0);
            settingsTableLayoutPanel.Controls.Add(down_png, 1, 0);
            settingsTableLayoutPanel.Controls.Add(up_png, 0, 0);
            settingsTableLayoutPanel.Controls.Add(up_event_set, 0, 3);
            settingsTableLayoutPanel.Controls.Add(up_mode_lbl, 0, 1);
            settingsTableLayoutPanel.Controls.Add(down_mode_lbl, 1, 1);
            settingsTableLayoutPanel.Controls.Add(left_mode_lbl, 2, 1);
            settingsTableLayoutPanel.Controls.Add(right_mode_lbl, 3, 1);
            settingsTableLayoutPanel.Controls.Add(ok_mode_lbl, 4, 1);
            settingsTableLayoutPanel.Location = new Point(39, 327);
            settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            settingsTableLayoutPanel.RowCount = 5;
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40.9090919F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 59.0909081F));
            settingsTableLayoutPanel.Size = new Size(795, 166);
            settingsTableLayoutPanel.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(ok_pressed_rb);
            panel5.Controls.Add(ok_held_rb);
            panel5.Controls.Add(radioButton7);
            panel5.Controls.Add(radioButton8);
            panel5.Location = new Point(639, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 17);
            panel5.TabIndex = 38;
            // 
            // ok_pressed_rb
            // 
            ok_pressed_rb.AutoSize = true;
            ok_pressed_rb.Checked = true;
            ok_pressed_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ok_pressed_rb.Location = new Point(11, -3);
            ok_pressed_rb.Name = "ok_pressed_rb";
            ok_pressed_rb.Size = new Size(65, 19);
            ok_pressed_rb.TabIndex = 40;
            ok_pressed_rb.TabStop = true;
            ok_pressed_rb.Text = "Pressed";
            ok_pressed_rb.UseVisualStyleBackColor = true;
            ok_pressed_rb.CheckedChanged += ChangePressedOrHeldPNG;
            // 
            // ok_held_rb
            // 
            ok_held_rb.AutoSize = true;
            ok_held_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ok_held_rb.Location = new Point(92, -2);
            ok_held_rb.Name = "ok_held_rb";
            ok_held_rb.Size = new Size(50, 19);
            ok_held_rb.TabIndex = 39;
            ok_held_rb.Text = "Held";
            ok_held_rb.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.Anchor = AnchorStyles.Left;
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton7.Location = new Point(10, -44);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(65, 19);
            radioButton7.TabIndex = 36;
            radioButton7.Text = "Pressed";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.Anchor = AnchorStyles.Right;
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton8.Location = new Point(44, -43);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(50, 19);
            radioButton8.TabIndex = 35;
            radioButton8.Text = "Held";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(right_pressed_rb);
            panel4.Controls.Add(right_held_rb);
            panel4.Controls.Add(radioButton5);
            panel4.Controls.Add(radioButton6);
            panel4.Location = new Point(480, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 17);
            panel4.TabIndex = 38;
            // 
            // right_pressed_rb
            // 
            right_pressed_rb.AutoSize = true;
            right_pressed_rb.Checked = true;
            right_pressed_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            right_pressed_rb.Location = new Point(11, -2);
            right_pressed_rb.Name = "right_pressed_rb";
            right_pressed_rb.Size = new Size(65, 19);
            right_pressed_rb.TabIndex = 38;
            right_pressed_rb.TabStop = true;
            right_pressed_rb.Text = "Pressed";
            right_pressed_rb.UseVisualStyleBackColor = true;
            right_pressed_rb.CheckedChanged += ChangePressedOrHeldPNG;
            // 
            // right_held_rb
            // 
            right_held_rb.AutoSize = true;
            right_held_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            right_held_rb.Location = new Point(92, -1);
            right_held_rb.Name = "right_held_rb";
            right_held_rb.Size = new Size(50, 19);
            right_held_rb.TabIndex = 37;
            right_held_rb.Text = "Held";
            right_held_rb.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.Anchor = AnchorStyles.Left;
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton5.Location = new Point(10, -44);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(65, 19);
            radioButton5.TabIndex = 36;
            radioButton5.Text = "Pressed";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.Anchor = AnchorStyles.Right;
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton6.Location = new Point(44, -43);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(50, 19);
            radioButton6.TabIndex = 35;
            radioButton6.Text = "Held";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(left_pressed_rb);
            panel3.Controls.Add(left_held_rb);
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton4);
            panel3.Location = new Point(321, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 17);
            panel3.TabIndex = 38;
            // 
            // left_pressed_rb
            // 
            left_pressed_rb.AutoSize = true;
            left_pressed_rb.Checked = true;
            left_pressed_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            left_pressed_rb.Location = new Point(11, -2);
            left_pressed_rb.Name = "left_pressed_rb";
            left_pressed_rb.Size = new Size(65, 19);
            left_pressed_rb.TabIndex = 40;
            left_pressed_rb.TabStop = true;
            left_pressed_rb.Text = "Pressed";
            left_pressed_rb.UseVisualStyleBackColor = true;
            left_pressed_rb.CheckedChanged += ChangePressedOrHeldPNG;
            // 
            // left_held_rb
            // 
            left_held_rb.AutoSize = true;
            left_held_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            left_held_rb.Location = new Point(92, -1);
            left_held_rb.Name = "left_held_rb";
            left_held_rb.Size = new Size(50, 19);
            left_held_rb.TabIndex = 39;
            left_held_rb.Text = "Held";
            left_held_rb.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Left;
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton3.Location = new Point(10, -44);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 19);
            radioButton3.TabIndex = 36;
            radioButton3.Text = "Pressed";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.Right;
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton4.Location = new Point(44, -43);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(50, 19);
            radioButton4.TabIndex = 35;
            radioButton4.Text = "Held";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(down_pressed_rb);
            panel2.Controls.Add(down_held_rb);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Location = new Point(162, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 17);
            panel2.TabIndex = 38;
            // 
            // down_pressed_rb
            // 
            down_pressed_rb.AutoSize = true;
            down_pressed_rb.Checked = true;
            down_pressed_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            down_pressed_rb.Location = new Point(11, -2);
            down_pressed_rb.Name = "down_pressed_rb";
            down_pressed_rb.Size = new Size(65, 19);
            down_pressed_rb.TabIndex = 38;
            down_pressed_rb.TabStop = true;
            down_pressed_rb.Text = "Pressed";
            down_pressed_rb.UseVisualStyleBackColor = true;
            down_pressed_rb.CheckedChanged += ChangePressedOrHeldPNG;
            // 
            // down_held_rb
            // 
            down_held_rb.AutoSize = true;
            down_held_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            down_held_rb.Location = new Point(92, -1);
            down_held_rb.Name = "down_held_rb";
            down_held_rb.Size = new Size(50, 19);
            down_held_rb.TabIndex = 37;
            down_held_rb.Text = "Held";
            down_held_rb.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton1.Location = new Point(10, -44);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 36;
            radioButton1.Text = "Pressed";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Right;
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton2.Location = new Point(44, -43);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 19);
            radioButton2.TabIndex = 35;
            radioButton2.Text = "Held";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // up_rb_panel
            // 
            up_rb_panel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            up_rb_panel.Controls.Add(up_pressed_rb);
            up_rb_panel.Controls.Add(up_held_rb);
            up_rb_panel.Location = new Point(3, 49);
            up_rb_panel.Name = "up_rb_panel";
            up_rb_panel.Size = new Size(153, 17);
            up_rb_panel.TabIndex = 37;
            // 
            // up_pressed_rb
            // 
            up_pressed_rb.AutoSize = true;
            up_pressed_rb.Checked = true;
            up_pressed_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            up_pressed_rb.Location = new Point(10, -2);
            up_pressed_rb.Name = "up_pressed_rb";
            up_pressed_rb.Size = new Size(65, 19);
            up_pressed_rb.TabIndex = 36;
            up_pressed_rb.TabStop = true;
            up_pressed_rb.Text = "Pressed";
            up_pressed_rb.UseVisualStyleBackColor = true;
            up_pressed_rb.CheckedChanged += ChangePressedOrHeldPNG;
            // 
            // up_held_rb
            // 
            up_held_rb.AutoSize = true;
            up_held_rb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            up_held_rb.Location = new Point(91, -1);
            up_held_rb.Name = "up_held_rb";
            up_held_rb.Size = new Size(50, 19);
            up_held_rb.TabIndex = 35;
            up_held_rb.Text = "Held";
            up_held_rb.UseVisualStyleBackColor = true;
            // 
            // ok_event_set
            // 
            ok_event_set.Anchor = AnchorStyles.None;
            ok_event_set.DropDownStyle = ComboBoxStyle.DropDownList;
            ok_event_set.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ok_event_set.FormattingEnabled = true;
            ok_event_set.Items.AddRange(new object[] { "None", "Open program", "Run cmd command" });
            ok_event_set.Location = new Point(655, 78);
            ok_event_set.Name = "ok_event_set";
            ok_event_set.Size = new Size(121, 23);
            ok_event_set.TabIndex = 29;
            // 
            // right_event_set
            // 
            right_event_set.Anchor = AnchorStyles.None;
            right_event_set.DropDownStyle = ComboBoxStyle.DropDownList;
            right_event_set.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            right_event_set.FormattingEnabled = true;
            right_event_set.Items.AddRange(new object[] { "None", "Open program", "Run cmd command" });
            right_event_set.Location = new Point(496, 78);
            right_event_set.Name = "right_event_set";
            right_event_set.Size = new Size(121, 23);
            right_event_set.TabIndex = 28;
            // 
            // left_event_set
            // 
            left_event_set.Anchor = AnchorStyles.None;
            left_event_set.DropDownStyle = ComboBoxStyle.DropDownList;
            left_event_set.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            left_event_set.FormattingEnabled = true;
            left_event_set.Items.AddRange(new object[] { "None", "Open program", "Run cmd command" });
            left_event_set.Location = new Point(337, 78);
            left_event_set.Name = "left_event_set";
            left_event_set.Size = new Size(121, 23);
            left_event_set.TabIndex = 27;
            // 
            // down_event_set
            // 
            down_event_set.Anchor = AnchorStyles.None;
            down_event_set.DropDownStyle = ComboBoxStyle.DropDownList;
            down_event_set.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            down_event_set.FormattingEnabled = true;
            down_event_set.Items.AddRange(new object[] { "None", "Open program", "Run cmd command" });
            down_event_set.Location = new Point(178, 78);
            down_event_set.Name = "down_event_set";
            down_event_set.Size = new Size(121, 23);
            down_event_set.TabIndex = 26;
            // 
            // ok_png
            // 
            ok_png.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ok_png.BackgroundImage = Properties.Resources.ok_lbl;
            ok_png.BackgroundImageLayout = ImageLayout.Zoom;
            ok_png.Location = new Point(639, 3);
            ok_png.Name = "ok_png";
            ok_png.Size = new Size(153, 17);
            ok_png.TabIndex = 25;
            ok_png.TabStop = false;
            // 
            // right_png
            // 
            right_png.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            right_png.BackgroundImage = Properties.Resources.right_lbl;
            right_png.BackgroundImageLayout = ImageLayout.Zoom;
            right_png.Location = new Point(480, 3);
            right_png.Name = "right_png";
            right_png.Size = new Size(153, 17);
            right_png.TabIndex = 24;
            right_png.TabStop = false;
            // 
            // left_png
            // 
            left_png.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            left_png.BackgroundImage = Properties.Resources.left_lbl;
            left_png.BackgroundImageLayout = ImageLayout.Zoom;
            left_png.Location = new Point(321, 3);
            left_png.Name = "left_png";
            left_png.Size = new Size(153, 17);
            left_png.TabIndex = 23;
            left_png.TabStop = false;
            // 
            // down_png
            // 
            down_png.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            down_png.BackgroundImage = Properties.Resources.down_lbl;
            down_png.BackgroundImageLayout = ImageLayout.Zoom;
            down_png.Location = new Point(162, 3);
            down_png.Name = "down_png";
            down_png.Size = new Size(153, 17);
            down_png.TabIndex = 22;
            down_png.TabStop = false;
            // 
            // up_png
            // 
            up_png.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            up_png.BackgroundImage = Properties.Resources.up_lbl;
            up_png.BackgroundImageLayout = ImageLayout.Zoom;
            up_png.Location = new Point(3, 3);
            up_png.Name = "up_png";
            up_png.Size = new Size(153, 17);
            up_png.TabIndex = 21;
            up_png.TabStop = false;
            // 
            // up_mode_lbl
            // 
            up_mode_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            up_mode_lbl.BackgroundImage = Properties.Resources.pressed_lbl;
            up_mode_lbl.BackgroundImageLayout = ImageLayout.Zoom;
            up_mode_lbl.Location = new Point(3, 26);
            up_mode_lbl.Name = "up_mode_lbl";
            up_mode_lbl.Size = new Size(153, 12);
            up_mode_lbl.TabIndex = 30;
            up_mode_lbl.TabStop = false;
            // 
            // down_mode_lbl
            // 
            down_mode_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            down_mode_lbl.BackgroundImage = Properties.Resources.pressed_lbl;
            down_mode_lbl.BackgroundImageLayout = ImageLayout.Zoom;
            down_mode_lbl.Location = new Point(162, 26);
            down_mode_lbl.Name = "down_mode_lbl";
            down_mode_lbl.Size = new Size(153, 12);
            down_mode_lbl.TabIndex = 31;
            down_mode_lbl.TabStop = false;
            // 
            // left_mode_lbl
            // 
            left_mode_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            left_mode_lbl.BackgroundImage = Properties.Resources.pressed_lbl;
            left_mode_lbl.BackgroundImageLayout = ImageLayout.Zoom;
            left_mode_lbl.Location = new Point(321, 26);
            left_mode_lbl.Name = "left_mode_lbl";
            left_mode_lbl.Size = new Size(153, 12);
            left_mode_lbl.TabIndex = 32;
            left_mode_lbl.TabStop = false;
            // 
            // right_mode_lbl
            // 
            right_mode_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            right_mode_lbl.BackgroundImage = Properties.Resources.pressed_lbl;
            right_mode_lbl.BackgroundImageLayout = ImageLayout.Zoom;
            right_mode_lbl.Location = new Point(480, 26);
            right_mode_lbl.Name = "right_mode_lbl";
            right_mode_lbl.Size = new Size(153, 12);
            right_mode_lbl.TabIndex = 33;
            right_mode_lbl.TabStop = false;
            // 
            // ok_mode_lbl
            // 
            ok_mode_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ok_mode_lbl.BackgroundImage = Properties.Resources.pressed_lbl;
            ok_mode_lbl.BackgroundImageLayout = ImageLayout.Zoom;
            ok_mode_lbl.Location = new Point(639, 26);
            ok_mode_lbl.Name = "ok_mode_lbl";
            ok_mode_lbl.Size = new Size(153, 12);
            ok_mode_lbl.TabIndex = 34;
            ok_mode_lbl.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1122, 636);
            Controls.Add(settingsTableLayoutPanel);
            Controls.Add(disconnect_btn);
            Controls.Add(connection_panel);
            Controls.Add(nav_back);
            Controls.Add(nav_ok);
            Controls.Add(down_arrow);
            Controls.Add(up_arrow);
            Controls.Add(right_arrow);
            Controls.Add(left_arrow);
            Controls.Add(connection_state);
            Controls.Add(title_bar_panel);
            Controls.Add(flipper_body_img);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "FlipperDeck";
            ((System.ComponentModel.ISupportInitialize)flipper_body_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)settings_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimize_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)lbl_logo).EndInit();
            title_bar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)png_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)left_arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)right_arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)up_arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)down_arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)nav_ok).EndInit();
            ((System.ComponentModel.ISupportInitialize)nav_back).EndInit();
            connection_panel.ResumeLayout(false);
            settingsTableLayoutPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            up_rb_panel.ResumeLayout(false);
            up_rb_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ok_png).EndInit();
            ((System.ComponentModel.ISupportInitialize)right_png).EndInit();
            ((System.ComponentModel.ISupportInitialize)left_png).EndInit();
            ((System.ComponentModel.ISupportInitialize)down_png).EndInit();
            ((System.ComponentModel.ISupportInitialize)up_png).EndInit();
            ((System.ComponentModel.ISupportInitialize)up_mode_lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)down_mode_lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)left_mode_lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)right_mode_lbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)ok_mode_lbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flipper_body_img;
        private PictureBox settings_btn;
        private PictureBox close_btn;
        private PictureBox minimize_icon;
        private PictureBox lbl_logo;
        private Panel title_bar_panel;
        private Label connection_state;
        private PictureBox left_arrow;
        private PictureBox right_arrow;
        private PictureBox up_arrow;
        private PictureBox down_arrow;
        private PictureBox nav_ok;
        private PictureBox nav_back;
        private ListBox com_list;
        private Button connect_btn;
        private Panel connection_panel;
        private Button disconnect_btn;
        private ComboBox up_event_set;
        private TableLayoutPanel settingsTableLayoutPanel;
        private PictureBox ok_png;
        private PictureBox right_png;
        private PictureBox left_png;
        private PictureBox down_png;
        private PictureBox up_png;
        private ComboBox ok_event_set;
        private ComboBox right_event_set;
        private ComboBox left_event_set;
        private ComboBox down_event_set;
        private PictureBox ok_mode_lbl;
        private PictureBox right_mode_lbl;
        private PictureBox left_mode_lbl;
        private PictureBox down_mode_lbl;
        private PictureBox up_mode_lbl;
        private PictureBox png_logo;
        private RadioButton up_held_rb;
        private RadioButton up_pressed_rb;
        private Panel up_rb_panel;
        private Panel panel5;
        private RadioButton ok_pressed_rb;
        private RadioButton ok_held_rb;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Panel panel4;
        private RadioButton right_pressed_rb;
        private RadioButton right_held_rb;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Panel panel3;
        private RadioButton left_pressed_rb;
        private RadioButton left_held_rb;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Panel panel2;
        private RadioButton down_pressed_rb;
        private RadioButton down_held_rb;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
