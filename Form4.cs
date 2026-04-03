using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fotostydya
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {

                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox4.Text))


                {
                    DataRow newRow = AppData.TripSet.Tables[0].NewRow();
                    newRow["Razmer"] = textBox1.Text;
                    newRow["Naz"] = textBox2.Text;
                    newRow["Naz"] = textBox3.Text;
                    newRow["DataZ"] = dateTimePicker1.Value;
                    newRow["FIO"] = textBox5.Text;
                    newRow["Naz"] = textBox6.Text;
                    newRow["Qena"] = textBox7.Text;
                 

                    AppData.TripSet.Tables[0].Rows.Add(newRow);
                    SaveData();
                    MessageBox.Show("Путешествие довавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else { MessageBox.Show("Заполните все поля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Введите логин!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void SaveData()
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Fotost;Integrated Security=False";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        string selectQuery = "SELECT* FROM Pytech";
                        AppData.sqlDataAdapterTrip = new SqlDataAdapter(selectQuery, sqlConnection);




                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(AppData.sqlDataAdapterTrip);
                        AppData.sqlDataAdapterTrip.Update(AppData.TripSet, "Pytech");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузки данный о путешествиях: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
             private bool IsUserAlreadyExisits(string login)
        {
            foreach (DataRow row in AppData.userSet.Tables[0].Rows)
            {
                if (row["login"].ToString() == login)
                    return true;
            }
            return false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

