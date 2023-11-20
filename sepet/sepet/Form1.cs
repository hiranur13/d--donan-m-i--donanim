using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sepet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == "Hoparlör"
                    ||listBox1.Items[i].ToString() == "Mikrofon" 
                    ||listBox1.Items[i].ToString() == "Klavye" 
                    || listBox1.Items[i].ToString() == "Monitör")
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
                else
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
            }
        }
    }
}
