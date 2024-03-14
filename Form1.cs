using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoMartApplication
{
    public partial class Form1 : Form
    {
        DbConnect db=new DbConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // cmbBox.SelectedIndex = 0;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbBox.SelectedIndex >0) {

                    if(username.Text!=String.Empty && password.Text!=String.Empty)
                    {
                        //Login code

                        db.getDbConnection();
                        db.openDbConnection();

                        MessageBox.Show("connected to db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(username.Text!=String.Empty && password.Text == String.Empty) 
                    {
                        MessageBox.Show("please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(username.Text==String.Empty &&password.Text!=String.Empty)
                    {
                        MessageBox.Show("please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        MessageBox.Show("please enter Username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("please select any role","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            cmbBox.SelectedIndex = 0;
            username.Clear();
            password.Clear();
            
        }
    }
}
