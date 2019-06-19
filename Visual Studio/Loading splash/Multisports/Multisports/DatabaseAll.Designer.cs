namespace Multisports
{
    partial class DatabaseAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseAll));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Redmem = new System.Windows.Forms.DataGridView();
            this.txt_ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv_OneDCus = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NIC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv_PriceL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Redmem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OneDCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PriceL)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Database";
            // 
            // dgv_Redmem
            // 
            this.dgv_Redmem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Redmem.Location = new System.Drawing.Point(71, 100);
            this.dgv_Redmem.Name = "dgv_Redmem";
            this.dgv_Redmem.Size = new System.Drawing.Size(618, 122);
            this.dgv_Redmem.TabIndex = 12;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ID.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ID.HintText = "Registration ID";
            this.txt_ID.isPassword = false;
            this.txt_ID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(146)))));
            this.txt_ID.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.txt_ID.LineThickness = 3;
            this.txt_ID.Location = new System.Drawing.Point(305, 68);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(159, 29);
            this.txt_ID.TabIndex = 65;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ID_KeyUp);
            // 
            // dgv_OneDCus
            // 
            this.dgv_OneDCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OneDCus.Location = new System.Drawing.Point(71, 276);
            this.dgv_OneDCus.Name = "dgv_OneDCus";
            this.dgv_OneDCus.Size = new System.Drawing.Size(618, 122);
            this.dgv_OneDCus.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Registered Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(67, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "One Day Customer ";
            // 
            // txt_NIC
            // 
            this.txt_NIC.BackColor = System.Drawing.Color.White;
            this.txt_NIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NIC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NIC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_NIC.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NIC.HintText = "NIC Number";
            this.txt_NIC.isPassword = false;
            this.txt_NIC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(146)))));
            this.txt_NIC.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NIC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.txt_NIC.LineThickness = 3;
            this.txt_NIC.Location = new System.Drawing.Point(305, 241);
            this.txt_NIC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(159, 30);
            this.txt_NIC.TabIndex = 73;
            this.txt_NIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_NIC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_NIC_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(67, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Price List";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_price.HintText = "Event Quantity";
            this.txt_price.isPassword = false;
            this.txt_price.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(146)))));
            this.txt_price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_price.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.txt_price.LineThickness = 3;
            this.txt_price.Location = new System.Drawing.Point(305, 420);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(159, 30);
            this.txt_price.TabIndex = 75;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_price_KeyUp);
            // 
            // dgv_PriceL
            // 
            this.dgv_PriceL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PriceL.Location = new System.Drawing.Point(71, 457);
            this.dgv_PriceL.Name = "dgv_PriceL";
            this.dgv_PriceL.Size = new System.Drawing.Size(618, 122);
            this.dgv_PriceL.TabIndex = 76;
            // 
            // DatabaseAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.dgv_PriceL);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_OneDCus);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.dgv_Redmem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseAll";
            this.Size = new System.Drawing.Size(746, 595);
            this.Load += new System.EventHandler(this.DatabaseAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Redmem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OneDCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PriceL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Redmem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ID;
        private System.Windows.Forms.DataGridView dgv_OneDCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NIC;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_price;
        private System.Windows.Forms.DataGridView dgv_PriceL;
    }
}
