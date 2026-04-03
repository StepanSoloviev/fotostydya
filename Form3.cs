using fotostydya;
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
namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            BindTripsToDataGridView();
        }

        private void BindTripsToDataGridView()
        {
            LoadTripsData();
            List<Trip> Form3 = GetTripsList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Form3;
        }
        public static void LoadTripsData()
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Fotost;Integrated Security=False";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        string selectQuery = "SELECT* FROM Foto";
                        AppData.sqlDataAdapterTrip = new SqlDataAdapter(selectQuery, sqlConnection);

                        AppData.TripSet = new DataSet();
                        AppData.sqlDataAdapterTrip.Fill(AppData.TripSet, "Foto");




                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузки данный о путешествиях: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static List<Trip> GetTripsList()
        {
            var Form3 = new List<Trip>();
            if (AppData.TripSet?.Tables["Zakaz"] != null)
            {
                foreach (DataRow row in AppData.TripSet.Tables["Foto"].Rows)
                {
                    Form3.Add(new Trip
                    {
                        Razmer1 = row["Razmer"].ToString(),
                        Naz1 = row["RNaz"].ToString(),
                        Naz2 = row["MNaz"].ToString(),
                        
                        Sot = row["SNaz"].ToString(),

                    });
                }
            }
            return Form3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}