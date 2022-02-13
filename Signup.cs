using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btn_signuplogin_Click(object sender, EventArgs e)
        {

            Form_adminpanel fap = new Form_adminpanel();
            fap.Show();
            this.Hide();

        }
        
        private void btn_signup_Click(object sender, EventArgs e)
        {
            string file = @"login.txt";


            List<string> lines = new List<string>();

            lines = File.ReadAllLines(file).ToList();

            string username = tb_usernamesignup.Text;
            string password = tb_passwordsignup.Text;

            string admin = "" + username + ":" + password + "";

            lines.Add(admin);


            if (tb_passwordsignup != tb_confirmpassword)
            {

                if (!isEmailRegistered(tb_usernamesignup.Text))
                {
                    File.WriteAllLines(file, lines);
                }
                else {
                    MessageBox.Show("This username is registered"); // username olmali deyil email olmalidir cunki username unique olmur email unique olur sora ozun emai leliyersen formlarin adini

                }
            }
   
            else
            {
                MessageBox.Show("Paswords aren't equals");
            }

            Form_adminpanel fap = new Form_adminpanel();
            fap.Show();
            this.Hide(); 

        }

        public Boolean isEmailRegistered(string email) {

            string file = @"login.txt";


            List<string> lines = new List<string>();

            lines = File.ReadAllLines(file).ToList();

            foreach (string line in lines)
            {

                string[] items = line.Split(':');

                if (items[0] == email)
                {

                    return true;

                }
                else {

                    return false;
                
                }


            }
            return false;


        }
    }
}
