using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            String table_name = "Отчет";

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE [dbo].[Отчет] ([ИД] INT IDENTITY (1, 1) NOT NULL, [Дата] DATE, [МПС] NVARCHAR (20), [Начало_км] REAL, [Край_км] REAL, [Км_товарителница] REAL, [Отработени_часове] INT, [Шофьор] NVARCHAR (100), [Номер_пътен_лист] INT NOT NULL, [Номер_товарителница] INT NOT NULL, [Обект_начало] NVARCHAR (20), [Обект_край] NVARCHAR (20), [Материал_1] NVARCHAR (30), [Материал_2] NVARCHAR (30), [Материал_3] NVARCHAR (30), [Материал_4] NVARCHAR (30), [Количество_текст_1] NVARCHAR(30), [Количество_текст_2] NVARCHAR(30), [Количество_текст_3] NVARCHAR(30), [Количество_текст_4] NVARCHAR(30), [Количество_сума_1] REAL, [Количество_сума_2] REAL, [Количество_сума_3] REAL, [Количество_сума_4] REAL, [Мерна_единица_1] NCHAR (10), [Мерна_единица_2] NCHAR (10), [Мерна_единица_3] NCHAR (10), [Мерна_единица_4] NCHAR (10), [Км] REAL, [Гориво] REAL, CONSTRAINT [PK_Otcheti] PRIMARY KEY CLUSTERED ([Номер_пътен_лист] ASC, [Номер_товарителница] ASC))";
            
            try 
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Таблицата " + table_name + " вече е създадена!");
                conn.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Има съществуваща таблица.");
            }

            Report report = new Report();
            report.Show();
        }

        private void btnMPS_Click(object sender, EventArgs e)
        {
            String table_name = "МПС";

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE [dbo].МПС ([ИД] INT IDENTITY (1, 1) NOT NULL, [Вид] NCHAR (30), [Рег_номер] NVARCHAR (10), [Марка] NVARCHAR (30), [Модел] NVARCHAR (20), [Нето] REAL, [Товароподемност] REAL, [ВИН_номер] NCHAR (17), [ДВГ_номер] NCHAR (20), [Оси] INT, [Вместимост_резервоар] REAL, PRIMARY KEY CLUSTERED ([Рег_номер] ASC))";
           
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Таблицата " + table_name + " вече е създадена!");
                conn.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Има съществуваща таблица.");
            }

            MPS mps = new MPS();
            mps.Show();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            String table_name = "Шофьор";

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE [dbo].[Шофьор] ([ИД]INT IDENTITY (1, 1) NOT NULL, [Пълно_име] NVARCHAR (100), [Категории] NVARCHAR (20), [Професионална_компетентност] BIT, [Удостоверение] BIT, CONSTRAINT [PK_Shofior] PRIMARY KEY CLUSTERED ([Пълно_име] ASC))";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Таблицата " + table_name + " вече е създадена!");
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Има съществуваща таблица.");
            }

            Drivers drivers = new Drivers();
            drivers.Show();
        }

        private void btnObjects_Click(object sender, EventArgs e)
        {
            String table_name = "Обект";

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE [dbo].[Обект] ([ИД] INT IDENTITY (1, 1) NOT NULL, [Наименование] NVARCHAR (20), [Фирма] NVARCHAR (30), [БУЛСТАТ] NCHAR (10), [МОЛ] NVARCHAR (50), [Адрес] NVARCHAR (MAX), [Телефон] NVARCHAR (15), [Имейл] NVARCHAR (20), PRIMARY KEY CLUSTERED ([Наименование] ASC))";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Таблицата " + table_name + " вече е създадена!");
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Има съществуваща таблица.");
            }

            Objects objects = new Objects();
            objects.Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            String table_name = "Материал";

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE [dbo].[Материал] ([ИД] INT IDENTITY (1, 1) NOT NULL, [Вид] NVARCHAR (30), [Мерна_единица] NCHAR (10), [Произход] NVARCHAR (30), CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED ([Вид] ASC))";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Таблицата " + table_name + " вече е създадена!");
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Има съществуваща таблица.");
            }

            Materials materials = new Materials();
            materials.Show();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            String db = "Transport";

            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated security=SSPI;database=master";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE DATABASE Transport";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Базата данни "+db+" вече е създадена!");
                conn.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Има съществуваща база данни.");
            }
        }

        private void btnDeleteReports_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Transport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Отчет";

            DialogResult deleteDb = MessageBox.Show("Искате ли да изтриете тези данни?", "Изтриване", MessageBoxButtons.YesNo);

            if (deleteDb == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данните са изтрити успешно!!!");
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
