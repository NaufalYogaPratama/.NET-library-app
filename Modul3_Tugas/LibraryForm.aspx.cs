using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Tugas_Modul3
{
    public partial class LibraryForm : System.Web.UI.Page
    {
        string connectionString = "Data Source=LAPTOP-R9HQTSI4\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            if (!IsPostBack)
            {
                DataShow();
            }
        }

        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM vw_LibraryData"; // Menggunakan view untuk menampilkan data gabungan
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            gvLibrary.DataSource = ds;
            gvLibrary.DataBind();
            con.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Insert into Mahasiswa if not exists
                string queryMahasiswa = "IF NOT EXISTS (SELECT 1 FROM Mahasiswa WHERE NIM = @NIM) " +
                                        "INSERT INTO Mahasiswa (NIM, NamaLengkap, Jurusan, TanggalLahir) " +
                                        "VALUES (@NIM, @NamaLengkap, @Jurusan, @TanggalLahir)";
                SqlCommand cmdMahasiswa = new SqlCommand(queryMahasiswa, con);
                cmdMahasiswa.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmdMahasiswa.Parameters.AddWithValue("@NamaLengkap", txtNama.Text);
                cmdMahasiswa.Parameters.AddWithValue("@Jurusan", txtJurusan.Text);
                cmdMahasiswa.Parameters.AddWithValue("@TanggalLahir", txtTanggalLahir.Text);
                cmdMahasiswa.ExecuteNonQuery();

                // Insert into Buku
                string queryBuku = "INSERT INTO Buku (Judul, Pengarang, TanggalPinjam, NIM) " +
                                   "VALUES (@Judul, @Pengarang, @TanggalPinjam, @NIM)";
                SqlCommand cmdBuku = new SqlCommand(queryBuku, con);
                cmdBuku.Parameters.AddWithValue("@Judul", txtJudul.Text);
                cmdBuku.Parameters.AddWithValue("@Pengarang", txtPengarang.Text);
                cmdBuku.Parameters.AddWithValue("@TanggalPinjam", txtTanggalPinjam.Text);
                cmdBuku.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmdBuku.ExecuteNonQuery();

                DataShow();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Delete from Buku based on NIM and Judul
                string query = "DELETE FROM Buku WHERE NIM = @NIM AND Judul = @Judul";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmd.Parameters.AddWithValue("@Judul", txtJudul.Text);
                cmd.ExecuteNonQuery();

                DataShow();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Update Mahasiswa
                string queryMahasiswa = "UPDATE Mahasiswa SET NamaLengkap = @NamaLengkap, Jurusan = @Jurusan, " +
                                        "TanggalLahir = @TanggalLahir WHERE NIM = @NIM";
                SqlCommand cmdMahasiswa = new SqlCommand(queryMahasiswa, con);
                cmdMahasiswa.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmdMahasiswa.Parameters.AddWithValue("@NamaLengkap", txtNama.Text);
                cmdMahasiswa.Parameters.AddWithValue("@Jurusan", txtJurusan.Text);
                cmdMahasiswa.Parameters.AddWithValue("@TanggalLahir", txtTanggalLahir.Text);
                cmdMahasiswa.ExecuteNonQuery();

                // Update Buku
                string queryBuku = "UPDATE Buku SET Pengarang = @Pengarang, TanggalPinjam = @TanggalPinjam " +
                                   "WHERE NIM = @NIM AND Judul = @Judul";
                SqlCommand cmdBuku = new SqlCommand(queryBuku, con);
                cmdBuku.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmdBuku.Parameters.AddWithValue("@Judul", txtJudul.Text);
                cmdBuku.Parameters.AddWithValue("@Pengarang", txtPengarang.Text);
                cmdBuku.Parameters.AddWithValue("@TanggalPinjam", txtTanggalPinjam.Text);
                cmdBuku.ExecuteNonQuery();

                DataShow();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtNIM.Text = null;
            txtNama.Text = null;
            txtJurusan.Text = null;
            txtTanggalLahir.Text = null;
            txtJudul.Text = null;
            txtPengarang.Text = null;
            txtTanggalPinjam.Text = null;
        }
    }
}