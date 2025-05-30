namespace ClinicSystem.Forms.DoctorClinicForm
{
    partial class AvailableDoctors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.a = new Guna.UI2.WinForms.Guna2Panel();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.d1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dr = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.a.Controls.Add(this.search);
            this.a.Controls.Add(this.d1);
            this.a.Controls.Add(this.dr);
            this.a.Location = new System.Drawing.Point(137, 109);
            this.a.MaximumSize = new System.Drawing.Size(1000, 1080);
            this.a.MinimumSize = new System.Drawing.Size(500, 498);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(808, 498);
            this.a.TabIndex = 10106;
            // 
            // search
            // 
            this.search.BorderRadius = 5;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Location = new System.Drawing.Point(265, 3);
            this.search.Name = "search";
            this.search.PlaceholderText = "Search Doctor ID";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(200, 33);
            this.search.TabIndex = 10107;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // d1
            // 
            this.d1.BorderRadius = 5;
            this.d1.Checked = true;
            this.d1.FillColor = System.Drawing.Color.PaleGreen;
            this.d1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.d1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.d1.Location = new System.Drawing.Point(6, 4);
            this.d1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.d1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(243, 29);
            this.d1.TabIndex = 10003;
            this.d1.Value = new System.DateTime(2025, 4, 25, 0, 0, 0, 0);
            this.d1.ValueChanged += new System.EventHandler(this.d1_ValueChanged);
            // 
            // dr
            // 
            this.dr.AllowUserToAddRows = false;
            this.dr.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.dr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dr.ColumnHeadersHeight = 50;
            this.dr.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dr.DefaultCellStyle = dataGridViewCellStyle27;
            this.dr.GridColor = System.Drawing.Color.White;
            this.dr.Location = new System.Drawing.Point(3, 39);
            this.dr.MaximumSize = new System.Drawing.Size(1000, 1080);
            this.dr.Name = "dr";
            this.dr.ReadOnly = true;
            this.dr.RowHeadersVisible = false;
            this.dr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dr.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dr.RowTemplate.Height = 40;
            this.dr.Size = new System.Drawing.Size(802, 456);
            this.dr.TabIndex = 10105;
            this.dr.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dr.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dr.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dr.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dr.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dr.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dr.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dr.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dr.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dr.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dr.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dr.ThemeStyle.HeaderStyle.Height = 50;
            this.dr.ThemeStyle.ReadOnly = true;
            this.dr.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dr.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dr.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dr.ThemeStyle.RowsStyle.Height = 40;
            this.dr.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.panel13.Controls.Add(this.label13);
            this.panel13.Location = new System.Drawing.Point(0, -2);
            this.panel13.MaximumSize = new System.Drawing.Size(1920, 82);
            this.panel13.MinimumSize = new System.Drawing.Size(1088, 82);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1088, 82);
            this.panel13.TabIndex = 10107;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(213, 20);
            this.label13.MaximumSize = new System.Drawing.Size(1920, 37);
            this.label13.MinimumSize = new System.Drawing.Size(469, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(607, 37);
            this.label13.TabIndex = 10059;
            this.label13.Text = "Doctor\'s Available Appointment";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1084, 655);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1084, 655);
            this.Name = "AvailableDoctors";
            this.Text = "AvailableDoctors";
            this.Load += new System.EventHandler(this.AvailableDoctors_Load);
            this.a.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dr)).EndInit();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel a;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private Guna.UI2.WinForms.Guna2DateTimePicker d1;
        private Guna.UI2.WinForms.Guna2DataGridView dr;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label13;
    }
}