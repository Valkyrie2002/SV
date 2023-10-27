
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
        }

        private void sinhVienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
        }

        private bool checkInfor()
        {
            if (string.IsNullOrEmpty(maSoTextBox.Text) || string.IsNullOrEmpty(hoTenTextBox.Text) ||
                    string.IsNullOrEmpty(diaChiTextBox.Text) || string.IsNullOrEmpty(dienThoaiTextBox.Text) ||
                    string.IsNullOrEmpty(maKhoaTextBox.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return false;
            }

            int maSo;
            if (!int.TryParse(maSoTextBox.Text, out maSo))
            {
                MessageBox.Show("Mã số phải là một số nguyên.");
                return false;
            }

            int dienThoai;
            if (!int.TryParse(dienThoaiTextBox.Text, out dienThoai))
            {
                MessageBox.Show("Số điện thoại phải là một số nguyên.");
                return false;
            }

            return true;
        }
        private void addSVbtn_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=AN;Initial Catalog=QLSV;User ID=qlcf;Password=1234";
            
            if(checkInfor())
            {
                using (SqlConnection connection = new SqlConnection(strCon))
                {
                    string query = "INSERT INTO SinhVien (MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaKhoa) VALUES (@MaSo, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @MaKhoa)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    int maSo = int.Parse(maSoTextBox.Text);
                    string hoTen = hoTenTextBox.Text;
                    DateTime ngaySinh = ngaySinhDateTimePicker.Value;
                    bool gioiTinh = gioiTinhCheckBox.Checked;
                    string diaChi = diaChiTextBox.Text;
                    int dienThoai = int.Parse(dienThoaiTextBox.Text);
                    string maKhoa = maKhoaTextBox.Text;

                    command.Parameters.AddWithValue("@MaSo", maSo);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@DienThoai", dienThoai);
                    command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sinh viên đã được thêm vào SQL Server thành công.");
                            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
                        }
                        else
                        {
                            MessageBox.Show("Không có sinh viên nào được thêm vào SQL Server.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm sinh viên vào SQL Server: " + ex.Message);
                    }
                }
            }
        }

        private void deleteSVbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int maSo = int.Parse(maSoTextBox.Text);
                XoaSinhVien(maSo);
            }
        }
        private void XoaSinhVien(int maSo)
        {
            string strCon = "Data Source=AN;Initial Catalog=QLSV;User ID=qlcf;Password=1234";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                string query = "DELETE FROM SinhVien WHERE MaSo = @MaSo";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@MaSo", maSo);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sinh viên đã được xóa khỏi SQL Server thành công.");
                        this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên có mã số " + maSo + " trong SQL Server.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên khỏi SQL Server: " + ex.Message);
                }
            }
        }

        private void CapNhatSinhVien(int maSo, string hoTen, DateTime ngaySinh, bool gioiTinh, string diaChi, int dienThoai, string maKhoa)
        {
            
            string strCon = "Data Source=AN;Initial Catalog=QLSV;User ID=qlcf;Password=1234";
            
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                string query = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai, MaKhoa = @MaKhoa WHERE MaSo = @MaSo";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@MaSo", maSo);
                command.Parameters.AddWithValue("@HoTen", hoTen);
                command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@DienThoai", dienThoai);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin sinh viên đã được cập nhật trong SQL Server thành công.");
                        this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên có mã số " + maSo + " trong SQL Server.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin sinh viên trong SQL Server: " + ex.Message);
                }
            }
        }

        private void editSVbtn_Click(object sender, EventArgs e)
        {
            int maSo = int.Parse(maSoTextBox.Text);
            string hoTen = hoTenTextBox.Text;
            DateTime ngaySinh = ngaySinhDateTimePicker.Value;
            bool gioiTinh = gioiTinhCheckBox.Checked;
            string diaChi = diaChiTextBox.Text;
            int dienThoai = int.Parse(dienThoaiTextBox.Text);
            string maKhoa = maKhoaTextBox.Text;

            if (checkInfor())
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin sinh viên này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CapNhatSinhVien(maSo, hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, maKhoa);
                }
            }
        }
        private int MaSoLonNhat()
        {
            int maSoLonNhat = 0;
            foreach (DataGridViewRow row in sinhVienDataGridView.Rows)
            {
                if (row.Cells["MaSo"].Value != null)
                {
                    int maSo = (int)row.Cells["MaSo"].Value;
                    if (maSo > maSoLonNhat)
                    {
                        maSoLonNhat = maSo;
                    }
                }
            }
            return maSoLonNhat;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);
            maSoTextBox.Text = (MaSoLonNhat()+1).ToString();
            hoTenTextBox.Text = "";
            gioiTinhCheckBox.Checked = false;
            diaChiTextBox.Text = ""; ;
            dienThoaiTextBox.Text = "";
            maKhoaTextBox.Text = "";
        }

    }
}
    
