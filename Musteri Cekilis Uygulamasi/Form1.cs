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
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
           

        }

        public void Form1_Load(object sender, EventArgs e)
        {
         
          UserEnter userEnter = new UserEnter();
           userEnter.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            UserEnter userEnter = new UserEnter();
            userEnter.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Id = new Guid();
            customer.Name = textbox_name.Text;
            customer.Surname =textbox_Surname.Text;
            customer.TCKimlikNo = textbox_tc.Text;
            customer.PhoneNumber= textBoxPhone.Text;
            customer.Job = textBoxJob.Text;
            customer.Gender = comboBoxGender.ValueMember;
            customer.Email = textBoxEmail.Text;
            customer.Birthday = BirthTime.Value;

            if (customer.Name != null && customer.Surname != null && customer.TCKimlikNo != null && customer.PhoneNumber != null)
            {
                Database.customers.Add(customer);
                var result = MessageBox.Show("Başarılı", "Kayıt Tamalandı. Yeni Kayıt yapmak istiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    foreach (Control item in groupBoxMusteriBilgileri.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = string.Empty;

                        }
                        else if(item is CheckBox)
                        {
                            item.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    for(int i = 0; i < 20; i++)
                    {
                        PictureBox picture = new PictureBox();
                        picture.Name = "picture" + i.ToString();
                        picture.Width = 75;
                        picture.Height = 80;
                        picture.Tag = true;
                        picture.Image = Image.FromFile(@"C:\\Users\\musta\\Desktop\\C #\\Musteri Cekilis Uygulamasi\\Musteri Cekilis Uygulamasi\\Gift.png");
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture.Click += new System.EventHandler(this.pictureBox1_Click);
                        HediyePanel.Controls.Add(picture);
                    }
                }

              
               
               


            }
            else
            {
                MessageBox.Show("Hata","Kayıt Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hediye hediye = new Hediye();
            hediye.ShowDialog();
            
        }
    }
}
