using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String fullname, categorii;
            bool kompetentnost, udostoverenie;
            categorii = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString ="Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Transport; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Шофьор values (@Full_name, @Kategorii, @Profesionalna_kompetentnost, @Udostoverenie)";

            fullname = txtName.Text;
            fullname = fullname.Trim();
            if(lsbCategorii.SelectedIndex!=-1)
            {
                foreach (var item in lsbCategorii.SelectedItems)
                {
                    categorii += item.ToString() + " ";
                }
            }
            else
            {
                categorii = "";
            }
            kompetentnost = chbProfessional_competence.Checked;
            udostoverenie = chbUdostoverenie.Checked;

            cmd.Parameters.AddWithValue("@Full_name", fullname);
            cmd.Parameters.AddWithValue("@Kategorii", categorii);
            cmd.Parameters.AddWithValue("@Profesionalna_kompetentnost", kompetentnost);
            cmd.Parameters.AddWithValue("@Udostoverenie", udostoverenie);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                txtName.Text = null;
                lsbCategorii.SelectedIndex = -1;
                chbProfessional_competence.Checked = false;
                chbUdostoverenie.Checked = false;
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

        private void Drivers_Load(object sender, EventArgs e)
        {
            txtName.Text = null;
            lsbCategorii.SelectedIndex = -1;
            chbProfessional_competence.Checked = false;
            chbUdostoverenie.Checked = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String fullname, categorii;
            bool kompetentnost, udostoverenie;
            categorii = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Transport; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Шофьор WHERE Пълно_име=@Full_name";

            fullname = txtName.Text;
            fullname = fullname.Trim();
            cmd.Parameters.AddWithValue("@Full_name", fullname);
            if(fullname!="")
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                fullname = sdr["Пълно_име"].ToString();
                fullname = fullname.Trim();

                categorii = sdr["Категории"].ToString();

                String[] cat = categorii.Split(' ');
                foreach(String item in cat)
                {
                    if(item!="")
                    {
                        lsbCategorii.SelectedItem = item;
                    }
                }
                kompetentnost = bool.Parse(sdr["Професионална_компетентност"].ToString());
                chbProfessional_competence.Checked = kompetentnost;
                udostoverenie = bool.Parse(sdr["Удостоверение"].ToString());
                chbUdostoverenie.Checked = udostoverenie;
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String fullname, categorii;
            bool kompetentnost, udostoverenie;
            categorii = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Transport; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Шофьор SET Категории=@Kategorii, Професионална_компетентност=@Profesionalna_kompetentnost, Удостоверение=@Udostoverenie WHERE Пълно_име=@Full_name";

            fullname = txtName.Text;
            if (lsbCategorii.SelectedIndex != -1)
            {
                foreach (var item in lsbCategorii.SelectedItems)
                {
                    categorii += item.ToString() + " ";
                }
            }
            else
            {
                categorii = "";
            }
            kompetentnost = chbProfessional_competence.Checked;
            udostoverenie = chbUdostoverenie.Checked;

            cmd.Parameters.AddWithValue("@Full_name", fullname);
            cmd.Parameters.AddWithValue("@Kategorii", categorii);
            cmd.Parameters.AddWithValue("@Profesionalna_kompetentnost", kompetentnost);
            cmd.Parameters.AddWithValue("@Udostoverenie", udostoverenie);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са обновени успешно!!!");
                txtName.Text = null;
                lsbCategorii.SelectedIndex = -1;
                chbProfessional_competence.Checked = false;
                chbUdostoverenie.Checked = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря, защото се опитвате да обновите несъщестуващи данни!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String fullname;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Transport; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Шофьор WHERE Пълно_име=@Full_name";

            fullname = txtName.Text;
            cmd.Parameters.AddWithValue("@Full_name", fullname);
            DialogResult deleteDb = MessageBox.Show("Искате ли да изтриете тези данни?", "Изтриване", MessageBoxButtons.YesNo);

            if (deleteDb == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данните са изтрити успешно!!!");
                    txtName.Text = null;
                    lsbCategorii.SelectedIndex = -1;
                    chbProfessional_competence.Checked = false;
                    chbUdostoverenie.Checked = false;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Базата данни не се отваря, защото се опитвате да изтриете несъщестуващи данни!");
                }
            }
            else if (deleteDb == DialogResult.No)
            {

            }
        }
    }
}
