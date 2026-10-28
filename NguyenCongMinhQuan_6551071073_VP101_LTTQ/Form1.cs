using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NguyenCongMinhQuan_6551071073_VP101_LTTQ
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string connStr =
            @"Data Source=.\SQL123;Initial Catalog=DuLieu;Integrated Security=True;TrustServerCertificate=True";
        private string selectedMaCV = "";

        public Form1()
        {
            InitializeComponent();
        }

        // 1.
        private void Form1_Load(object sender, EventArgs e)
        {
            InitDatabaseConnection();

            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            LoadData();
            ClearInputs();
        }

        private void InitDatabaseConnection()
        {
            string[] servers = new string[] { @".\SQL123", ".", "localhost", @".\SQLEXPRESS", @"(localdb)\MSSQLLocalDB" };
            string foundServer = null;

            foreach (string s in servers)
            {
                try
                {
                    using (SqlConnection c = new SqlConnection(string.Format("Data Source={0};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=2", s)))
                    {
                        c.Open();
                        foundServer = s;
                        break;
                    }
                }
                catch
                {
                }
            }

            if (foundServer != null)
            {
                connStr = string.Format("Data Source={0};Initial Catalog=DuLieu;Integrated Security=True;TrustServerCertificate=True", foundServer);

                try
                {
                    using (SqlConnection cMaster = new SqlConnection(string.Format("Data Source={0};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True", foundServer)))
                    {
                        cMaster.Open();
                        string createDbSql = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DuLieu') CREATE DATABASE DuLieu;";
                        using (SqlCommand cmd = new SqlCommand(createDbSql, cMaster))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    using (SqlConnection cDb = new SqlConnection(connStr))
                    {
                        cDb.Open();
                        string createTableSql = @"
                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'CongViec')
                            BEGIN
                                CREATE TABLE CongViec (
                                    MaCongViec NVARCHAR(10) NOT NULL PRIMARY KEY,
                                    TenCongViec NTEXT NOT NULL,
                                    LuongThang NVARCHAR(8) NOT NULL
                                );
                                INSERT INTO CongViec (MaCongViec, TenCongViec, LuongThang) VALUES 
                                (N'cv1', N'Bán hàng', N'5000000'),
                                (N'cv2', N'Vệ sinh', N'2500000');
                            END";
                        using (SqlCommand cmd = new SqlCommand(createTableSql, cDb))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT MaCongViec, TenCongViec, LuongThang FROM CongViec";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCongViec.DataSource = dt;

                        if (dgvCongViec.Columns["MaCongViec"] != null)
                            dgvCongViec.Columns["MaCongViec"].HeaderText = "Mã công việc";
                        if (dgvCongViec.Columns["TenCongViec"] != null)
                            dgvCongViec.Columns["TenCongViec"].HeaderText = "Tên công việc";
                        if (dgvCongViec.Columns["LuongThang"] != null)
                            dgvCongViec.Columns["LuongThang"].HeaderText = "Lương tháng";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\nChuỗi kết nối: " + connStr + "\nHãy kiểm tra xem SQL Server đã được Start chưa!");
            }
            finally
            {
                dgvCongViec.ClearSelection();
            }
        }

        private void ClearInputs()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtLuongThang.Clear();
            selectedMaCV = "";
            dgvCongViec.ClearSelection();
        }

        // 2.
        private void txtLuongThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 3.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn thoát không",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // 4.
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text) ||
                string.IsNullOrWhiteSpace(txtTenCV.Text) ||
                string.IsNullOrWhiteSpace(txtLuongThang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            string maCV = txtMaCV.Text.Trim();
            string tenCV = txtTenCV.Text.Trim();
            string luongThang = txtLuongThang.Text.Trim();

            if (KiemTraTrungMa(maCV))
            {
                MessageBox.Show("Mã công việc đã tồn tại, vui lòng nhập lại!");
                txtMaCV.Focus();
                txtMaCV.SelectAll();
                return;
            }

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string insertSql = "INSERT INTO CongViec (MaCongViec, TenCongViec, LuongThang) VALUES (@Ma, @Ten, @Luong)";
                    using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 10).Value = maCV;
                        cmd.Parameters.Add("@Ten", SqlDbType.NText).Value = tenCV;
                        cmd.Parameters.Add("@Luong", SqlDbType.NVarChar, 8).Value = luongThang;
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
                ClearInputs();
                btnThem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private bool KiemTraTrungMa(string maCV)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM CongViec WHERE MaCongViec = @Ma";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 10).Value = maCV;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // 5.
        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCongViec.Rows.Count)
            {
                DataGridViewRow row = dgvCongViec.Rows[e.RowIndex];
                if (row != null && row.Cells["MaCongViec"].Value != null)
                {
                    selectedMaCV = row.Cells["MaCongViec"].Value.ToString().Trim();
                    txtMaCV.Text = selectedMaCV;
                    txtTenCV.Text = row.Cells["TenCongViec"].Value != null ? row.Cells["TenCongViec"].Value.ToString() : "";
                    txtLuongThang.Text = row.Cells["LuongThang"].Value != null ? row.Cells["LuongThang"].Value.ToString() : "";

                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                }
            }
        }

        // 6.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text.Trim();
            if (string.IsNullOrEmpty(maCV) && !string.IsNullOrEmpty(selectedMaCV))
            {
                maCV = selectedMaCV;
            }

            if (string.IsNullOrEmpty(maCV))
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Bạn có muốn xóa công việc này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = GetConnection())
                    {
                        conn.Open();
                        string deleteSql = "DELETE FROM CongViec WHERE MaCongViec = @Ma";
                        using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                        {
                            cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 10).Value = maCV;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            ClearInputs();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        // 7.
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text) ||
                string.IsNullOrWhiteSpace(txtTenCV.Text) ||
                string.IsNullOrWhiteSpace(txtLuongThang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            string maMoi = txtMaCV.Text.Trim();
            string tenMoi = txtTenCV.Text.Trim();
            string luongMoi = txtLuongThang.Text.Trim();
            string maGoc = string.IsNullOrEmpty(selectedMaCV) ? maMoi : selectedMaCV;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string updateSql = "UPDATE CongViec SET MaCongViec = @MaMoi, TenCongViec = @Ten, LuongThang = @Luong WHERE MaCongViec = @MaGoc";
                    using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                    {
                        cmd.Parameters.Add("@MaMoi", SqlDbType.NVarChar, 10).Value = maMoi;
                        cmd.Parameters.Add("@Ten", SqlDbType.NText).Value = tenMoi;
                        cmd.Parameters.Add("@Luong", SqlDbType.NVarChar, 8).Value = luongMoi;
                        cmd.Parameters.Add("@MaGoc", SqlDbType.NVarChar, 10).Value = maGoc;
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                ClearInputs();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        private void txtInputs_TextChanged(object sender, EventArgs e)
        {
            if (!btnThem.Enabled && !btnSua.Enabled)
            {
                btnThem.Enabled = true;
            }
        }
    }
}