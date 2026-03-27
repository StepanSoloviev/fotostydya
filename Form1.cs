
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fotostydya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (DataRow row in AppData.userSet.Tables[0].Rows)
            {
                if (row["Login"].ToString() == textBox6.Text && row["password"].ToString() == textBox3.Text)
                {
                    Form3 Form3 = new Form3();
                    Form3.ShowDialog();
                }
            }
            if (!flag)
            {
                MessageBox.Show("Вы не успешно авторизировались", "Авторизация прпойдена", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
