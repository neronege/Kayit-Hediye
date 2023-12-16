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
    public partial class UserEnter : Form
    {
        
        public UserEnter()
        {
            InitializeComponent();

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Database.users.Count; i++)
            {
                if (Database.users[i].UserName == textUsername.Text && Database.users[i].Password == textPassword.Text)
                {
                    MessageBox.Show("Giriş Başarılı");

                    Form1 form = new Form1();
                    form.Show();

                }
                else
                {
                    MessageBox.Show("Hata", "Kullanıcı Adı ya da Şifre Hatalı",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void UserEnter_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Enabled = false;
            
        }
    }
}
