using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Mail;

namespace AdminPanel
{
    public partial class Formmain : Form
    {

        DataTable table = new DataTable("table");
        int index;
        private static string file = @"users.txt";
        private int ID = 0;

        public Formmain()
        {
            InitializeComponent();

            foreach (string line in getLines())
            {
                string[] items = line.Split(':');

                table.Rows.Add(items[1], items[2], items[3], items[4]);

            }

            ID = getLines().Count;

        }




        private List<String> getLines() {

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(file).ToList();

            return lines;

        }

        private void addUser(int id , string firstName , string lastName, string Email , string birthDate) {

            List<string> lines = new List<string>();

            string user = "" +id +":"+ firstName + ":" + lastName + ":" + Email + ":" + birthDate + "";

            lines.Add(user);

            File.WriteAllLines(file, lines);

        }

        private void Formmain_Load(object sender, EventArgs e)
        {
            table.Columns.Add("First Name", Type.GetType("System.String"));
            table.Columns.Add("Last Name", Type.GetType("System.String"));
            table.Columns.Add("Mail", Type.GetType("System.String"));
            table.Columns.Add("Birthday", Type.GetType("System.String"));
            dgv_data.DataSource = table;
            // dgv - DataGridView

        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgv_data.Rows[index];
            tb_firstname.Text = row.Cells[0].Value.ToString();
            tb_lastname.Text = row.Cells[1].Value.ToString();
            tb_mail.Text = row.Cells[2].Value.ToString();
            tb_bday.Text = row.Cells[3].Value.ToString();
        }

       
        private void btn_insert_Click_1(object sender, EventArgs e)

        {
            string email = tb_mail.Text;
            string fistName = tb_firstname.Text;
            string lastName = tb_lastname.Text;
            string birthDate  = tb_bday.Text;


            if (email == "" || fistName == "" || lastName == "" || birthDate == "")
            {

                if (IsValidEmail(email))
                {
                    ++ID;

                    table.Rows.Add(tb_firstname.Text, tb_lastname.Text, tb_mail.Text, tb_bday.Text);

                    addUser(ID , tb_firstname.Text, tb_lastname.Text, tb_mail.Text, tb_bday.Text);

                    tb_firstname.Text = String.Empty;
                    tb_lastname.Text = String.Empty;
                    tb_mail.Text = String.Empty;
                    tb_bday.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Email is incorrect. Please enter valid email!");


                }

            }
            else
            {
                MessageBox.Show("From can not be empty!!");


            }


        }

        private static bool IsValidEmail(string email)
        {

            try
            {
                MailAddress m = new MailAddress(email);


                return true;
            }
            catch (FormatException)
            {

                MessageBox.Show("Email is incorrect. Please enter valid email!");
                return false;


            }

        }
        private void btn_new_Click_1(object sender, EventArgs e)
        {
            tb_firstname.Text = String.Empty;
            tb_lastname.Text = String.Empty;
            tb_mail.Text = String.Empty;
            tb_bday.Text = String.Empty;
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (index != 0)
            {

                DataGridViewRow newdata = dgv_data.Rows[index];
                newdata.Cells[0].Value = tb_firstname.Text;
                newdata.Cells[1].Value = tb_lastname.Text;
                newdata.Cells[2].Value = tb_mail.Text;
                newdata.Cells[3].Value = tb_bday.Text;

                List<String> newLines = new List<string>();

                foreach (string line in getLines())
                {


                    string[] items = line.Split(':');

                    string indexStr = "" + index;

                    if (!items[0].Equals(indexStr))
                    {

                        newLines.Add(line);

                    }

                }

             string user = "" +index +":"+ tb_firstname.Text + ":" + tb_lastname.Text + ":" + tb_mail.Text + ":" + tb_bday.Text + "";


                newLines.Add(user);

                File.WriteAllText(file, string.Empty);
                File.WriteAllLines(file, newLines);
                index = 0;

            }
            else{
                MessageBox.Show("Please don't enter properties from form!!");
            }

            

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            index = dgv_data.CurrentCell.RowIndex;
            dgv_data.Rows.RemoveAt(index);


            List<String> newLines = new List<string>();

            foreach (string line in getLines())
            {


                string[] items = line.Split(':');

                string indexStr = "" + index;

                if (!items[0].Equals(indexStr))
                {

                    newLines.Add(line);

                }

            }

            File.WriteAllText(file, string.Empty);
            File.WriteAllLines(file, newLines);

            index = 0;
        }



    }
}
