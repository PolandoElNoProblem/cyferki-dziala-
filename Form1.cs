using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
git remote add origin https://github.com/PolandoElNoProblem/cyferki-dziala-.git
git branch -M main
git push -u origin main
namespace cyferki
{
    public partial class Form1 : Form
    {
        int los;
        int nrProby;
        int iloProb;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible= checkBox1.Checked;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            if (radioButton1.Checked)
            
                los = rand.Next(0, 1000);
            
            else if(radioButton2.Checked)
            {
                los = rand.Next(0, 100); 
            }
            else if(radioButton3.Checked)
               {
                los = rand.Next(0, 10);
            }
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int twojaLiczba = -1;
          
            try
            {
                twojaLiczba = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bład: " + ex.Message);
                textBox2.Clear();
                return;
            }
                if (twojaLiczba == los)
            {
                iloProb = 0;
                nrProby++;
                textBox1.Text = Convert.ToString(nrProby);
                HighScore.Text = Convert.ToString(nrProby);
                button2.Enabled = true;
                panel2.BackColor = Color.Green;
                button1.Enabled = false;
            }
            else if(twojaLiczba > los)
            {
                iloProb++;
                textBox3.Text = Convert.ToString(iloProb);
                label1.Text = "Szukana jest mniejsza";
            }
            else if (twojaLiczba < los)
            {
                iloProb++;
                textBox3.Text = Convert.ToString(iloProb);
                label1.Text = "Szukana jest większa";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
