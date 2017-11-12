using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffeepose2
{
    public partial class Form1 : Form

    {
        int i = 0, oil = 0;
        string[] namecof = new string[500];
        string[] sprice = new string[500];
        public Form1()
        {
            InitializeComponent();
        }
        public string save;
        public void info()
        {
            ListViewItem coffeelist = new ListViewItem();
            coffeelist.Text = namecof[i];
            listView1.Items.Add(coffeelist);
            textBox3.Text = (oil += Convert.ToInt32(sprice[i])).ToString() + " บาท";
            save += namecof[i] + "  " + sprice[i] + Environment.NewLine;
        }
        public void info2()
        {
            ListViewItem coffeelist2 = new ListViewItem();
            coffeelist2.Text = sprice[i];
            listView2.Items.Add(coffeelist2);
            textBox3.Text = (oil += Convert.ToInt32(sprice[i])).ToString() + " บาท";
            save += namecof[i] + "  " + sprice[i] + Environment.NewLine;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            sprice[i] = "20";
            info2();
            i++;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sprice[i] = "30";
            info2();
            i++;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            sprice[i] = "35";
            info2();
            i++;
        }

        private void buttonam_Click(object sender, EventArgs e)
        {
            namecof[i] = "Americano";
            info();
        }

        private void buttonla_Click(object sender, EventArgs e)
        {
            namecof[i] = "Latte";
            info();
        }

        private void buttonmo_Click(object sender, EventArgs e)
        {
            namecof[i] = "Mocha";
            info();
        }

        private void buttonca_Click(object sender, EventArgs e)
        {
            namecof[i] = "Cappuccino";
            info();
        }

        private void buttongr_Click(object sender, EventArgs e)
        {
            namecof[i] = "GreenTea";
            info();
        }

        private void buttonth_Click(object sender, EventArgs e)
        {
            namecof[i] = "Thai Tea";
            info();
        }

        private void buttonco_Click(object sender, EventArgs e)
        {
            namecof[i] = "Cocoa";
            info();
        }

        private void buttonmi_Click(object sender, EventArgs e)
        {
            namecof[i] = "Milk";
            info();
        }

        private void buttonmitea_Click(object sender, EventArgs e)
        {
            namecof[i] = "Milk Tea";
            info();
        }

        private void buttonlem_Click(object sender, EventArgs e)
        {
            namecof[i] = "LemonTea";
            info();
        }

        private void buttonmilo_Click(object sender, EventArgs e)
        {
            namecof[i] = "Milo";
            info();
        }

        private void buttonnes_Click(object sender, EventArgs e)
        {
            namecof[i] = "Nescafe";
            info();
        }

        private void buttonnestea_Click(object sender, EventArgs e)
        {
            namecof[i] = "NesTea";
            info();
        }

        private void buttontan_Click(object sender, EventArgs e)
        {
            namecof[i] = "Italian Soda";
            info();
        }

        private void buttonred_Click(object sender, EventArgs e)
        {
            namecof[i] = "Red lime Soda";
            info();
        }

        private void buttonhon_Click(object sender, EventArgs e)
        {
            namecof[i] = "Honey lime Soda";
            info();
        }
      
        private void button23_Click(object sender, EventArgs e)
        {
           

           
           


        }

        private void buttones_Click(object sender, EventArgs e)
        {
            namecof[i] = "Esspresso";
            info();
        }

    }
}
