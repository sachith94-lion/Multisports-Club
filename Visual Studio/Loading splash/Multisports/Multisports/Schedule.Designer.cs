namespace Multisports
{
    partial class Schedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.btn_SchSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_SchID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_in = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_out = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_RDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_RUpdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ScheInsert = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_TimeSpan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Schedule = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SchIDserch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_dateserch = new System.Windows.Forms.DateTimePicker();
            this.lbl_Uname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ScheInsert)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SchSearch
            // 
            this.btn_SchSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(187)))));
            this.btn_SchSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(146)))));
            this.btn_SchSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SchSearch.BorderRadius = 0;
            this.btn_SchSearch.ButtonText = "   Search";
            this.btn_SchSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SchSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btn_SchSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_SchSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_SchSearch.Iconimage")));
            this.btn_SchSearch.Iconimage_right = null;
            this.btn_SchSearch.Iconimage_right_Selected = null;
            this.btn_SchSearch.Iconimage_Selected = null;
            this.btn_SchSearch.IconMarginLeft = 0;
            this.btn_SchSearch.IconMarginRight = 0;
            this.btn_SchSearch.IconRightVisible = true;
            this.btn_SchSearch.IconRightZoom = 0D;
            this.btn_SchSearch.IconVisible = true;
            this.btn_SchSearch.IconZoom = 60D;
            this.btn_SchSearch.IsTab = false;
            this.btn_SchSearch.Location = new System.Drawing.Point(581, 410);
            this.btn_SchSearch.Name = "btn_SchSearch";
            this.btn_SchSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(146)))));
            this.btn_SchSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btn_SchSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SchSearch.selected = false;
            this.btn_SchSearch.Size = new System.Drawing.Size(108, 31);
            this.btn_SchSearch.TabIndex = 66;
            this.btn_SchSearch.Text = "   Search";
            this.btn_SchSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SchSearch.Textcolor = System.Drawing.Color.White;
            this.btn_SchSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SchSearch.Click += new System.EventHandler(this.btn_SchSearch_Click);
            // 
            // txt_SchID
            // 
            this.txt_SchID.BackColor = System.Drawing.Color.White;
            this.txt_SchID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SchID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SchID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SchID.HintForeColor = System.Drawing.Color.Empty;
            this.txt_SchID.HintText = "";
            this.txt_SchID.isPassword = false;
            this.txt_SchID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(146)))));
            this.txt_SchID.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SchID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.txt_SchID.LineThickness = 3;
            this.txt_SchID.Location = new System.Drawing.Point(153, 32);
            this.txt_SchID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SchID.Name = "txt_SchID";
            this.txt_SchID.Size = new System.Drawing.Size(158, 30);
            this.txt_SchID.TabIndex = 65;
            this.txt_SchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Registration ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Schedule";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "MM-dd-yyyy";
            this.dtp_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(153, 80);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(158, 26);
            this.dtp_date.TabIndex = 72;
            this.dtp_date.Value = new System.DateTime(2018, 5, 6, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Date:";
            // 
            // dtp_in
            // 
            this.dtp_in.CustomFormat = "HH-MM-tt";
            this.dtp_in.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_in.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_in.Location = new System.Drawing.Point(153, 124);
            this.dtp_in.Name = "dtp_in";
            this.dtp_in.ShowUpDown = true;
            this.dtp_in.Size = new System.Drawing.Size(158, 26);
            this.dtp_in.TabIndex = 74;
            this.dtp_in.Value = new System.DateTime(2018, 5, 6, 0, 0, 0, 0);
            this.dtp_in.ValueChanged += new System.EventHandler(this.dtp_in_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "In:";
            // 
            // dtp_out
            // 
            this.dtp_out.CustomFormat = "HH-MM-tt";
            this.dtp_out.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_out.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_out.Location = new System.Drawing.Point(153, 168);
            this.dtp_out.Name = "dtp_out";
            this.dtp_out.ShowUpDown = true;
            this.dtp_out.Size = new System.Drawing.Size(158, 26);
            this.dtp_out.TabIndex = 76;
            this.dtp_out.Value = new System.DateTime(2018, 5, 6, 0, 0, 0, 0);
            this.dtp_out.ValueChanged += new System.EventHandler(this.dtp_out_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Out:";
            // 
            // btn_RDelete
            // 
            this.btn_RDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_RDelete.Image = ((System.Drawing.Image)(resources.GetObject("btn_RDelete.Image")));
            this.btn_RDelete.ImageActive = null;
            this.btn_RDelete.Location = new System.Drawing.Point(244, 251);
            this.btn_RDelete.Name = "btn_RDelete";
            this.btn_RDelete.Size = new System.Drawing.Size(61, 52);
            this.btn_RDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_RDelete.TabIndex = 87;
            this.btn_RDelete.TabStop = false;
            this.btn_RDelete.Zoom = 10;
            this.btn_RDelete.Click += new System.EventHandler(this.btn_RDelete_Click);
            // 
            // btn_RUpdate
            // 
            this.btn_RUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_RUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btn_RUpdate.Image")));
            this.btn_RUpdate.ImageActive = null;
            this.btn_RUpdate.Location = new System.Drawing.Point(131, 251);
            this.btn_RUpdate.Name = "btn_RUpdate";
            this.btn_RUpdate.Size = new System.Drawing.Size(61, 52);
            this.btn_RUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_RUpdate.TabIndex = 86;
            this.btn_RUpdate.TabStop = false;
            this.btn_RUpdate.Zoom = 10;
            this.btn_RUpdate.Click += new System.EventHandler(this.btn_RUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(252, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 90;
            this.label11.Text = "Delete";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(134, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "Update";
            // 
            // btn_ScheInsert
            // 
            this.btn_ScheInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_ScheInsert.Image = ((System.Drawing.Image)(resources.GetObject("btn_ScheInsert.Image")));
            this.btn_ScheInsert.ImageActive = null;
            this.btn_ScheInsert.Location = new System.Drawing.Point(17, 251);
            this.btn_ScheInsert.Name = "btn_ScheInsert";
            this.btn_ScheInsert.Size = new System.Drawing.Size(61, 52);
            this.btn_ScheInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ScheInsert.TabIndex = 91;
            this.btn_ScheInsert.TabStop = false;
            this.btn_ScheInsert.Zoom = 10;
            this.btn_ScheInsert.Click += new System.EventHandler(this.btn_ScheInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Time Span:";
            // 
            // lbl_TimeSpan
            // 
            this.lbl_TimeSpan.AutoSize = true;
            this.lbl_TimeSpan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeSpan.Location = new System.Drawing.Point(153, 212);
            this.lbl_TimeSpan.Name = "lbl_TimeSpan";
            this.lbl_TimeSpan.Size = new System.Drawing.Size(0, 20);
            this.lbl_TimeSpan.TabIndex = 93;
            this.lbl_TimeSpan.TextChanged += new System.EventHandler(this.lbl_TimeSpan_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_RUpdate);
            this.groupBox1.Controls.Add(this.btn_ScheInsert);
            this.groupBox1.Controls.Add(this.lbl_TimeSpan);
            this.groupBox1.Controls.Add(this.btn_RDelete);
            this.groupBox1.Controls.Add(this.txt_SchID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_in);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_out);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(201, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 334);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(29, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 95;
            this.label6.Text = "Save";
            // 
            // dgv_Schedule
            // 
            this.dgv_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Schedule.Location = new System.Drawing.Point(56, 442);
            this.dgv_Schedule.Name = "dgv_Schedule";
            this.dgv_Schedule.Size = new System.Drawing.Size(643, 150);
            this.dgv_Schedule.TabIndex = 95;
            this.dgv_Schedule.DoubleClick += new System.EventHandler(this.dgv_Schedule_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 97;
            this.label8.Text = "Registration ID:";
            // 
            // txt_SchIDserch
            // 
            this.txt_SchIDserch.BackColor = System.Drawing.Color.White;
            this.txt_SchIDserch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SchIDserch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SchIDserch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SchIDserch.HintForeColor = System.Drawing.Color.Empty;
            this.txt_SchIDserch.HintText = "";
            this.txt_SchIDserch.isPassword = false;
            this.txt_SchIDserch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(146)))));
            this.txt_SchIDserch.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SchIDserch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.txt_SchIDserch.LineThickness = 3;
            this.txt_SchIDserch.Location = new System.Drawing.Point(188, 410);
            this.txt_SchIDserch.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SchIDserch.Name = "txt_SchIDserch";
            this.txt_SchIDserch.Size = new System.Drawing.Size(158, 25);
            this.txt_SchIDserch.TabIndex = 96;
            this.txt_SchIDserch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 97;
            this.label9.Text = "Date:";
            // 
            // dtp_dateserch
            // 
            this.dtp_dateserch.CustomFormat = "MM-dd-yyyy";
            this.dtp_dateserch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateserch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateserch.Location = new System.Drawing.Point(408, 410);
            this.dtp_dateserch.Name = "dtp_dateserch";
            this.dtp_dateserch.Size = new System.Drawing.Size(158, 26);
            this.dtp_dateserch.TabIndex = 96;
            this.dtp_dateserch.Value = new System.DateTime(2018, 5, 6, 0, 0, 0, 0);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Location = new System.Drawing.Point(680, 27);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(0, 13);
            this.lbl_Uname.TabIndex = 98;
            this.lbl_Uname.Visible = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_dateserch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_Schedule);
            this.Controls.Add(this.txt_SchIDserch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SchSearch);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(746, 595);
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ScheInsert)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_SchSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SchID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_out;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btn_RDelete;
        private Bunifu.Framework.UI.BunifuImageButton btn_RUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuImageButton btn_ScheInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_TimeSpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Schedule;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SchIDserch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_dateserch;
        private System.Windows.Forms.Label lbl_Uname;
    }
}
