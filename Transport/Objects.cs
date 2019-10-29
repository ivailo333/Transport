using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport
{
    public partial class Objects : Form
    {
        public Objects()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String naimenovanie, firma, bulstat, mol, address, phone, email;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Обект values (@Naimenovanie, @Firma, @BULSTAT, @MOL, @Address, @Telephone, @Email)";

            naimenovanie = txtNaimenovanie.Text;
            naimenovanie = naimenovanie.Trim();
            firma = txtFirma.Text;
            firma = firma.Trim();
            bulstat = txtBulstat.Text;
            bulstat = bulstat.Trim();
            mol = txtMOL.Text;
            address = txtAddress.Text;
            address = address.Trim();
            phone = txtPhone.Text;
            phone = phone.Trim();
            email = txtEmail.Text;
            email = email.Trim();

            cmd.Parameters.AddWithValue("@Naimenovanie", naimenovanie);
            cmd.Parameters.AddWithValue("@Firma", firma);
            cmd.Parameters.AddWithValue("@BULSTAT", bulstat);
            cmd.Parameters.AddWithValue("@MOL", mol);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Telephone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                txtNaimenovanie.Text = null;
                txtFirma.Text = null;
                txtBulstat.Text = null;
                txtMOL.Text = null;
                txtAddress.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
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

        private void Objects_Load(object sender, EventArgs e)
        {
            txtNaimenovanie.Text = null;
            txtFirma.Text = null;
            txtBulstat.Text = null;
            txtMOL.Text = null;
            txtAddress.Text = null;
            txtPhone.Text = null;
            txtEmail.Text = null;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String naimenovanie;
            naimenovanie = null;
            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Обект WHERE Наименование=@Naimenovanie";
            naimenovanie = txtNaimenovanie.Text;
            cmd.Parameters.AddWithValue("@Naimenovanie", naimenovanie);
            if (naimenovanie != null)
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                txtNaimenovanie.Text = sdr["Наименование"].ToString();
                txtFirma.Text = sdr["Фирма"].ToString();
                txtBulstat.Text = sdr["БУЛСТАТ"].ToString();
                txtMOL.Text = sdr["МОЛ"].ToString();
                txtAddress.Text = sdr["Адрес"].ToString();
                txtPhone.Text = sdr["Телефон"].ToString();
                txtEmail.Text = sdr["Имейл"].ToString();
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String naimenovanie, firma, bulstat, mol, address, phone, email;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Обект SET Фирма=@Firma, БУЛСТАТ=@BULSTAT, МОЛ=@MOL, Адрес=@Address, Телефон=@Telephone, Имейл=@Email WHERE Наименование=@Naimenovanie";

            naimenovanie = txtNaimenovanie.Text;
            naimenovanie = naimenovanie.Trim();
            firma = txtFirma.Text;
            firma = firma.Trim();
            bulstat = txtBulstat.Text;
            bulstat = bulstat.Trim();
            mol = txtMOL.Text;
            mol = mol.Trim();
            address = txtAddress.Text;
            address = address.Trim();
            phone = txtPhone.Text;
            phone = phone.Trim();
            email = txtEmail.Text;
            email = email.Trim();

            cmd.Parameters.AddWithValue("@Naimenovanie", naimenovanie);
            cmd.Parameters.AddWithValue("@Firma", firma);
            cmd.Parameters.AddWithValue("@BULSTAT", bulstat);
            cmd.Parameters.AddWithValue("@MOL", mol);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Telephone", phone);
            cmd.Parameters.AddWithValue("@Email", email);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са обновени успешно!!!");
                txtNaimenovanie.Text = null;
                txtFirma.Text = null;
                txtBulstat.Text = null;
                txtMOL.Text = null;
                txtAddress.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря, защото се опитвате да обновите несъщестуващи данни!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String naimenovanie;
            naimenovanie = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Обект WHERE Наименование=@Naimenovanie";

            naimenovanie = txtNaimenovanie.Text;
            cmd.Parameters.AddWithValue("@Naimenovanie", naimenovanie);

            DialogResult deleteDb = MessageBox.Show("Искате ли да изтриете тези данни?", "Изтриване", MessageBoxButtons.YesNo);

            if(deleteDb==DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данните са изтрити успешно!!!");
                    txtNaimenovanie.Text = null;
                    txtFirma.Text = null;
                    txtBulstat.Text = null;
                    txtMOL.Text = null;
                    txtAddress.Text = null;
                    txtPhone.Text = null;
                    txtEmail.Text = null;
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
