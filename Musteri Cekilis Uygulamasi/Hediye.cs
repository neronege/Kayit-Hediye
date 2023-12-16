using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musteri_Cekilis_Uygulamasi
{
    public partial class Hediye : Form
    {
        public Hediye()
        {
            InitializeComponent();
            HediyeBelirle();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
            Form anaform = Application.OpenForms["Form1"];
            Panel solpanel = (Panel)anaform.Controls["HediyePanel"];
           
            foreach (Control item in solpanel.Controls)
            {
                if (item is PictureBox)
                {
                    item.Visible = false;
                }
            }
        }
        private void HediyeBelirle()
        {
            int i = 0;
            Random rnd = new Random();
            i = rnd.Next(0, 5);
            if(i == 0)
            {
              label1.Text = Database.Urun[0].First;
            }
           else if (i == 1)
            {
                label1.Text = Database.Urun[0].Second;
            }
            else if (i == 3)
            {
                label1.Text = Database.Urun[0].Third;
            }
            else if (i == 4)
            {
                label1.Text = Database.Urun[0].Fourth;
            }
            else if (i == 5)
            {
                label1.Text = Database.Urun[0].Fiveth;
            }
        }

    }
}
