using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdminPanel
{
    public partial class Form_adminpanel : Form
    {
        

        public Form_adminpanel()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();

           
            if(signup.isEmailRegistered(tb_usernamelogin.Text))
            {

                string file = @"login.txt";


                List<string> lines = new List<string>();

                lines = File.ReadAllLines(file).ToList();
                string password = "";


                foreach (string line in lines)
                {


                    string[] items = line.Split(':');

                    if (items[0] == tb_usernamelogin.Text) {

                        password = items[1];
                    
                    }

                }

                if ( password == tb_passwordlogin.Text)
                {


                    Formmain fm = new Formmain();
                    fm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter password true!");


                }
            }
            else
            {
                MessageBox.Show("This email is not registered"); 
                    
                    
                    }
        }

        private void btn_loginsignup_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }
    }

}
