namespace bt_10_10_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            cboCategory = new ComboBox();
            label2 = new Label();
            lstAvailableServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            label3 = new Label();
            lstSelectedServices = new ListBox();
            groupBox1 = new GroupBox();
            txtThanhTien = new TextBox();
            txtTongTien = new TextBox();
            label6 = new Label();
            label5 = new Label();
            nudChietKhau = new NumericUpDown();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại dịch vụ:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(160, 22);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(220, 28);
            cboCategory.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Danh sách dịch vụ:";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(30, 93);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(282, 164);
            lstAvailableServices.TabIndex = 3;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(318, 109);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(60, 35);
            btnSelect.TabIndex = 4;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(318, 150);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(60, 35);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(318, 191);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(60, 35);
            btnClearAll.TabIndex = 6;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 70);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 7;
            label3.Text = "Dịch vụ đã chọn:";
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(384, 93);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(282, 164);
            lstSelectedServices.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nudChietKhau);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(30, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 150);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết thanh toán";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(190, 102);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(180, 27);
            txtThanhTien.TabIndex = 5;
            txtThanhTien.Text = "0 VNĐ";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(190, 32);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(180, 27);
            txtTongTien.TabIndex = 4;
            txtTongTien.Text = "0 VNĐ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 35);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 3;
            label6.Text = "Tổng tiền chưa giảm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 105);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 2;
            label5.Text = "Thành tiền thanh toán:";
            label5.Click += label5_Click;
            // 
            // nudChietKhau
            // 
            nudChietKhau.Location = new Point(190, 67);
            nudChietKhau.Name = "nudChietKhau";
            nudChietKhau.Size = new Size(180, 27);
            nudChietKhau.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 70);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 0;
            label4.Text = "Tỷ lệ chiết khấu (%):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(groupBox1);
            Controls.Add(lstSelectedServices);
            Controls.Add(label3);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstAvailableServices);
            Controls.Add(label2);
            Controls.Add(cboCategory);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng Tính Tiền Dịch Vụ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudChietKhau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCategory;
        private Label label2;
        private ListBox lstAvailableServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label label3;
        private ListBox lstSelectedServices;
        private GroupBox groupBox1;
        private TextBox txtThanhTien;
        private TextBox txtTongTien;
        private Label label6;
        private Label label5;
        private NumericUpDown nudChietKhau;
        private Label label4;
    }
}