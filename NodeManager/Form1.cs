using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NodeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // не зебыть прописать проверку авторизации...


            string login = textBox1.Text;
            string password = textBox2.Text;
            
            if (login == "mickle" && password == "1234")
            {
                Form2 f2 = new Form2(this);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели не верный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
