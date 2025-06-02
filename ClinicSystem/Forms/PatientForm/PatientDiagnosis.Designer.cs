namespace ClinicSystem.Forms.PatientForm
{
    partial class PatientDiagnosis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.b1 = new Guna.UI2.WinForms.Guna2Button();
            this.pr = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dd = new Guna.UI2.WinForms.Guna2Button();
            this.limitD = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.b2 = new Guna.UI2.WinForms.Guna2Button();
            this.d2d = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pd = new Guna.UI2.WinForms.Guna2Button();
            this.pb = new Guna.UI2.WinForms.Guna2Button();
            this.d1p = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1p)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.BorderRadius = 10;
            this.b1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.b1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(394, 530);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(145, 45);
            this.b1.TabIndex = 1;
            this.b1.Text = "Save and Print Prescription";
            this.b1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pr
            // 
            this.pr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pr.DefaultText = "";
            this.pr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pr.ForeColor = System.Drawing.Color.Black;
            this.pr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pr.Location = new System.Drawing.Point(13, 449);
            this.pr.MaxLength = 200;
            this.pr.Multiline = true;
            this.pr.Name = "pr";
            this.pr.PlaceholderText = "";
            this.pr.SelectedText = "";
            this.pr.Size = new System.Drawing.Size(375, 126);
            this.pr.TabIndex = 3;
            this.pr.TextChanged += new System.EventHandler(this.pr_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.dd);
            this.guna2Panel1.Controls.Add(this.limitD);
            this.guna2Panel1.Controls.Add(this.l1);
            this.guna2Panel1.Controls.Add(this.b2);
            this.guna2Panel1.Controls.Add(this.d2d);
            this.guna2Panel1.Controls.Add(this.pd);
            this.guna2Panel1.Controls.Add(this.pb);
            this.guna2Panel1.Controls.Add(this.d1p);
            this.guna2Panel1.Controls.Add(this.pr);
            this.guna2Panel1.Controls.Add(this.b1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.MaximumSize = new System.Drawing.Size(1000, 600);
            this.guna2Panel1.MinimumSize = new System.Drawing.Size(1000, 600);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 600);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(13, 80);
            this.guna2Button1.MaximumSize = new System.Drawing.Size(145, 35);
            this.guna2Button1.MinimumSize = new System.Drawing.Size(145, 35);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(145, 35);
            this.guna2Button1.TabIndex = 42;
            this.guna2Button1.Text = "Print";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = global::ClinicSystem.Properties.Resources.error;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(981, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(16, 16);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 41;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // dd
            // 
            this.dd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dd.BorderRadius = 10;
            this.dd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.dd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dd.ForeColor = System.Drawing.Color.White;
            this.dd.Location = new System.Drawing.Point(844, 80);
            this.dd.MaximumSize = new System.Drawing.Size(145, 35);
            this.dd.MinimumSize = new System.Drawing.Size(145, 35);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(145, 35);
            this.dd.TabIndex = 40;
            this.dd.Text = "Discharge";
            this.dd.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // limitD
            // 
            this.limitD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limitD.AutoSize = true;
            this.limitD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitD.Location = new System.Drawing.Point(12, 578);
            this.limitD.Name = "limitD";
            this.limitD.Size = new System.Drawing.Size(133, 17);
            this.limitD.TabIndex = 30;
            this.limitD.Text = "Up to 200 characters.";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(397, 58);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(194, 45);
            this.l1.TabIndex = 9;
            this.l1.Text = "Prescription";
            // 
            // b2
            // 
            this.b2.BorderRadius = 10;
            this.b2.BorderThickness = 1;
            this.b2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b2.Enabled = false;
            this.b2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.b2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b2.ForeColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(394, 479);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(145, 45);
            this.b2.TabIndex = 8;
            this.b2.Text = "Save and Print Diagnosis";
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // d2d
            // 
            this.d2d.AllowUserToAddRows = false;
            this.d2d.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.d2d.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.d2d.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d2d.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d2d.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.d2d.ColumnHeadersHeight = 40;
            this.d2d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.d2d.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d2d.DefaultCellStyle = dataGridViewCellStyle27;
            this.d2d.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.d2d.Location = new System.Drawing.Point(13, 121);
            this.d2d.MultiSelect = false;
            this.d2d.Name = "d2d";
            this.d2d.ReadOnly = true;
            this.d2d.RowHeadersVisible = false;
            this.d2d.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d2d.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.d2d.RowTemplate.Height = 60;
            this.d2d.Size = new System.Drawing.Size(976, 322);
            this.d2d.TabIndex = 7;
            this.d2d.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.d2d.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.d2d.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.d2d.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.d2d.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.d2d.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.d2d.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.d2d.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.d2d.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.d2d.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2d.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.d2d.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.d2d.ThemeStyle.HeaderStyle.Height = 40;
            this.d2d.ThemeStyle.ReadOnly = true;
            this.d2d.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.d2d.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.d2d.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2d.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.d2d.ThemeStyle.RowsStyle.Height = 60;
            this.d2d.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.d2d.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.d2d.Visible = false;
            this.d2d.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.d2d_DataBindingComplete);
            this.d2d.MouseClick += new System.Windows.Forms.MouseEventHandler(this.d2d_MouseClick);
            // 
            // pd
            // 
            this.pd.BorderRadius = 10;
            this.pd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pd.ForeColor = System.Drawing.Color.White;
            this.pd.Location = new System.Drawing.Point(198, 12);
            this.pd.Name = "pd";
            this.pd.Size = new System.Drawing.Size(156, 40);
            this.pd.TabIndex = 6;
            this.pd.Text = "Diagnosis";
            this.pd.Click += new System.EventHandler(this.guna2Button3_Click);
            this.pd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pd_MouseClick);
            // 
            // pb
            // 
            this.pb.BorderRadius = 10;
            this.pb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pb.ForeColor = System.Drawing.Color.White;
            this.pb.Location = new System.Drawing.Point(13, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(156, 40);
            this.pb.TabIndex = 5;
            this.pb.Text = "Prescription";
            this.pb.Click += new System.EventHandler(this.guna2Button2_Click);
            this.pb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pd_MouseClick);
            // 
            // d1p
            // 
            this.d1p.AllowUserToAddRows = false;
            this.d1p.AllowUserToDeleteRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.d1p.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.d1p.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d1p.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.d1p.ColumnHeadersHeight = 40;
            this.d1p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.d1p.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d1p.DefaultCellStyle = dataGridViewCellStyle31;
            this.d1p.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.d1p.Location = new System.Drawing.Point(13, 121);
            this.d1p.MultiSelect = false;
            this.d1p.Name = "d1p";
            this.d1p.ReadOnly = true;
            this.d1p.RowHeadersVisible = false;
            this.d1p.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d1p.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.d1p.RowTemplate.Height = 60;
            this.d1p.Size = new System.Drawing.Size(976, 322);
            this.d1p.TabIndex = 4;
            this.d1p.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.d1p.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.d1p.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.d1p.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.d1p.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.d1p.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.d1p.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.d1p.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.d1p.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.d1p.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1p.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.d1p.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.d1p.ThemeStyle.HeaderStyle.Height = 40;
            this.d1p.ThemeStyle.ReadOnly = true;
            this.d1p.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.d1p.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.d1p.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1p.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.d1p.ThemeStyle.RowsStyle.Height = 60;
            this.d1p.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.d1p.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.d1p.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.d1p_DataBindingComplete);
            this.d1p.MouseClick += new System.Windows.Forms.MouseEventHandler(this.d1_MouseClick);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 200;
            // 
            // PatientDiagnosis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "PatientDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientDiagnosis";
            this.Deactivate += new System.EventHandler(this.PatientDiagnosis_Deactivate);
            this.Load += new System.EventHandler(this.PatientDiagnosis_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button b1;
        private Guna.UI2.WinForms.Guna2TextBox pr;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView d1p;
        private Guna.UI2.WinForms.Guna2Button pd;
        private Guna.UI2.WinForms.Guna2Button pb;
        private Guna.UI2.WinForms.Guna2DataGridView d2d;
        private Guna.UI2.WinForms.Guna2Button b2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label limitD;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button dd;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}