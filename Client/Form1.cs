﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(a, b);
            label3.Text = hasilTambah.ToString();
            double hasilKurang = obj.Kurang(a, b);
            label4.Text = hasilKurang.ToString();
            double hasilKali = obj.Kali(a, b);
            label5.Text = hasilKali.ToString();
            double hasilBagi = obj.Bagi(a, b);
            label6.Text = hasilBagi.ToString();
        }
    }
}
