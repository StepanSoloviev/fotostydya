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

namespace fotostydya
{
    public partial class Kon : Form
    {
        public Kon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {

                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox4.Text))


                {
                    DataRow newRow = AppData.TripSet.Tables[0].NewRow();
                    newRow["Razmer1"] = textBox1.Text;
                    newRow["Nazm"] = textBox2.Text;
                    newRow["FIO"] = textBox4.Text;
                    newRow["Qena"] = textBox5.Text;
                    newRow["Nazs"] = textBox6.Text;
                    newRow["Zakaz"] = dateTimePicker1.Value;
                    AppData.TripSet.Tables[0].Rows.Add(newRow);
                    SaveData();
                    MessageBox.Show("Путешествие довавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else { MessageBox.Show("Заполните все поля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Введите логин!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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
    }
}
