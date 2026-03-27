
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace fotostydya
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBox6.Text))
            {
                if (IsUserAlreadyExisits(textBox6.Text))

                {
                    MessageBox.Show("Твой польлзователь существует!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox3.Text))
                {
                    if (textBox1.Text == textBox3.Text)
                    {
                        DataRow newRow = AppData.userSet.Tables[0].NewRow();
                        newRow["login"] = textBox6.Text;
                        newRow["tel"] = textBox2.Text;
                        newRow["fio"] = textBox5.Text;
                        newRow["password"] = textBox3.Text;
                      
                       
                        MessageBox.Show("Пользователь довавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else { MessageBox.Show("Пароль не совпадает!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Заполните все поля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Введите логин!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

