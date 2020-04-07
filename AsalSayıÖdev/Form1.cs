using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayıÖdev
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

        private void button1AsalSayi_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 2; i <= 1000; i++)
            {
                int kontrol = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j ==0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol ==1)
                {
                    listBoxAsal.Items.Add(i + " asal değildir!");
                }
                else
                {
                    listBoxAsal.Items.Add(i + " asaldır.");
                    sayac++;
                }
            }
        }
    }
}
