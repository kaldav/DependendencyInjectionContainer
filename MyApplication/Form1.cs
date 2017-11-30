using LotteryWinnerGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INumberGeneration numberGeneration = DependencyInjectionContainer.GetInstance<INumberGeneration>();
            listBox1.DataSource = numberGeneration.GetNumbers().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DependencyInjectionContainer.MapInstance<INumberGeneration>(new HackedWinnerGenerator());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DependencyInjectionContainer.ClearCatalog();
        }
    }
}
