using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    public partial class LoginUserControl : UserControl
    {
        busdetials busobj = new busdetials();
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public void Registerbtn_Click(object sender, EventArgs e)
        {

            Register reg = new Register();
            this.Hide();
            this.Parent.Controls.Add(reg);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            this.Dock = DockStyle.Fill;
            busleft.BackColor = Color.Transparent;
            midicon.BackColor = Color.Transparent;
            rightbus.BackColor = Color.Transparent;
            NameLabel.BackColor = Color.Transparent;
            PasswordInput.UseSystemPasswordChar = true;
            emaillogo.BackColor = Color.Transparent;
            passwordlogo.BackColor = Color.Transparent;
            CloseloginBtn.BackColor = Color.Transparent;
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
             if(EmailInput.Text=="Admin" && PasswordInput.Text=="123")
            {
                
                busobj.busname = "Ajanata Travels";
                busobj.departure = "12:20";
                busobj.fare = 1200;
                busobj.seatcount = 20;
                busobj.from = "Indore";
                busobj.to = "Bangalore";
                busobj.sendbus_details(Resources.Resource1.FilePathBus, busobj);
                MessageBox.Show("Admin");
                return;
            }
            BLL obj1 = new BLL();
            gl cat = obj1.get_details(obj1, Resources.Resource1.FilePathData);

            // MessageBox.Show(Convert.ToString(cat.Count));
            string pass="";
            
            for(int i=0;i<cat.temp.Count;i++)
            {
                if(cat.temp[i].Email==EmailInput.Text)
                {
                    
                    pass = cat.temp[i].Password;
                }
            }
            if(pass==PasswordInput.Text && pass!="")
            {
                
                        DashBoard db = new DashBoard();
                        this.Hide();
                        this.Parent.Controls.Add(db);
                
            }
            else
            {
               
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(EmailInput.Text);
                if (!(match.Success))
                {
                    errorProvider1.SetError(EmailInput, "Invalid Email");
                   
                }

                else
                {
                    errorProvider1.SetError(EmailInput, "");
                   
                }
                if (String.IsNullOrEmpty(PasswordInput.Text))
                {
                    errorProvider2.SetError(PasswordInput, "Enter Password ");
                   
                }

                else
                {
                    errorProvider2.SetError(PasswordInput, "");
                    
                }

               
            }




        }

        private void CloseloginBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void EmailInput_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(EmailInput.Text);
            if (!(match.Success))
            {
                errorProvider1.SetError(EmailInput, "Invalid Email");

            }
            
           else
            {
                errorProvider1.SetError(EmailInput, "");
                errorProvider1.Clear();
            }
        }

        private void PasswordInput_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordInput.Text))
            {
                errorProvider2.SetError(PasswordInput, "Enter Password ");

            }

            else
            {
                errorProvider2.SetError(PasswordInput, "");
                errorProvider2.Clear();
            }


        }
    }
}
