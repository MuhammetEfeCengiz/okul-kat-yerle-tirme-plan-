using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okul_kat_yerleştirme_planı
{
    public partial class Form1 : Form
    {
        string  yazı2,sınıflar1;
        int list1,sayı1=1,sayı2=2;
        
        public Form1()

        {
            
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void kat_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void goster_btn_Click(object sender, EventArgs e)
        {
            int yazı1 = 0;

            if (kat_txt.Text != "")
            {
                yazı1 = Convert.ToInt32(kat_txt.Text);
            }
            
           

            if (yazı1==1)
            {
                liste.Items.Add("9/A");
                liste.Items.Add("9/B");
                liste.Items.Add("9/C");
                liste.Items.Add("9/D");
            }
            else if (yazı1 == 2)
            {
                liste.Items.Add("10/A");
                liste.Items.Add("10/B");
                liste.Items.Add("10/C");
                liste.Items.Add("10/D");
            }
            else if (yazı1 == 3)
            {
                liste.Items.Add("11/A");
                liste.Items.Add("11/B");
                liste.Items.Add("11/C");
                liste.Items.Add("11/D");

            }
            else if (yazı1 == 4)
            {
                liste.Items.Add("12/A");
                liste.Items.Add("12/B");
                liste.Items.Add("12/C");
                liste.Items.Add("12/D");

            }
            else
            {
                MessageBox.Show("lutfen tekrar deneyin");
            }
        }

        private void liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
