﻿namespace ClinicSystem.Appointments
{
    partial class AllAppointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sdab = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.date2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.arrow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allSchedule = new System.Windows.Forms.RadioButton();
            this.selection = new System.Windows.Forms.RadioButton();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.radioToday = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.SearchBar1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sdab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sdab
            // 
            this.sdab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sdab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sdab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.sdab.Controls.Add(this.label2);
            this.sdab.Controls.Add(this.date2);
            this.sdab.Controls.Add(this.label1);
            this.sdab.Controls.Add(this.date1);
            this.sdab.Controls.Add(this.arrow);
            this.sdab.Controls.Add(this.monthRadio);
            this.sdab.Controls.Add(this.panel2);
            this.sdab.Controls.Add(this.allSchedule);
            this.sdab.Controls.Add(this.selection);
            this.sdab.Controls.Add(this.weekRadio);
            this.sdab.Controls.Add(this.radioToday);
            this.sdab.Location = new System.Drawing.Point(0, 89);
            this.sdab.MaximumSize = new System.Drawing.Size(1920, 46);
            this.sdab.MinimumSize = new System.Drawing.Size(1086, 46);
            this.sdab.Name = "sdab";
            this.sdab.Size = new System.Drawing.Size(1086, 46);
            this.sdab.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(813, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 10091;
            this.label2.Text = "To:";
            this.label2.Visible = false;
            // 
            // date2
            // 
            this.date2.BorderRadius = 5;
            this.date2.Checked = true;
            this.date2.FillColor = System.Drawing.Color.PaleGreen;
            this.date2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(841, 4);
            this.date2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(119, 36);
            this.date2.TabIndex = 10089;
            this.date2.Value = new System.DateTime(2025, 4, 25, 11, 40, 22, 388);
            this.date2.Visible = false;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 10090;
            this.label1.Text = "From:";
            this.label1.Visible = false;
            // 
            // date1
            // 
            this.date1.BorderRadius = 5;
            this.date1.Checked = true;
            this.date1.FillColor = System.Drawing.Color.PaleGreen;
            this.date1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(649, 4);
            this.date1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(119, 36);
            this.date1.TabIndex = 6;
            this.date1.Value = new System.DateTime(2025, 4, 25, 11, 40, 22, 388);
            this.date1.Visible = false;
            this.date1.ValueChanged += new System.EventHandler(this.datePickDate_ValueChanged_1);
            // 
            // arrow
            // 
            this.arrow.Image = global::ClinicSystem.Properties.Resources.next;
            this.arrow.ImageRotate = 0F;
            this.arrow.Location = new System.Drawing.Point(771, 12);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(37, 24);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow.TabIndex = 10088;
            this.arrow.TabStop = false;
            this.arrow.Visible = false;
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRadio.Location = new System.Drawing.Point(184, 13);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(70, 24);
            this.monthRadio.TabIndex = 11;
            this.monthRadio.TabStop = true;
            this.monthRadio.Text = "Month";
            this.monthRadio.UseVisualStyleBackColor = true;
            this.monthRadio.CheckedChanged += new System.EventHandler(this.monthRadio_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(2, 46);
            this.panel2.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panel2.MinimumSize = new System.Drawing.Size(1088, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 525);
            this.panel2.TabIndex = 10087;
            // 
            // allSchedule
            // 
            this.allSchedule.AutoSize = true;
            this.allSchedule.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allSchedule.Location = new System.Drawing.Point(273, 12);
            this.allSchedule.Name = "allSchedule";
            this.allSchedule.Size = new System.Drawing.Size(137, 24);
            this.allSchedule.TabIndex = 10;
            this.allSchedule.TabStop = true;
            this.allSchedule.Text = "All Appointment";
            this.allSchedule.UseVisualStyleBackColor = true;
            this.allSchedule.CheckedChanged += new System.EventHandler(this.allSchedule_CheckedChanged);
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection.Location = new System.Drawing.Point(434, 12);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(101, 24);
            this.selection.TabIndex = 9;
            this.selection.TabStop = true;
            this.selection.Text = "Pick a Date";
            this.selection.UseVisualStyleBackColor = true;
            this.selection.CheckedChanged += new System.EventHandler(this.selection_CheckedChanged);
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRadio.Location = new System.Drawing.Point(104, 13);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(63, 24);
            this.weekRadio.TabIndex = 8;
            this.weekRadio.TabStop = true;
            this.weekRadio.Text = "Week";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.weekRadio_CheckedChanged);
            // 
            // radioToday
            // 
            this.radioToday.AutoSize = true;
            this.radioToday.Checked = true;
            this.radioToday.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioToday.Location = new System.Drawing.Point(23, 13);
            this.radioToday.Name = "radioToday";
            this.radioToday.Size = new System.Drawing.Size(67, 24);
            this.radioToday.TabIndex = 7;
            this.radioToday.TabStop = true;
            this.radioToday.Text = "Today";
            this.radioToday.UseVisualStyleBackColor = true;
            this.radioToday.CheckedChanged += new System.EventHandler(this.radioToday_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panel9.MinimumSize = new System.Drawing.Size(1086, 97);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1086, 97);
            this.panel9.TabIndex = 10086;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.SearchBar1);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(3, 14);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(302, 69);
            this.panel11.TabIndex = 10060;
            // 
            // SearchBar1
            // 
            this.SearchBar1.BorderRadius = 5;
            this.SearchBar1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar1.DefaultText = "";
            this.SearchBar1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchBar1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar1.IconRight = global::ClinicSystem.Properties.Resources.search24;
            this.SearchBar1.Location = new System.Drawing.Point(10, 28);
            this.SearchBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBar1.Name = "SearchBar1";
            this.SearchBar1.PlaceholderText = "";
            this.SearchBar1.SelectedText = "";
            this.SearchBar1.Size = new System.Drawing.Size(266, 37);
            this.SearchBar1.TabIndex = 11;
            this.SearchBar1.TextChanged += new System.EventHandler(this.SearchBar1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Search By Operation | Appointment No. | Doctor Name";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(417, 21);
            this.label7.MaximumSize = new System.Drawing.Size(1920, 37);
            this.label7.MinimumSize = new System.Drawing.Size(226, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 37);
            this.label7.TabIndex = 10059;
            this.label7.Text = "Appointments";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.guna2Panel1.Controls.Add(this.dataGrid);
            this.guna2Panel1.Location = new System.Drawing.Point(-4, 135);
            this.guna2Panel1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.guna2Panel1.MinimumSize = new System.Drawing.Size(1090, 525);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1090, 525);
            this.guna2Panel1.TabIndex = 10087;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.GridColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(13, 0);
            this.dataGrid.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.dataGrid.MinimumSize = new System.Drawing.Size(1065, 528);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.RowTemplate.Height = 70;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.Size = new System.Drawing.Size(1065, 528);
            this.dataGrid.TabIndex = 19;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 60;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.ThemeStyle.RowsStyle.Height = 70;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AllAppointments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1084, 659);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sdab);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1084, 659);
            this.Name = "AllAppointments";
            this.Text = "AllAppointments";
            this.Load += new System.EventHandler(this.AllAppointments_Load);
            this.Shown += new System.EventHandler(this.AllAppointments_Shown);
            this.sdab.ResumeLayout(false);
            this.sdab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sdab;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker date1;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioToday;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.RadioButton allSchedule;
        private System.Windows.Forms.RadioButton selection;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox arrow;
        private Guna.UI2.WinForms.Guna2DateTimePicker date2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
    }
}