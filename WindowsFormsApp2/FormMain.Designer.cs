using System;

namespace quanlyhoso
{
    partial class FrmMain
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
            this.dataQuanlyhoso = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaythemhoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemhoso = new System.Windows.Forms.Button();
            this.btnFindbyname = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSL = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.buttonAddrandom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Max = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Min = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindbytime = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.labelDiachi = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.labelSdt = new System.Windows.Forms.Label();
            this.dateTimePicker_Add = new System.Windows.Forms.DateTimePicker();
            this.labelNgaythemhoso = new System.Windows.Forms.Label();
            this.labelLuong = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFindbyname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuanlyhoso)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataQuanlyhoso
            // 
            this.dataQuanlyhoso.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataQuanlyhoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQuanlyhoso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Luong,
            this.Sdt,
            this.Diachi,
            this.Ngaythemhoso});
            this.dataQuanlyhoso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataQuanlyhoso.Location = new System.Drawing.Point(0, 299);
            this.dataQuanlyhoso.Name = "dataQuanlyhoso";
            this.dataQuanlyhoso.RowHeadersWidth = 51;
            this.dataQuanlyhoso.RowTemplate.Height = 24;
            this.dataQuanlyhoso.Size = new System.Drawing.Size(1118, 276);
            this.dataQuanlyhoso.TabIndex = 6;
            this.dataQuanlyhoso.TabStop = false;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 200;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            this.Luong.Width = 150;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "SĐT";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 150;
            // 
            // Ngaythemhoso
            // 
            this.Ngaythemhoso.DataPropertyName = "Ngaythemhoso";
            this.Ngaythemhoso.HeaderText = "Ngày thêm hồ sơ";
            this.Ngaythemhoso.MinimumWidth = 6;
            this.Ngaythemhoso.Name = "Ngaythemhoso";
            this.Ngaythemhoso.Width = 150;
            // 
            // btnThemhoso
            // 
            this.btnThemhoso.AutoSize = true;
            this.btnThemhoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemhoso.Location = new System.Drawing.Point(474, 90);
            this.btnThemhoso.Name = "btnThemhoso";
            this.btnThemhoso.Size = new System.Drawing.Size(163, 30);
            this.btnThemhoso.TabIndex = 6;
            this.btnThemhoso.Text = "Thêm Hồ sơ";
            this.btnThemhoso.UseVisualStyleBackColor = true;
            this.btnThemhoso.Click += new System.EventHandler(this.btnThemhoso_Click);
            // 
            // btnFindbyname
            // 
            this.btnFindbyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindbyname.Location = new System.Drawing.Point(725, 11);
            this.btnFindbyname.Name = "btnFindbyname";
            this.btnFindbyname.Size = new System.Drawing.Size(75, 26);
            this.btnFindbyname.TabIndex = 8;
            this.btnFindbyname.Text = "Tìm";
            this.btnFindbyname.UseVisualStyleBackColor = true;
            this.btnFindbyname.Click += new System.EventHandler(this.btnFindbyname_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSL);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.buttonAddrandom);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 300);
            this.panel1.TabIndex = 10;
            this.panel1.TabStop = true;
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSL.Location = new System.Drawing.Point(864, 269);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(125, 20);
            this.labelSL.TabIndex = 19;
            this.labelSL.Text = "Số lượng hồ sơ:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(1016, 269);
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(40, 22);
            this.txtSL.TabIndex = 18;
            // 
            // buttonAddrandom
            // 
            this.buttonAddrandom.AutoSize = true;
            this.buttonAddrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddrandom.Location = new System.Drawing.Point(893, 196);
            this.buttonAddrandom.Name = "buttonAddrandom";
            this.buttonAddrandom.Size = new System.Drawing.Size(163, 30);
            this.buttonAddrandom.TabIndex = 7;
            this.buttonAddrandom.Text = "Tạo Ngẫu Nhiên";
            this.buttonAddrandom.UseVisualStyleBackColor = true;
            this.buttonAddrandom.Click += new System.EventHandler(this.buttonAddrandom_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dateTimePicker_Max);
            this.panel3.Controls.Add(this.dateTimePicker_Min);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnFindbytime);
            this.panel3.Location = new System.Drawing.Point(17, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 48);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "đến";
            // 
            // dateTimePicker_Max
            // 
            this.dateTimePicker_Max.CustomFormat = "dd/MM/yyyy hh mm:tt";
            this.dateTimePicker_Max.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Max.Location = new System.Drawing.Point(493, 17);
            this.dateTimePicker_Max.Name = "dateTimePicker_Max";
            this.dateTimePicker_Max.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker_Max.TabIndex = 10;
            // 
            // dateTimePicker_Min
            // 
            this.dateTimePicker_Min.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimePicker_Min.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Min.Location = new System.Drawing.Point(228, 15);
            this.dateTimePicker_Min.Name = "dateTimePicker_Min";
            this.dateTimePicker_Min.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker_Min.TabIndex = 9;
            this.dateTimePicker_Min.ValueChanged += new System.EventHandler(this.dateTimePicker_Min_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo thời gian";
            // 
            // btnFindbytime
            // 
            this.btnFindbytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindbytime.Location = new System.Drawing.Point(725, 11);
            this.btnFindbytime.Name = "btnFindbytime";
            this.btnFindbytime.Size = new System.Drawing.Size(75, 26);
            this.btnFindbytime.TabIndex = 11;
            this.btnFindbytime.Text = "Tìm";
            this.btnFindbytime.UseVisualStyleBackColor = true;
            this.btnFindbytime.Click += new System.EventHandler(this.btnFindbytime_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.txtDiachi);
            this.panel5.Controls.Add(this.labelDiachi);
            this.panel5.Controls.Add(this.txtSdt);
            this.panel5.Controls.Add(this.labelSdt);
            this.panel5.Controls.Add(this.btnThemhoso);
            this.panel5.Controls.Add(this.dateTimePicker_Add);
            this.panel5.Controls.Add(this.labelNgaythemhoso);
            this.panel5.Controls.Add(this.labelLuong);
            this.panel5.Controls.Add(this.txtLuong);
            this.panel5.Controls.Add(this.txtTen);
            this.panel5.Controls.Add(this.labelTen);
            this.panel5.Location = new System.Drawing.Point(17, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(816, 146);
            this.panel5.TabIndex = 1;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(474, 6);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(197, 27);
            this.txtDiachi.TabIndex = 4;
            // 
            // labelDiachi
            // 
            this.labelDiachi.AutoSize = true;
            this.labelDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiachi.Location = new System.Drawing.Point(393, 8);
            this.labelDiachi.Name = "labelDiachi";
            this.labelDiachi.Size = new System.Drawing.Size(61, 20);
            this.labelDiachi.TabIndex = 8;
            this.labelDiachi.Text = "Địa chỉ";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(96, 87);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(197, 27);
            this.txtSdt.TabIndex = 3;
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdt.Location = new System.Drawing.Point(15, 90);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(42, 20);
            this.labelSdt.TabIndex = 6;
            this.labelSdt.Text = "SĐT";
            // 
            // dateTimePicker_Add
            // 
            this.dateTimePicker_Add.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimePicker_Add.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Add.Location = new System.Drawing.Point(474, 49);
            this.dateTimePicker_Add.Name = "dateTimePicker_Add";
            this.dateTimePicker_Add.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker_Add.TabIndex = 5;
            // 
            // labelNgaythemhoso
            // 
            this.labelNgaythemhoso.AutoSize = true;
            this.labelNgaythemhoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaythemhoso.Location = new System.Drawing.Point(323, 51);
            this.labelNgaythemhoso.Name = "labelNgaythemhoso";
            this.labelNgaythemhoso.Size = new System.Drawing.Size(135, 20);
            this.labelNgaythemhoso.TabIndex = 4;
            this.labelNgaythemhoso.Text = "Ngày thêm hồ sơ";
            // 
            // labelLuong
            // 
            this.labelLuong.AutoSize = true;
            this.labelLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuong.Location = new System.Drawing.Point(15, 51);
            this.labelLuong.Name = "labelLuong";
            this.labelLuong.Size = new System.Drawing.Size(55, 20);
            this.labelLuong.TabIndex = 2;
            this.labelLuong.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(96, 48);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(197, 27);
            this.txtLuong.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(96, 8);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(197, 27);
            this.txtTen.TabIndex = 1;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(15, 9);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(37, 20);
            this.labelTen.TabIndex = 0;
            this.labelTen.Text = "Tên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFindbyname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFindbyname);
            this.panel2.Location = new System.Drawing.Point(17, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 48);
            this.panel2.TabIndex = 10;
            this.panel2.TabStop = true;
            // 
            // txtFindbyname
            // 
            this.txtFindbyname.Location = new System.Drawing.Point(228, 11);
            this.txtFindbyname.Name = "txtFindbyname";
            this.txtFindbyname.Size = new System.Drawing.Size(197, 22);
            this.txtFindbyname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataQuanlyhoso);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hồ sơ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataQuanlyhoso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView dataQuanlyhoso;
        private System.Windows.Forms.Button btnThemhoso;
        private System.Windows.Forms.Button btnFindbyname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFindbyname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Max;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindbytime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label labelDiachi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label labelSdt;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Add;
        private System.Windows.Forms.Label labelNgaythemhoso;
        private System.Windows.Forms.Label labelLuong;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaythemhoso;
        private System.Windows.Forms.Button buttonAddrandom;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label labelSL;
    }
}

