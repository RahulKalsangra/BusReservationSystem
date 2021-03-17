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
using Project02;

namespace Project02
{
    [Serializable]

   
    public partial class Register : UserControl
    {

        BLL obj;
        public Register()
        {
            InitializeComponent();
            obj = new BLL();

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle = 0x02000000;
                return handleparam;
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            RPassword.UseSystemPasswordChar = true;
            RCnfmPassword.UseSystemPasswordChar = true;
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            LoginUserControl obj = new LoginUserControl();
            this.Hide();
            this.Parent.Controls.Add(obj);

           
            



        }
        
        public void RegisterBtn_Click(object sender, EventArgs e)
        {
            
            

            obj.Name = RNameInput.Text;
            obj.Email = REmailInput.Text;
            obj.Password = RPassword.Text;
            obj.Confirm_Password = RCnfmPassword.Text;

            obj.Number =RContact.Text;
            int f = 0;

            BLL obj1 = new BLL();
            gl cat = obj1.get_details(obj1, Resources.Resource1.FilePathData);

            for(int i=0;i<cat.temp.Count;i++)
            {
                if(REmailInput.Text==cat.temp[i].Email)
                {
                    f = 1;
                    break;
                }
            }
            bool validate=false;
            if (f == 1)
            {
                MessageBox.Show("Email Already Exists");
            }
            else
            {
                validate = obj.send_details(obj, Resources.Resource1.FilePathData);
            }
            if (validate)
            {
                LoginUserControl obj = new LoginUserControl();
                this.Hide();
                this.Parent.Controls.Add(obj);

                
            }
            
        }

        private void RNameInput_Click(object sender, EventArgs e)
        {
            
            if(RNameInput.Text=="")
            errorProvider1.SetError(RNameInput, "Name Field Can't Be Empty");
            else
            errorProvider1.SetError(RNameInput, "");
        }

        private void REmailInput_Click(object sender, EventArgs e)
        {
            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(REmailInput.Text);
            if (!(match.Success))
            {
                errorProvider2.SetError(REmailInput, "Email Invalid");
            }
            else
            {
                errorProvider2.SetError(REmailInput, "");
            }
        }

        private void RContact_Click(object sender, EventArgs e)
        {
            
            if (!(Regex.Match(RContact.Text, @"^[0-9]{10}").Success))
            {
                errorProvider3.SetError(RContact, "Contact Invalid");
            }
            else
            {
                errorProvider3.SetError(RContact, "");
            }
        }

        private void RCnfmPassword_Click(object sender, EventArgs e)
        {
            
            if (RPassword.Text!= RCnfmPassword.Text)
            {
                errorProvider4.SetError(RCnfmPassword, "Password Mismatch");

            }
            else
                errorProvider4.SetError(RCnfmPassword, "");
        }
    }
}
