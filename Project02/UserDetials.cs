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
    public partial class UserDetials : UserControl
    {
        public int seats;
        public int f = 0;
        public int sendfare;

        public string busname,from,to,my_date,depa;
        bookuser obj ;
        public UserDetials()
        {
            InitializeComponent();
            obj = new bookuser();
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
        private void UserDetials_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel4.Dock = DockStyle.Fill;
           

        }
        
        public void payment(string s,int value,string bn,string f,string t,string d,string dep,int fa)
        {
            
            busname = bn;
            from = f;
            to = t;
            my_date = d;
            seats = Convert.ToInt32(s);
            sendfare = fa;
            depa = dep;
           // MessageBox.Show(Convert.ToString(seat));
        }

        private void Passcountinput_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(Passcountinput.Text))
            {
                errorProvider1.SetError(Passcountinput, "Required Field");
                f = 0;
            }
            else if (seats- Convert.ToInt32(Passcountinput.Text) < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(Passcountinput, "Only"+seats+"Available");
                f = 0;
            }
            else
            {
                errorProvider1.SetError(Passcountinput, "");
                f = 1;
                errorProvider1.Clear();
            }
        }

        private void Ageinput_Click(object sender, EventArgs e)
        {
            int num = 1;
            if (String.IsNullOrEmpty(Ageinput.Text) || (!int.TryParse(Ageinput.Text, out num)))
            {
                f = 0;
                errorProvider2.SetError(Ageinput, "Invalid Age");
            }
            else
            {
                errorProvider2.SetError(Ageinput, "");
                f = 1;
                errorProvider2.Clear();
            }
        }

        private void NameINput_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameINput.Text))
            {
                f = 0;
                errorProvider3.SetError(NameINput, "Field Can't Be Empty");
            }
            else
            {
                errorProvider3.SetError(NameINput, "");
                f = 1;
                errorProvider3.Clear();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBoard ud = new DashBoard();
            this.Hide();
            this.Parent.Controls.Add(ud);
        }

        private void Emailinput_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Emailinput.Text);
            if (!(match.Success))
            {
                errorProvider4.SetError(Emailinput, "Email Invalid");
            }
            else
            {
                errorProvider4.SetError(Emailinput, "");
                errorProvider4.Clear();
            }
        }

        private void Contactinput_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!(Regex.Match(Contactinput.Text, @"^[0-9]{10}").Success))
            {
                errorProvider5.SetError(Contactinput, "Contact Invalid");
            }
            else
            {
                errorProvider5.SetError(Contactinput, "");
                errorProvider5.Clear();
            }
        }

        public  void FinalPay_Click(object sender, EventArgs e)
        {
            if (f == 1)
            {
                
                    obj.Customername = NameINput.Text;
                    obj.BusName = busname;
                    obj.From = from;
                    obj.to = to;
                    obj.number = Contactinput.Text;
                    obj.Date = my_date;
                obj.fare = sendfare;
                obj.dep = depa;
                    obj.seat = Convert.ToInt32(Passcountinput.Text);
                    obj.sendcontact_details(Resources.Resource1.FilePathTickets, obj);
                
                DashBoard ud = new DashBoard();
                this.Hide();
                this.Parent.Controls.Add(ud);

            }
            else
            {
                if (String.IsNullOrEmpty(Passcountinput.Text))
                {
                    errorProvider1.SetError(Passcountinput, "Name Field Can't Be Empty");
                   
                }
                else if (Convert.ToInt32(Passcountinput.Text) - seats < 0)
                {
                    errorProvider1.SetError(Passcountinput, "Only" + seats + "Available");
                   
                }
                else
                {
                    errorProvider1.SetError(Passcountinput, "");
                    errorProvider1.Clear();
                }

                int num = 1;
                if (String.IsNullOrEmpty(Ageinput.Text) || (!int.TryParse(Ageinput.Text, out num)))
                {
                    
                    errorProvider2.SetError(Ageinput, "Invalid Age");
                }
                else
                {
                    errorProvider2.SetError(Ageinput, "");
                    
                }
                if (!(Regex.Match(Contactinput.Text, @"^[0-9]{10}").Success))
                {
                    errorProvider5.SetError(Contactinput, "Contact Invalid");
                }
                else
                {
                    errorProvider5.SetError(Contactinput, "");
                    errorProvider5.Clear();
                }

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(Emailinput.Text);
                if (!(match.Success))
                {
                    errorProvider4.SetError(Emailinput, "Email Invalid");
                }
                else
                {
                    errorProvider4.SetError(Emailinput, "");
                    errorProvider4.Clear();
                }
                if (String.IsNullOrEmpty(NameINput.Text))
                {
                    
                    errorProvider3.SetError(NameINput, "Field Can't Be Empty");
                }
                else
                {
                    errorProvider3.SetError(NameINput, "");
                    errorProvider3.Clear();
                    
                }

                
            }

        }
    }
}
