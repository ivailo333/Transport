using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Transport
{
    public partial class MPS : Form
    {
        public MPS()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String vid, reg_number, marka, model, vin_number, dvg_number;
            decimal neto, tovaropodemnost, vmestimost_gorivo;
            String Neto, Tovaropodemnost, Vmestimost_Gorivo;
            int osi;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO МПС values (@Vid, @Reg_number, @Marka, @Model, @Neto, @Tovaropodemnost, @VIN_number, @DVG_number, @Osi, @Vmestimost_rezervoar)";

            vid = txtVid.Text;
            vid = vid.Trim();
            reg_number = txtReg_number.Text;
            reg_number = reg_number.Trim();
            marka = txtMarka.Text;
            marka = marka.Trim();
            model = txtModel.Text;
            model = model.Trim();
            vin_number = txtVIN_number.Text;
            vin_number = vin_number.Trim();
            dvg_number = txtDVG_number.Text;
            dvg_number = dvg_number.Trim();

            if (txtNeto.Text == "")
            {
                neto = 0;
            }
            else
            {
                Neto = txtNeto.Text;
                Neto = Neto.Replace(",", ".");
                neto = decimal.Parse(Neto, new CultureInfo("en-US"));
            }

            if (txtTovaropodemnost.Text == "")
            {
                tovaropodemnost = 0;
            }
            else
            {
                Tovaropodemnost = txtTovaropodemnost.Text;
                Tovaropodemnost = Tovaropodemnost.Replace(",", ".");
                tovaropodemnost = decimal.Parse(Tovaropodemnost, new CultureInfo("en-US"));
            }

            if (txtVolume.Text == "")
            {
                vmestimost_gorivo = 0;
            }
            else
            {
                Vmestimost_Gorivo = txtVolume.Text;
                Vmestimost_Gorivo = Vmestimost_Gorivo.Replace(",", ".");
                vmestimost_gorivo = decimal.Parse(Vmestimost_Gorivo, new CultureInfo("en-US"));
            }

            if (txtOsi.Text == "")
            {
                osi = 1;
            }
            else
            {
                osi = int.Parse(txtOsi.Text);
            }
 
            cmd.Parameters.AddWithValue("@Vid", vid);
            cmd.Parameters.AddWithValue("@Reg_number", reg_number);
            cmd.Parameters.AddWithValue("@Marka", marka);
            cmd.Parameters.AddWithValue("@Model", model);
            cmd.Parameters.AddWithValue("@Neto", neto);
            cmd.Parameters.AddWithValue("@Tovaropodemnost", tovaropodemnost);
            cmd.Parameters.AddWithValue("@VIN_number", vin_number);
            cmd.Parameters.AddWithValue("@DVG_number", dvg_number);
            cmd.Parameters.AddWithValue("@Osi", osi);
            cmd.Parameters.AddWithValue("@Vmestimost_rezervoar", vmestimost_gorivo);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                txtVid.Text = null;
                txtReg_number.Text = null;
                txtMarka.Text = null;
                txtModel.Text = null;
                txtNeto.Text = null;
                txtTovaropodemnost.Text = null;
                txtVIN_number.Text = null;
                txtDVG_number.Text = null;
                txtOsi.Text = null;
                txtVolume.Text = null;
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

        private void MPS_Load(object sender, EventArgs e)
        {
            txtVid.Text = null;
            txtReg_number.Text = null;
            txtMarka.Text = null;
            txtModel.Text = null;
            txtNeto.Text = null;
            txtTovaropodemnost.Text = null;
            txtVIN_number.Text = null;
            txtDVG_number.Text = null;
            txtOsi.Text = null;
            txtVolume.Text = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String vid, reg_number, marka, model, vin_number, dvg_number;
            decimal neto, tovaropodemnost, vmestimost_gorivo;
            String Neto, Tovaropodemnost, Vmestimost_Gorivo;
            int osi;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE МПС SET Вид=@Vid, Марка=@Marka, Нето=@Neto, Товароподемност=@Tovaropodemnost, ВИН_номер=@VIN_number, ДВГ_номер=@DVG_number, Оси=@Osi, Вместимост_резервоар=@Vmestimost_rezervoar WHERE Рег_номер=@Reg_number";

            vid = txtVid.Text;
            vid = vid.Trim();
            reg_number = txtReg_number.Text;
            reg_number = reg_number.Trim();
            marka = txtMarka.Text;
            marka = marka.Trim();
            model = txtModel.Text;
            model = model.Trim();
            vin_number = txtVIN_number.Text;
            vin_number = vin_number.Trim();
            dvg_number = txtDVG_number.Text;
            dvg_number = dvg_number.Trim();
            Neto = txtNeto.Text;
            Neto = Neto.Replace(",", ".");
            neto = decimal.Parse(Neto, new CultureInfo("en-US"));
            Tovaropodemnost = txtTovaropodemnost.Text;
            Tovaropodemnost = Tovaropodemnost.Replace(",", ".");
            tovaropodemnost = decimal.Parse(Tovaropodemnost, new CultureInfo("en-US"));
            Vmestimost_Gorivo = txtVolume.Text;
            Vmestimost_Gorivo = Vmestimost_Gorivo.Replace(",", ".");
            vmestimost_gorivo = decimal.Parse(Vmestimost_Gorivo, new CultureInfo("en-US"));
            osi = int.Parse(txtOsi.Text);

            cmd.Parameters.AddWithValue("@Vid", vid);
            cmd.Parameters.AddWithValue("@Reg_number", reg_number);
            cmd.Parameters.AddWithValue("@Marka", marka);
            cmd.Parameters.AddWithValue("@Model", model);
            cmd.Parameters.AddWithValue("@Neto", neto);
            cmd.Parameters.AddWithValue("@Tovaropodemnost", tovaropodemnost);
            cmd.Parameters.AddWithValue("@VIN_number", vin_number);
            cmd.Parameters.AddWithValue("@DVG_number", dvg_number);
            cmd.Parameters.AddWithValue("@Osi", osi); ;
            cmd.Parameters.AddWithValue("@Vmestimost_rezervoar", vmestimost_gorivo);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са обновени успешно!!!");
                txtVid.Text = null;
                txtReg_number.Text = null;
                txtMarka.Text = null;
                txtModel.Text = null;
                txtNeto.Text = null;
                txtTovaropodemnost.Text = null;
                txtVIN_number.Text = null;
                txtDVG_number.Text = null;
                txtOsi.Text = null;
                txtVolume.Text = null;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря, защото се опитвате да обновите несъщестуващи данни!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String reg_number;
            reg_number = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM МПС WHERE Рег_номер=@Reg_number";
            reg_number = txtReg_number.Text;
            reg_number = reg_number.Trim();
            cmd.Parameters.AddWithValue("@Reg_number", reg_number);
            if (reg_number != null)
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                txtVid.Text = sdr["Вид"].ToString();
                txtReg_number.Text = sdr["Рег_номер"].ToString();
                txtMarka.Text = sdr["Марка"].ToString();
                txtModel.Text = sdr["Модел"].ToString();
                txtNeto.Text = sdr["Нето"].ToString();
                txtTovaropodemnost.Text = sdr["Товароподемност"].ToString();
                txtVIN_number.Text = sdr["ВИН_номер"].ToString();
                txtDVG_number.Text = sdr["ДВГ_номер"].ToString();
                txtOsi.Text = sdr["Оси"].ToString();
                txtVolume.Text = sdr["Вместимост_резервоар"].ToString();
                conn.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String reg_number;
            reg_number = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM МПС WHERE Рег_номер=@Reg_number";

            reg_number = txtReg_number.Text;
            reg_number = reg_number.Trim();
            cmd.Parameters.AddWithValue("@Reg_number", reg_number);

            DialogResult deleteDb = MessageBox.Show("Искате ли да изтриете тези данни?", "Изтриване", MessageBoxButtons.YesNo);

            if(deleteDb==DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данните са изтрити успешно!!!");
                    txtVid.Text = null;
                    txtReg_number.Text = null;
                    txtMarka.Text = null;
                    txtModel.Text = null;
                    txtNeto.Text = null;
                    txtTovaropodemnost.Text = null;
                    txtVIN_number.Text = null;
                    txtDVG_number.Text = null;
                    txtOsi.Text = null;
                    txtVolume.Text = null;
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
