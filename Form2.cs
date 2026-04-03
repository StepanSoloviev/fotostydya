
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

           
        }
        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(AppData.sqlDataAdapter);
            AppData.sqlDataAdapter.Update(AppData.userSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Логин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Логин";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(175, 329);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 40;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(175, 290);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 38;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 36;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(186, 123);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(630, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        { if (!String.IsNullOrEmpty(textBox2.Text))
            {
                if (IsUserAlreadyExisits(textBox2.Text))

                {
                    MessageBox.Show("Твой польлзователь существует!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox4.Text))
                {
                    if (textBox4.Text == textBox3.Text)
                    {
                        DataRow newRow = AppData.userSet.Tables[0].NewRow();
                        newRow["login"] = textBox2.Text;
                        newRow["IDP"] = 2;
                        newRow["fio"] = textBox1.Text;
                        newRow["password"] = textBox3.Text;
                        newRow["tel"] = textBox4.Text;
                        
                        AppData.userSet.Tables[0].Rows.Add(newRow);
                        SaveData();
                        MessageBox.Show("Пользователь довавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else { MessageBox.Show("Пароль не совпадает!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Заполните все поля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Введите логин!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
  

