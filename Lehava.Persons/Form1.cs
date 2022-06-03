using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lehava.Persons.Entities;

namespace Lehava.Persons
{
    public partial class Form1 : Form
    {
        PersonEntity entity;

        public Form1()
        {
            InitializeComponent();
            entity = new PersonEntity();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entity.AddRecord(textBox1.Text, int.Parse(textBox2.Text));
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            entity.SaveAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entity.Load();
        }
    }
}
