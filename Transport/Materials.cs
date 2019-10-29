using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport
{
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String vid, merna_edinitsa, proizhod;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Материал values (@Vid, @Merna_edinitsa, @Proizhod)";

            vid = txtVid.Text;
            vid = vid.Trim();
            if(cmbMerna_edinitsa.SelectedIndex!=-1)
            {
                merna_edinitsa = cmbMerna_edinitsa.SelectedItem.ToString();
                merna_edinitsa = merna_edinitsa.Trim();
            }
            else
            {
                merna_edinitsa = "";
            }
            proizhod = txtProizhod.Text;
            proizhod = proizhod.Trim();

            cmd.Parameters.AddWithValue("@Vid", vid);
            cmd.Parameters.AddWithValue("@Merna_edinitsa", merna_edinitsa);
            cmd.Parameters.AddWithValue("@Proizhod", proizhod);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                txtVid.Text = null;
                cmbMerna_edinitsa.SelectedIndex = -1;
                txtProizhod.Text = null;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря, защото въведените данни съществуват в нея!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            txtVid.Text = null;
            cmbMerna_edinitsa.SelectedIndex = -1;
            txtProizhod.Text = null;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String vid, merna_edinitsa;
            vid = null;
            merna_edinitsa = null;
            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Материал WHERE Вид=@Vid";
            vid = txtVid.Text;
            vid = vid.Trim();
            cmd.Parameters.AddWithValue("@Vid", vid);
            cmbMerna_edinitsa.SelectedIndex = -1;
            if (vid != "")
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                vid = sdr["Вид"].ToString();
                vid = vid.Trim();
                merna_edinitsa = sdr["Мерна_единица"].ToString();
                merna_edinitsa = merna_edinitsa.Trim();
                cmbMerna_edinitsa.SelectedText = merna_edinitsa;
                txtProizhod.Text = sdr["Произход"].ToString();
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String vid, merna_edinitsa, proizhod;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Материал SET Мерна_единица=@Merna_edinitsa, Произход=@Proizhod WHERE Вид=@Vid";

            vid = txtVid.Text;
            vid = vid.Trim();
            if (cmbMerna_edinitsa.SelectedIndex != -1)
            {
                merna_edinitsa = cmbMerna_edinitsa.SelectedItem.ToString();
                merna_edinitsa = merna_edinitsa.Trim();
            }
            else
            {
                merna_edinitsa = "";
            }
            proizhod = txtProizhod.Text;
            proizhod = proizhod.Trim();

            cmd.Parameters.AddWithValue("@Vid", vid);
            cmd.Parameters.AddWithValue("@Merna_edinitsa", merna_edinitsa);
            cmd.Parameters.AddWithValue("@Proizhod", proizhod);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са обновени успешно!!!");
                txtVid.Text = null;
                cmbMerna_edinitsa.SelectedIndex = -1;
                txtProizhod.Text = null;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря, защото се опитвате да обновите несъщестуващи данни!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String vid;
            vid = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Материал WHERE Вид=@Vid";

            vid = txtVid.Text;
            cmd.Parameters.AddWithValue("@Vid", vid);

            DialogResult deleteDb = MessageBox.Show("Искате ли да изтриете тези данни?", "Изтриване", MessageBoxButtons.YesNo);

            if(deleteDb==DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данните са изтрити успешно!!!");
                    txtVid.Text = null;
                    cmbMerna_edinitsa.SelectedIndex = -1;
                    txtProizhod.Text = null;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Базата данни не се отваря, защото се опитвате да изтриете несъщестуващи данни!");
                }
            }
            else if(deleteDb==DialogResult.No)
            {

            }
        }
    }
}
