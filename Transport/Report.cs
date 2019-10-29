using NCalc;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Transport
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, System.EventArgs e)
        {
            cmbMPS.SelectedIndex = -1;
            txtBegin.Text = null;
            txtEnd.Text = null;
            txtHoursWorked.Text = null;
            cmbDriver.SelectedIndex = -1;
            txtNumber_p_list.Text = null;
            txtNumber_tovar.Text = null;
            cmbObjectBegin.SelectedIndex = -1;
            cmbObjectEnd.SelectedIndex = -1;
            cmbMaterial1.SelectedIndex = -1;
            cmbMaterial2.SelectedIndex = -1;
            cmbMaterial3.SelectedIndex = -1;
            cmbMaterial4.SelectedIndex = -1;
            txtKolichestvo1.Text = null;
            txtKolichestvo2.Text = null;
            txtKolichestvo3.Text = null;
            txtKolichestvo4.Text = null;
            cmbMerna_edinitsa1.SelectedIndex = -1;
            cmbMerna_edinitsa2.SelectedIndex = -1;
            cmbMerna_edinitsa3.SelectedIndex = -1;
            cmbMerna_edinitsa4.SelectedIndex = -1;
            txtGorivo.Text = null;
            grdOtcheti.DataSource = null;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            SqlCommand cmd3 = new SqlCommand();
            SqlCommand cmd31 = new SqlCommand();
            SqlCommand cmd41 = new SqlCommand();
            SqlCommand cmd42 = new SqlCommand();
            SqlCommand cmd43 = new SqlCommand();
            SqlCommand cmd44 = new SqlCommand();
            cmd1.Connection = conn;
            cmd2.Connection = conn;
            cmd3.Connection = conn;
            cmd31.Connection = conn;
            cmd41.Connection = conn;
            cmd42.Connection = conn;
            cmd43.Connection = conn;
            cmd44.Connection = conn;
            cmd1.CommandText = "SELECT ИД, Рег_номер FROM МПС";
            cmd2.CommandText = "SELECT ИД, Пълно_име FROM Шофьор";
            cmd3.CommandText = "SELECT ИД, Наименование from Обект";
            cmd31.CommandText = "SELECT ИД, Наименование from Обект";
            cmd41.CommandText = "SELECT ИД, Вид FROM Материал";
            cmd42.CommandText = "SELECT ИД, Вид FROM Материал";
            cmd43.CommandText = "SELECT ИД, Вид FROM Материал";
            cmd44.CommandText = "SELECT ИД, Вид FROM Материал";

            SqlDataReader reader1, reader2, reader3, reader31, reader41, reader42, reader43, reader44;
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt31 = new DataTable();
            DataTable dt41 = new DataTable();
            DataTable dt42 = new DataTable();
            DataTable dt43 = new DataTable();
            DataTable dt44 = new DataTable();

            conn.Open();
            reader1 = cmd1.ExecuteReader();
            dt1.Columns.Add("Рег_номер", typeof(string));
            dt1.Load(reader1);
            cmbMPS.ValueMember = dt1.Columns[1].ToString();
            cmbMPS.DisplayMember = dt1.Columns[0].ToString();
            cmbMPS.DataSource = dt1;
            cmbMPS.SelectedIndex = -1;
            conn.Close();

            conn.Open();
            reader2 = cmd2.ExecuteReader();
            dt2.Columns.Add("Пълно_име", typeof(string));
            dt2.Load(reader2);
            cmbDriver.ValueMember = dt2.Columns[1].ToString();
            cmbDriver.DisplayMember = dt2.Columns[0].ToString();
            cmbDriver.DataSource = dt2;
            cmbDriver.SelectedIndex = -1;
            conn.Close();


            conn.Open();
            reader3 = cmd3.ExecuteReader();
            dt3.Columns.Add("Наименование", typeof(string));
            dt3.Load(reader3);
            cmbObjectBegin.ValueMember = dt3.Columns[1].ToString();
            cmbObjectBegin.DisplayMember = dt3.Columns[0].ToString();
            cmbObjectBegin.DataSource = dt3;
            cmbObjectBegin.SelectedIndex = -1;
            conn.Close();

            conn.Open();
            reader31 = cmd31.ExecuteReader();
            dt31.Columns.Add("Наименование", typeof(string));
            dt31.Load(reader31);
            cmbObjectEnd.ValueMember = dt31.Columns[1].ToString();
            cmbObjectEnd.DisplayMember = dt31.Columns[0].ToString();
            cmbObjectEnd.DataSource = dt31;
            cmbObjectEnd.SelectedIndex = -1;
            conn.Close();

            conn.Open();
            reader41 = cmd41.ExecuteReader();
            dt41.Columns.Add("Вид", typeof(string));
            dt41.Load(reader41);
            cmbMaterial1.ValueMember = dt41.Columns[1].ToString();
            cmbMaterial1.DisplayMember = dt41.Columns[0].ToString();
            cmbMaterial1.DataSource = dt41;
            cmbMaterial1.SelectedIndex = -1;
            conn.Close();

            conn.Open();
            reader42 = cmd42.ExecuteReader();
            dt42.Columns.Add("Вид", typeof(string));
            dt42.Load(reader42);
            cmbMaterial2.ValueMember = dt42.Columns[1].ToString();
            cmbMaterial2.DisplayMember = dt42.Columns[0].ToString();
            cmbMaterial2.DataSource = dt42;
            cmbMaterial2.SelectedIndex = -1;
            conn.Close();

            conn.Open();
            reader43 = cmd43.ExecuteReader();
            dt43.Columns.Add("Вид", typeof(string));
            dt43.Load(reader43);
            cmbMaterial3.ValueMember = dt43.Columns[1].ToString();
            cmbMaterial3.DisplayMember = dt43.Columns[0].ToString();
            cmbMaterial3.DataSource = dt43;
            cmbMaterial3.SelectedIndex = -1;
            conn.Close();

            conn.Open();
            reader44 = cmd44.ExecuteReader();
            dt44.Columns.Add("Вид", typeof(string));
            dt44.Load(reader44);
            cmbMaterial4.ValueMember = dt44.Columns[1].ToString();
            cmbMaterial4.DisplayMember = dt44.Columns[0].ToString();
            cmbMaterial4.DataSource = dt44;
            cmbMaterial4.SelectedIndex = -1;
            conn.Close();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string dateString, reg_number, full_name, objectBegin, objectEnd;
            string[] vid = new string[4];
            String[] kolichestvo_text = new String[4];
            string[] merna_edinitsa = new string[4];
            decimal begin_km, end_km, km_tovaritelnitsa, km, gorivo;
            String begin_Km, end_Km, km_Tovaritelnitsa, Km, Gorivo;
            decimal[] kolichestvo_sum = new decimal[4];
            int nomer_paten_list, nomer_tovaritelnitsa, hours_worked;
            bool[] hasError = new bool[4];
            CultureInfo culture = new CultureInfo("bg-BG");
            

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Отчет values (@Data, @MPS, @Begin_km, @End_km, @Km_tovaritelnitsa, @Hours_worked, @Shofior, @Number_paten_list, @Number_tovaritelnitsa, @ObjectBegin, @ObjectEnd, @Material_1, @Material_2, @Material_3, @Material_4, @Kolichestvo_text_1, @Kolichestvo_text_2, @Kolichestvo_text_3, @Kolichestvo_text_4, @Kolichestvo_suma_1, @Kolichestvo_suma_2, @Kolichestvo_suma_3, @Kolichestvo_suma_4, @Merna_edinitsa_1, @Merna_edinitsa_2, @Merna_edinitsa_3, @Merna_edinitsa_4, @Km, @Gorivo)";

            dateString = dtpDateFrom.Value.ToShortDateString();
            DateTime date = DateTime.Parse(dateString, culture);
            reg_number = cmbMPS.Text;

            if (txtBegin.Text == "")
            {
                begin_km = 0;
            }
            else
            {
                begin_Km = txtBegin.Text;
                begin_Km = begin_Km.Replace(",", ".");
                begin_km = decimal.Parse(begin_Km, new CultureInfo("en-US"));
            }

            if (txtEnd.Text == "")
            {
                end_km = 0;
            }
            else
            {
                end_Km = txtEnd.Text;
                end_Km = end_Km.Replace(",", ".");
                end_km = decimal.Parse(end_Km, new CultureInfo("en-US"));
            }

            if (txtKmTovaritelnitsa.Text == "")
            {
                km_tovaritelnitsa = 0;
            }
            else
            {
                km_Tovaritelnitsa = txtKmTovaritelnitsa.Text;
                km_Tovaritelnitsa = km_Tovaritelnitsa.Replace(",", ".");
                km_tovaritelnitsa = decimal.Parse(km_Tovaritelnitsa, new CultureInfo("en-US"));
            }

            if (txtHoursWorked.Text == "")
            {
                hours_worked = 0;
            }
            else
            {
                hours_worked = int.Parse(txtHoursWorked.Text);
            }

            full_name = cmbDriver.Text;
            nomer_paten_list = int.Parse(txtNumber_p_list.Text);
            nomer_tovaritelnitsa = int.Parse(txtNumber_tovar.Text);
            objectBegin = cmbObjectBegin.Text;
            objectEnd = cmbObjectEnd.Text;
            vid[0] = cmbMaterial1.Text;
            vid[1] = cmbMaterial2.Text;
            vid[2] = cmbMaterial3.Text;
            vid[3] = cmbMaterial4.Text;
            kolichestvo_text[0] = txtKolichestvo1.Text;
            kolichestvo_text[1] = txtKolichestvo2.Text;
            kolichestvo_text[2] = txtKolichestvo3.Text;
            kolichestvo_text[3] = txtKolichestvo4.Text;
            Expression[] expr = new Expression[4];
            for (int i = 0; i < 4; i++)
            {

                if (kolichestvo_text[i] == "")
                {
                    kolichestvo_sum[i] = 0;
                    kolichestvo_text[i] = "0";
                    expr[i] = new Expression(kolichestvo_text[i]);
                    hasError[i] = expr[i].HasErrors();
                }
                else
                {
                    kolichestvo_text[i] = kolichestvo_text[i].Replace(",", ".");
                    expr[i] = new Expression(kolichestvo_text[i]);
                    hasError[i] = expr[i].HasErrors();
                    if (hasError[i] == true)
                    {
                        
                        MessageBox.Show("Въведеният израз е НЕВАЛИДЕН!");
                        kolichestvo_sum[i] = 0;
                    }
                    else
                    {
                        kolichestvo_sum[i] = Convert.ToDecimal(expr[i].Evaluate());
                    }
                }
            }
            merna_edinitsa[0] = cmbMerna_edinitsa1.Text;
            merna_edinitsa[1] = cmbMerna_edinitsa2.Text;
            merna_edinitsa[2] = cmbMerna_edinitsa3.Text;
            merna_edinitsa[3] = cmbMerna_edinitsa4.Text;
            km = end_km - begin_km;

            if (txtGorivo.Text == "")
            {
                gorivo = 0;
            }
            else
            {
                Gorivo = txtGorivo.Text;
                Gorivo = Gorivo.Replace(",", ".");
                gorivo = decimal.Parse(Gorivo, new CultureInfo("en-US"));
            }

            cmd.Parameters.AddWithValue("@Data", date);
            cmd.Parameters.AddWithValue("@MPS", reg_number);
            cmd.Parameters.AddWithValue("@Begin_km", begin_km);
            cmd.Parameters.AddWithValue("@End_km", end_km);
            cmd.Parameters.AddWithValue("@Km_tovaritelnitsa", km_tovaritelnitsa);
            cmd.Parameters.AddWithValue("@Hours_worked", hours_worked);
            cmd.Parameters.AddWithValue("@Shofior", full_name);
            cmd.Parameters.AddWithValue("@Number_paten_list", nomer_paten_list);
            cmd.Parameters.AddWithValue("@Number_tovaritelnitsa", nomer_tovaritelnitsa);
            cmd.Parameters.AddWithValue("@ObjectBegin", objectBegin);
            cmd.Parameters.AddWithValue("@ObjectEnd", objectEnd);
            cmd.Parameters.AddWithValue("@Material_1", vid[0]);
            cmd.Parameters.AddWithValue("@Material_2", vid[1]);
            cmd.Parameters.AddWithValue("@Material_3", vid[2]);
            cmd.Parameters.AddWithValue("@Material_4", vid[3]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_1", kolichestvo_text[0]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_2", kolichestvo_text[1]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_3", kolichestvo_text[2]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_4", kolichestvo_text[3]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_1", kolichestvo_sum[0]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_2", kolichestvo_sum[1]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_3", kolichestvo_sum[2]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_4", kolichestvo_sum[3]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_1", merna_edinitsa[0]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_2", merna_edinitsa[1]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_3", merna_edinitsa[2]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_4", merna_edinitsa[3]);
            cmd.Parameters.AddWithValue("@Km", km);
            cmd.Parameters.AddWithValue("@Gorivo", gorivo);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                cmbMPS.SelectedIndex = -1;
                txtBegin.Text = null;
                txtEnd.Text = null;
                txtKmTovaritelnitsa.Text = null;
                txtHoursWorked.Text = null;
                cmbDriver.SelectedIndex = -1;
                txtNumber_p_list.Text = null;
                txtNumber_tovar.Text = null;
                cmbObjectBegin.SelectedIndex = -1;
                cmbObjectEnd.SelectedIndex = -1;
                cmbMaterial1.SelectedIndex = -1;
                cmbMaterial2.SelectedIndex = -1;
                cmbMaterial3.SelectedIndex = -1;
                cmbMaterial4.SelectedIndex = -1;
                txtKolichestvo1.Text = null;
                txtKolichestvo2.Text = null;
                txtKolichestvo3.Text = null;
                txtKolichestvo4.Text = null;
                cmbMerna_edinitsa1.SelectedIndex = -1;
                cmbMerna_edinitsa2.SelectedIndex = -1;
                cmbMerna_edinitsa3.SelectedIndex = -1;
                cmbMerna_edinitsa4.SelectedIndex = -1;
                txtGorivo.Text = null;
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            string dateString1, dateString2, reg_number, full_name, object_begin, object_end;
            string[] vid = new string[4];
            int day1, day2, month1, month2, year1, year2;
            string dateStr1, dateStr2;
            reg_number = cmbMPS.Text;
            full_name = cmbDriver.Text;
            object_begin = cmbObjectBegin.Text;
            object_end = cmbObjectEnd.Text;
            vid[0] = cmbMaterial1.Text;
            vid[1] = cmbMaterial2.Text;
            vid[2] = cmbMaterial3.Text;
            vid[3] = cmbMaterial4.Text;
            CultureInfo culture = new CultureInfo("bg-BG");

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            dateString1 = dtpDateFrom.Value.ToShortDateString();
            dateString2 = dtpDateTo.Value.ToShortDateString();
            DateTime date1 = DateTime.Parse(dateString1, culture);
            DateTime date2 = DateTime.Parse(dateString2, culture);
            day1 = date1.Day;
            day2 = date2.Day;
            month1 = date1.Month;
            month2 = date2.Month;
            year1 = date1.Year;
            year2 = date2.Year;
            if (month1 >= 1 && month1 <= 9)
            {
                if (day1 >= 1 && day1 <= 9)
                {
                    dateStr1 = year1 + "-0" + month1 + "-0" + day1;
                }
                else
                {
                    dateStr1 = year1 + "-0" + month1 + "-" + day1;
                }
            }
            else
            {
                if (day1 >= 1 && day1 <= 9)
                {
                    dateStr1 = year1 + "-" + month1 + "-0" + day1;
                }
                else
                {
                    dateStr1 = year1 + "-" + month1 + "-" + day1;
                }
            }
            if (month2 >= 1 && month2 <= 9)
            {
                if (day2 >= 1 && day2 <= 9)
                {
                    dateStr2 = year2 + "-0" + month2 + "-0" + day2;
                }
                else
                {
                    dateStr2 = year2 + "-0" + month2 + "-" + day2;
                }
            }
            else
            {
                if (day2 >= 1 && day2 <= 9)
                {
                    dateStr2 = year2 + "-" + month2 + "-0" + day2;
                }
                else
                {
                    dateStr2 = year2 + "-" + month2 + "-" + day2;
                }
            }
            if (cmbMPS.SelectedIndex != -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "') AND МПС = N'" + reg_number + "'";
                //MessageBox.Show(cmd.CommandText);
            }
            else if(cmbDriver.SelectedIndex != -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "') AND Шофьор = N'" + full_name + "'";
            }
            else if(cmbObjectBegin.SelectedIndex != -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "') AND Обект_начало = N'" + object_begin + "'";
            }
            else if(cmbMaterial1.SelectedIndex != -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "') AND Материал_1 = N'" + vid[0] + "'";
            }
            else if(cmbMaterial2.SelectedIndex != -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "') AND Материал_2 = N'" + vid[1] + "'";
            }
            else if(cmbMaterial3.SelectedIndex != -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "') AND Материал_3 = N'" + vid[2] + "'";
            }
            else if(cmbMaterial4.SelectedIndex != -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "') AND Материал_4 = N'" + vid[3] + "'";
            }
            else if (cmbMPS.SelectedIndex == -1 && cmbDriver.SelectedIndex == -1 && cmbObjectBegin.SelectedIndex == -1 && cmbObjectEnd.SelectedIndex == -1 && cmbMaterial1.SelectedIndex == -1)
            {
                cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_сума_1, Количество_сума_2, Количество_сума_3, Количество_сума_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Дата between '" + dateStr1 + "' AND '" + dateStr2 + "')";
            }

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dAdapter.Fill(ds);
            grdOtcheti.ReadOnly = true;
            grdOtcheti.DataSource = ds.Tables[0];
            grdOtcheti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            conn.Close();
        }

        private void txtClean_Click(object sender, EventArgs e)
        {
            cmbMPS.SelectedIndex = -1; ;
            txtBegin.Text = null;
            txtEnd.Text = null;
            txtHoursWorked.Text = null;
            cmbDriver.SelectedIndex = -1;
            txtNumber_p_list.Text = null;
            txtNumber_tovar.Text = null;
            cmbObjectBegin.SelectedIndex = -1;
            cmbObjectEnd.SelectedIndex = -1;
            cmbMaterial1.SelectedIndex = -1;
            cmbMaterial2.SelectedIndex = -1;
            cmbMaterial3.SelectedIndex = -1;
            cmbMaterial4.SelectedIndex = -1;
            txtKolichestvo1.Text = null;
            txtKolichestvo2.Text = null;
            txtKolichestvo3.Text = null;
            txtKolichestvo4.Text = null;
            cmbMerna_edinitsa1.SelectedIndex = -1;
            cmbMerna_edinitsa2.SelectedIndex = -1;
            cmbMerna_edinitsa3.SelectedIndex = -1;
            cmbMerna_edinitsa4.SelectedIndex = -1;
            txtGorivo.Text = null;
            grdOtcheti.DataSource = null;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int nomer_paten_list, nomer_tovaritelnitsa;
            string dateString;
            String MPS, full_name, objekt_begin, object_end;
            String[] material = new String[4];
            String[] merna_edinitsa = new String[4];
            nomer_paten_list = 0;
            nomer_tovaritelnitsa = 0;
            dateString = null;
            MPS = null;
            full_name = null;
            objekt_begin = null;
            object_end = null;
            material[0] = null;
            material[1] = null;
            material[2] = null;
            material[3] = null;
            merna_edinitsa[0] = null;
            merna_edinitsa[1] = null;
            merna_edinitsa[2] = null;
            merna_edinitsa[3] = null;
            CultureInfo culture = new CultureInfo("bg-BG");

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ИД, Дата, МПС, Начало_км, Край_км, Км_товарителница, Отработени_часове, Шофьор, Номер_пътен_лист, Номер_товарителница, Обект_начало, Обект_край, Материал_1, Материал_2, Материал_3, Материал_4, Количество_текст_1, Количество_текст_2, Количество_текст_3, Количество_текст_4, Мерна_единица_1, Мерна_единица_2, Мерна_единица_3, Мерна_единица_4, Км, Гориво FROM Отчет WHERE (Номер_пътен_лист=@Number_paten_list AND Номер_товарителница=@Number_tovaritelnitsa)";
            nomer_paten_list = int.Parse(txtNumber_p_list.Text);
            nomer_tovaritelnitsa = int.Parse(txtNumber_tovar.Text);
            cmd.Parameters.AddWithValue("@Number_paten_list", nomer_paten_list);
            cmd.Parameters.AddWithValue("@Number_tovaritelnitsa", nomer_tovaritelnitsa);
            dateString = dtpDateFrom.Value.ToShortDateString();
            cmbMPS.SelectedIndex = -1;
            cmbDriver.SelectedIndex = -1;
            cmbMerna_edinitsa1.SelectedIndex = -1;
            cmbMerna_edinitsa2.SelectedIndex = -1;
            cmbMerna_edinitsa3.SelectedIndex = -1;
            cmbMerna_edinitsa4.SelectedIndex = -1;
            if (nomer_paten_list != 0 && nomer_tovaritelnitsa != 0)
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                dtpDateFrom.CustomFormat = "dd-MM-yyyy";
                dtpDateFrom.Value = Convert.ToDateTime(sdr["Дата"].ToString());
                MPS = sdr["МПС"].ToString();
                MPS = MPS.Trim();
                cmbMPS.SelectedText = MPS;
                txtBegin.Text = sdr["Начало_км"].ToString();
                txtEnd.Text = sdr["Край_км"].ToString();
                txtKmTovaritelnitsa.Text = sdr["Км_товарителница"].ToString();
                txtHoursWorked.Text = sdr["Отработени_часове"].ToString();
                full_name = sdr["Шофьор"].ToString();
                full_name = full_name.Trim();
                cmbDriver.SelectedText = full_name;
                txtNumber_p_list.Text = sdr["Номер_пътен_лист"].ToString();
                txtNumber_tovar.Text = sdr["Номер_товарителница"].ToString();
                objekt_begin = sdr["Обект_начало"].ToString();
                objekt_begin = objekt_begin.Trim();
                cmbObjectBegin.SelectedText = objekt_begin;
                object_end = sdr["Обект_край"].ToString();
                object_end = object_end.Trim();
                cmbObjectEnd.SelectedText = object_end;
                material[0] = sdr["Материал_1"].ToString();
                material[0] = material[0].Trim();
                cmbMaterial1.SelectedText = material[0];
                material[1] = sdr["Материал_2"].ToString();
                material[1] = material[1].Trim();
                cmbMaterial2.SelectedText = material[1];
                material[2] = sdr["Материал_3"].ToString();
                material[2] = material[2].Trim();
                cmbMaterial3.SelectedText = material[2];
                material[3] = sdr["Материал_4"].ToString();
                material[3] = material[3].Trim();
                cmbMaterial4.SelectedText = material[3];
                txtKolichestvo1.Text = sdr["Количество_текст_1"].ToString();
                txtKolichestvo2.Text = sdr["Количество_текст_2"].ToString();
                txtKolichestvo3.Text = sdr["Количество_текст_3"].ToString();
                txtKolichestvo4.Text = sdr["Количество_текст_4"].ToString();
                merna_edinitsa[0] = sdr["Мерна_единица_1"].ToString();
                merna_edinitsa[0] = merna_edinitsa[0].Trim();
                cmbMerna_edinitsa1.SelectedText = merna_edinitsa[0];
                merna_edinitsa[1] = sdr["Мерна_единица_2"].ToString();
                merna_edinitsa[1] = merna_edinitsa[1].Trim();
                cmbMerna_edinitsa2.SelectedText = merna_edinitsa[1];
                merna_edinitsa[2] = sdr["Мерна_единица_3"].ToString();
                merna_edinitsa[2] = merna_edinitsa[2].Trim();
                cmbMerna_edinitsa3.SelectedText = merna_edinitsa[2];
                merna_edinitsa[3] = sdr["Мерна_единица_4"].ToString();
                merna_edinitsa[3] = merna_edinitsa[3].Trim();
                cmbMerna_edinitsa4.SelectedText = merna_edinitsa[3];
                txtGorivo.Text = sdr["Гориво"].ToString();
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string dateString, model, full_name, objekt_begin, object_end;
            string[] vid = new string[4];
            String[] kolichestvo_text = new String[4];
            string[] merna_edinitsa = new string[4];
            decimal begin_km, end_km, km_tovaritelnitsa, km, gorivo;
            String begin_Km, end_Km, km_Tovaritelnitsa, Km, Gorivo;
            decimal[] kolichestvo_sum = new decimal[4];
            int nomer_paten_list, nomer_tovaritelnitsa, hours_worked;
            bool[] hasError=new bool[4];
            CultureInfo culture = new CultureInfo("bg-BG");


            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Отчет SET Дата=@Data, МПС=@MPS, Начало_км=@Begin_km, Край_км=@End_km, Км_товарителница=@Km_tovaritelnitsa, Отработени_часове=@Hours_worked, Шофьор=@Shofior, Обект_начало=@Object_begin, Обект_край=@Object_end, Материал_1=@Material_1, Материал_2=@Material_2, Материал_3=@Material_3, Материал_4=@Material_4, Количество_текст_1=@Kolichestvo_text_1, Количество_текст_2=@Kolichestvo_text_2, Количество_текст_3=@Kolichestvo_text_3, Количество_текст_4=@Kolichestvo_text_4, Количество_сума_1=@Kolichestvo_suma_1, Количество_сума_2=@Kolichestvo_suma_2, Количество_сума_3=@Kolichestvo_suma_3, Количество_сума_4=@Kolichestvo_suma_4, Мерна_единица_1=@Merna_edinitsa_1, Мерна_единица_2=@Merna_edinitsa_2, Мерна_единица_3=@Merna_edinitsa_3, Мерна_единица_4=@Merna_edinitsa_4, Км=@Km, Гориво=@Gorivo WHERE (Номер_пътен_лист=@Number_paten_list AND Номер_товарителница=@Number_tovaritelnitsa)";
            dateString = dtpDateFrom.Value.ToShortDateString();
            DateTime date = DateTime.Parse(dateString, culture);
            model = cmbMPS.Text;
            begin_Km = txtBegin.Text;
            begin_Km = begin_Km.Replace(",", ".");
            begin_km = decimal.Parse(begin_Km, new CultureInfo("en-US"));
            end_Km = txtEnd.Text;
            end_Km = end_Km.Replace(",", ".");
            end_km = decimal.Parse(end_Km, new CultureInfo("en-US"));
            km_Tovaritelnitsa = txtKmTovaritelnitsa.Text;
            km_Tovaritelnitsa = km_Tovaritelnitsa.Replace(",", ".");
            km_tovaritelnitsa = decimal.Parse(km_Tovaritelnitsa, new CultureInfo("en-US"));
            hours_worked = int.Parse(txtHoursWorked.Text);
            full_name = cmbDriver.Text;
            nomer_paten_list = int.Parse(txtNumber_p_list.Text);
            nomer_tovaritelnitsa = int.Parse(txtNumber_tovar.Text);
            objekt_begin = cmbObjectBegin.Text;
            object_end = cmbObjectEnd.Text;
            vid[0] = cmbMaterial1.Text;
            vid[1] = cmbMaterial2.Text;
            vid[2] = cmbMaterial3.Text;
            vid[3] = cmbMaterial4.Text;
            kolichestvo_text[0] = txtKolichestvo1.Text;
            kolichestvo_text[0] = kolichestvo_text[0].Replace(",", ".");
            kolichestvo_text[1] = txtKolichestvo2.Text;
            kolichestvo_text[1] = kolichestvo_text[1].Replace(",", ".");
            kolichestvo_text[2] = txtKolichestvo3.Text;
            kolichestvo_text[2] = kolichestvo_text[2].Replace(",", ".");
            kolichestvo_text[3] = txtKolichestvo4.Text;
            kolichestvo_text[3] = kolichestvo_text[3].Replace(",", ".");

            Expression[] expr = new Expression[4];

            for (int i = 0; i < 4; i++)
            {

                if (kolichestvo_text[i] == "")
                {
                    kolichestvo_sum[i] = 0;
                    kolichestvo_text[i] = "0";
                    expr[i] = new Expression(kolichestvo_text[i]);
                    hasError[i] = expr[i].HasErrors();
                }
                else
                {
                    expr[i] = new Expression(kolichestvo_text[i]);
                    hasError[i] = expr[i].HasErrors();
                    if (hasError[i] == true)
                    {
                        MessageBox.Show("Въведеният израз е НЕВАЛИДЕН!");
                        kolichestvo_sum[i] = 0;
                    }
                    else
                    {
                        kolichestvo_sum[i] = Convert.ToDecimal(expr[i].Evaluate());
                    }
                }
            }
            merna_edinitsa[0] = cmbMerna_edinitsa1.Text;
            merna_edinitsa[1] = cmbMerna_edinitsa2.Text;
            merna_edinitsa[2] = cmbMerna_edinitsa3.Text;
            merna_edinitsa[3] = cmbMerna_edinitsa4.Text;
            km = end_km - begin_km;
            Gorivo = txtGorivo.Text;
            Gorivo = Gorivo.Replace(",", ".");
            gorivo = decimal.Parse(Gorivo, new CultureInfo("en-US"));
            cmd.Parameters.AddWithValue("@Data", date);
            cmd.Parameters.AddWithValue("@MPS", model);
            cmd.Parameters.AddWithValue("@Begin_km", begin_km);
            cmd.Parameters.AddWithValue("@End_km", end_km);
            cmd.Parameters.AddWithValue("@Km_tovaritelnitsa", km_tovaritelnitsa);
            cmd.Parameters.AddWithValue("@Hours_worked", hours_worked);
            cmd.Parameters.AddWithValue("@Shofior", full_name);
            cmd.Parameters.AddWithValue("@Number_paten_list", nomer_paten_list);
            cmd.Parameters.AddWithValue("@Number_tovaritelnitsa", nomer_tovaritelnitsa);
            cmd.Parameters.AddWithValue("@Object_begin", objekt_begin);
            cmd.Parameters.AddWithValue("@Object_end", object_end);
            cmd.Parameters.AddWithValue("@Material_1", vid[0]);
            cmd.Parameters.AddWithValue("@Material_2", vid[1]);
            cmd.Parameters.AddWithValue("@Material_3", vid[2]);
            cmd.Parameters.AddWithValue("@Material_4", vid[3]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_1", kolichestvo_text[0]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_2", kolichestvo_text[1]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_3", kolichestvo_text[2]);
            cmd.Parameters.AddWithValue("@Kolichestvo_text_4", kolichestvo_text[3]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_1", kolichestvo_sum[0]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_2", kolichestvo_sum[1]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_3", kolichestvo_sum[2]);
            cmd.Parameters.AddWithValue("@Kolichestvo_suma_4", kolichestvo_sum[3]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_1", merna_edinitsa[0]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_2", merna_edinitsa[1]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_3", merna_edinitsa[2]);
            cmd.Parameters.AddWithValue("@Merna_edinitsa_4", merna_edinitsa[3]);
            cmd.Parameters.AddWithValue("@Km", km);
            cmd.Parameters.AddWithValue("@Gorivo", gorivo);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са обновени успешно!!!");
                cmbMPS.SelectedIndex = -1;
                txtBegin.Text = null;
                txtEnd.Text = null;
                txtKmTovaritelnitsa.Text = null;
                txtHoursWorked.Text = null;
                cmbDriver.SelectedIndex = -1;
                txtNumber_p_list.Text = null;
                txtNumber_tovar.Text = null;
                cmbObjectBegin.SelectedIndex = -1;
                cmbObjectEnd.SelectedIndex = -1;
                cmbMaterial1.SelectedIndex = -1;
                cmbMaterial2.SelectedIndex = -1;
                cmbMaterial3.SelectedIndex = -1;
                cmbMaterial4.SelectedIndex = -1;
                txtKolichestvo1.Text = null;
                txtKolichestvo2.Text = null;
                txtKolichestvo3.Text = null;
                txtKolichestvo4.Text = null;
                cmbMerna_edinitsa1.SelectedIndex = -1;
                cmbMerna_edinitsa2.SelectedIndex = -1;
                cmbMerna_edinitsa3.SelectedIndex = -1;
                cmbMerna_edinitsa4.SelectedIndex = -1;
                txtGorivo.Text = null;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря, защото се опитвате да обновите несъщестуващи данни!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int nomer_paten_list, nomer_tovaritelnitsa;
            nomer_paten_list = 0;
            nomer_tovaritelnitsa = 0;

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Отчет WHERE (Номер_пътен_лист=@Number_paten_list AND Номер_товарителница=@Number_tovaritelnitsa)";

            nomer_paten_list = int.Parse(txtNumber_p_list.Text);
            nomer_tovaritelnitsa = int.Parse(txtNumber_tovar.Text);
            cmd.Parameters.AddWithValue("@Number_paten_list", nomer_paten_list);
            cmd.Parameters.AddWithValue("@Number_tovaritelnitsa", nomer_tovaritelnitsa);

            DialogResult deleteDb = MessageBox.Show("Искате ли да изтриете тези данни?", "Изтриване", MessageBoxButtons.YesNo);

            if (deleteDb == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данните са изтрити успешно!!!");
                    cmbMPS.SelectedIndex = -1;
                    txtBegin.Text = null;
                    txtEnd.Text = null;
                    txtHoursWorked.Text = null;
                    cmbDriver.SelectedIndex = -1;
                    txtNumber_p_list.Text = null;
                    txtNumber_tovar.Text = null;
                    cmbObjectBegin.SelectedIndex = -1;
                    cmbMaterial1.SelectedIndex = -1;
                    cmbMaterial2.SelectedIndex = -1;
                    cmbMaterial3.SelectedIndex = -1;
                    cmbMaterial4.SelectedIndex = -1;
                    txtKolichestvo1.Text = null;
                    txtKolichestvo2.Text = null;
                    txtKolichestvo3.Text = null;
                    txtKolichestvo4.Text = null;
                    cmbMerna_edinitsa1.SelectedIndex = -1;
                    cmbMerna_edinitsa2.SelectedIndex = -1;
                    cmbMerna_edinitsa3.SelectedIndex = -1;
                    cmbMerna_edinitsa4.SelectedIndex = -1;
                    txtGorivo.Text = null;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Exported From DataGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = -1; i < grdOtcheti.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grdOtcheti.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = grdOtcheti.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = grdOtcheti.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 1;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Експортирането на данните е успешно!!!");
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Данните не могат да се експортират! ");
            }
            finally
            {
                app.Quit();
                workbook = null;
                app = null;
            }
        }
    }
}
