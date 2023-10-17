namespace quanlyhoso
{
    partial class FormFind
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
            this.dataQuanlyhoso_Find = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaythemhoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuanlyhoso_Find)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataQuanlyhoso_Find
            // 
            this.dataQuanlyhoso_Find.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataQuanlyhoso_Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQuanlyhoso_Find.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Luong,
            this.Sdt,
            this.Diachi,
            this.Ngaythemhoso});
            this.dataQuanlyhoso_Find.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataQuanlyhoso_Find.Location = new System.Drawing.Point(0, 58);
            this.dataQuanlyhoso_Find.Name = "dataQuanlyhoso_Find";
            this.dataQuanlyhoso_Find.RowHeadersWidth = 50;
            this.dataQuanlyhoso_Find.RowTemplate.Height = 24;
            this.dataQuanlyhoso_Find.Size = new System.Drawing.Size(1110, 186);
            this.dataQuanlyhoso_Find.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 56);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hồ sơ cần tìm";
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 244);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataQuanlyhoso_Find);
            this.Name = "FormFind";
            this.Text = "FormFind";
            this.Load += new System.EventHandler(this.FormFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataQuanlyhoso_Find)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataQuanlyhoso_Find;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaythemhoso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}