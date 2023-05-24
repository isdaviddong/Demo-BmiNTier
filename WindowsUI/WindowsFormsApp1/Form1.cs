﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HealthMgr.BmiCalculator bc = new HealthMgr.BmiCalculator();
            bc.Height = int.Parse(this.textBox1.Text);
            bc.Weight = int.Parse(this.textBox2.Text);
            var BMI = bc.Calculate();
            this.label3.Text = BMI.ToString();
        }
    }
}
