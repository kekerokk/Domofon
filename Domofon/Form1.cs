using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domofon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*button1.Click += new EventHandler(this.button7_Click);
            button2.Click += new EventHandler(this.button7_Click);
            button3.Click += new EventHandler(this.button7_Click);
            button4.Click += new EventHandler(this.button7_Click);
            button5.Click += new EventHandler(this.button7_Click);
            button6.Click += new EventHandler(this.button7_Click);
            button7.Click += new EventHandler(this.button7_Click);
            button8.Click += new EventHandler(this.button7_Click);
            button9.Click += new EventHandler(this.button7_Click);*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            textBox1.Text = $"{textBox1.Text}{but.Text}";
            if(textBox1.Text.Count(x => char.IsDigit(x)) == 4)
            {
                if (Convert.ToInt16(textBox1.Text) == 5225)
                {
                    MessageBox.Show("Пароль введен верно");
                }
                else
                    MessageBox.Show("Пароль введен неверно");
                textBox1.Text = "";
            }
        }
    }
}
