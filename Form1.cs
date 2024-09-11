using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        private Note note;
        public Form1()
        {
            InitializeComponent();
            note = new Note();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("contacts.txt"))
            {
            
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var fields = line.Split(',');

                    var name = fields[0];
                    var number = fields[1];
                    var org = fields[2];
                    var group = fields[3];

                    note.AddContact( name, org,number,group);
                    MessageBox.Show( "Файл считан");
                    label1.Text = "";
                    
                   

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var n = textBox1.Text;
                var numb = textBox2.Text;
                var org = textBox3.Text;
                var gr = textBox4.Text;

                note.AddContact(n,numb,org,gr);
                MessageBox.Show("Контакт добавлен");
            }
            catch
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var n = textBox1.Text;
                var numb = textBox2.Text;
                var org = textBox3.Text;
                var gr = textBox4.Text;

                note.DeleteContact(n, numb, org, gr);
                MessageBox.Show("Контакт удален");
            }
            catch
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var n = textBox1.Text;
                var numb = textBox2.Text;
                var org = textBox3.Text;
                var gr = textBox4.Text;

                var n1 = textBox5.Text;
                var numb1 = textBox6.Text;
                var org1 = textBox7.Text;
                var gr1 = textBox8.Text;

                note.RedactContact(n, numb, org, gr, n1, numb1, org1, gr1);
                MessageBox.Show("Контакт изменен");
            }
            catch
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                var gr = textBox1.Text;
                var GROUP = note.FindGr(gr);
                label1.Text = "";
                foreach (var c  in GROUP)
                {
                    label1.Text += $"Событие: {c.name}, Дата: {c.number}, Ярус: {c.org}, Ряд: {c.group}\n";
                }
            }
            catch
            {
                MessageBox.Show("Заполните поля: дата, ярус, мин. цена, макс. цена");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                var name1 = textBox1.Text;
                var FIND = note.FindContact(name1);
                label1.Text = "";
                foreach (var c in FIND)
                {
                    label1.Text += $"Событие: {c.name}, Дата: {c.number}, Ярус: {c.org}, Ряд: {c.group}\n";
                }
            }
            catch
            {
                MessageBox.Show("Заполните поля: дата, ярус, мин. цена, макс. цена");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var n = textBox1.Text;
                
                
                var gr = textBox2.Text;


                note.Addgr(n, gr);
                MessageBox.Show("Контакт изменен");
            }
            catch
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}

