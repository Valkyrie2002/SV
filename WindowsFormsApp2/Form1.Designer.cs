namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.Label maSoLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label maKhoaLabel;
            this.maSoTextBox = new System.Windows.Forms.TextBox();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new WindowsFormsApp2.QLSVDataSet();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gioiTinhCheckBox = new System.Windows.Forms.CheckBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.sinhVienDataGridView = new System.Windows.Forms.DataGridView();
            this.addSVbtn = new System.Windows.Forms.Button();
            this.deleteSVbtn = new System.Windows.Forms.Button();
            this.editSVbtn = new System.Windows.Forms.Button();
            this.sinhVienTableAdapter = new WindowsFormsApp2.QLSVDataSetTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.QLSVDataSetTableAdapters.TableAdapterManager();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maSoLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(42, 31);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(59, 20);
            maSoLabel.TabIndex = 0;
            maSoLabel.Text = "Mã Số:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(42, 77);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(65, 20);
            hoTenLabel.TabIndex = 2;
            hoTenLabel.Text = "Họ Tên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(42, 123);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(85, 20);
            ngaySinhLabel.TabIndex = 4;
            ngaySinhLabel.Text = "Ngày Sinh:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(42, 169);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(75, 20);
            gioiTinhLabel.TabIndex = 6;
            gioiTinhLabel.Text = "Giới Tính:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(593, 36);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(64, 20);
            diaChiLabel.TabIndex = 8;
            diaChiLabel.Text = "Địa Chỉ:";
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(593, 80);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(89, 20);
            dienThoaiLabel.TabIndex = 10;
            dienThoaiLabel.Text = "Điện Thoại:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(593, 122);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(76, 20);
            maKhoaLabel.TabIndex = 12;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // maSoTextBox
            // 
            this.maSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSo", true));
            this.maSoTextBox.Enabled = false;
            this.maSoTextBox.Location = new System.Drawing.Point(137, 28);
            this.maSoTextBox.Name = "maSoTextBox";
            this.maSoTextBox.Size = new System.Drawing.Size(292, 26);
            this.maSoTextBox.TabIndex = 1;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(137, 75);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(292, 26);
            this.hoTenTextBox.TabIndex = 3;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinhVienBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(137, 122);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(292, 26);
            this.ngaySinhDateTimePicker.TabIndex = 5;
            // 
            // gioiTinhCheckBox
            // 
            this.gioiTinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sinhVienBindingSource, "GioiTinh", true));
            this.gioiTinhCheckBox.Location = new System.Drawing.Point(137, 169);
            this.gioiTinhCheckBox.Name = "gioiTinhCheckBox";
            this.gioiTinhCheckBox.Size = new System.Drawing.Size(200, 24);
            this.gioiTinhCheckBox.TabIndex = 7;
            this.gioiTinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(688, 33);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(330, 26);
            this.diaChiTextBox.TabIndex = 9;
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaKhoa", true));
            this.maKhoaTextBox.Location = new System.Drawing.Point(688, 119);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(330, 26);
            this.maKhoaTextBox.TabIndex = 13;
            // 
            // sinhVienDataGridView
            // 
            this.sinhVienDataGridView.AutoGenerateColumns = false;
            this.sinhVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sinhVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sinhVienDataGridView.DataSource = this.sinhVienBindingSource;
            this.sinhVienDataGridView.Location = new System.Drawing.Point(12, 221);
            this.sinhVienDataGridView.Name = "sinhVienDataGridView";
            this.sinhVienDataGridView.ReadOnly = true;
            this.sinhVienDataGridView.RowHeadersWidth = 62;
            this.sinhVienDataGridView.RowTemplate.Height = 28;
            this.sinhVienDataGridView.Size = new System.Drawing.Size(1272, 487);
            this.sinhVienDataGridView.TabIndex = 14;
            this.sinhVienDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sinhVienDataGridView_CellContentClick);
            // 
            // addSVbtn
            // 
            this.addSVbtn.Location = new System.Drawing.Point(1067, 51);
            this.addSVbtn.Name = "addSVbtn";
            this.addSVbtn.Size = new System.Drawing.Size(75, 33);
            this.addSVbtn.TabIndex = 15;
            this.addSVbtn.Text = "Thêm";
            this.addSVbtn.UseVisualStyleBackColor = true;
            this.addSVbtn.Click += new System.EventHandler(this.addSVbtn_Click);
            // 
            // deleteSVbtn
            // 
            this.deleteSVbtn.Location = new System.Drawing.Point(1188, 51);
            this.deleteSVbtn.Name = "deleteSVbtn";
            this.deleteSVbtn.Size = new System.Drawing.Size(75, 33);
            this.deleteSVbtn.TabIndex = 16;
            this.deleteSVbtn.Text = "Xóa";
            this.deleteSVbtn.UseVisualStyleBackColor = true;
            this.deleteSVbtn.Click += new System.EventHandler(this.deleteSVbtn_Click);
            // 
            // editSVbtn
            // 
            this.editSVbtn.Location = new System.Drawing.Point(1188, 109);
            this.editSVbtn.Name = "editSVbtn";
            this.editSVbtn.Size = new System.Drawing.Size(75, 33);
            this.editSVbtn.TabIndex = 17;
            this.editSVbtn.Text = "Sửa";
            this.editSVbtn.UseVisualStyleBackColor = true;
            this.editSVbtn.Click += new System.EventHandler(this.editSVbtn_Click);
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.QLSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1067, 109);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 33);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // dienThoaiTextBox
            // 
            this.dienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "DienThoai", true));
            this.dienThoaiTextBox.Location = new System.Drawing.Point(688, 77);
            this.dienThoaiTextBox.Name = "dienThoaiTextBox";
            this.dienThoaiTextBox.Size = new System.Drawing.Size(330, 26);
            this.dienThoaiTextBox.TabIndex = 11;
            // 
            // MaSo
            // 
            this.MaSo.DataPropertyName = "MaSo";
            this.MaSo.HeaderText = "Mã Số";
            this.MaSo.MinimumWidth = 8;
            this.MaSo.Name = "MaSo";
            this.MaSo.ReadOnly = true;
            this.MaSo.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 157;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "GioiTinh";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Giới Tính";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DienThoai";
            this.dataGridViewTextBoxColumn5.HeaderText = "Điện Thoại";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaKhoa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã Khoa";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 720);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.editSVbtn);
            this.Controls.Add(this.deleteSVbtn);
            this.Controls.Add(this.addSVbtn);
            this.Controls.Add(this.sinhVienDataGridView);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(this.maSoTextBox);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhCheckBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(dienThoaiLabel);
            this.Controls.Add(this.dienThoaiTextBox);
            this.Controls.Add(maKhoaLabel);
            this.Controls.Add(this.maKhoaTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private QLSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maSoTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.CheckBox gioiTinhCheckBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox maKhoaTextBox;
        private System.Windows.Forms.DataGridView sinhVienDataGridView;
        private System.Windows.Forms.Button addSVbtn;
        private System.Windows.Forms.Button deleteSVbtn;
        private System.Windows.Forms.Button editSVbtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox dienThoaiTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

