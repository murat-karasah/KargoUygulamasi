using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoUygulamasi
{
    public partial class Form1 : Form
    {
        public int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label4.Left += 3;
            if (label4.Left == 258)
            {
                listBox1.Items.Add("Kargo Transever Şubesine girdi" + sayac);
                listBox1.Items.Add("Kargo Dağıtıma Çıktı" + sayac);


            }
          else  if (label4.Left >= 554)
            {
                listBox1.Items.Add("Kargo Teslim Edildi" + sayac);
                timer1.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kargo Şubeden çıktı" + sayac);

            timer1.Start();
           
           
        }
    }
}
