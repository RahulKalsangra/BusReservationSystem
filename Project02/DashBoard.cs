using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Project02
{
    public partial class DashBoard : UserControl
    {
        public string busnamecheck,senddate;
        Bitmap Background, BackgroundTemp;
        DataGridViewButtonColumn col = new DataGridViewButtonColumn();
        public DashBoard()
        {
            InitializeComponent();
            initialize();
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


        
        private void initialize()

        {

            SetStyle(ControlStyles.UserPaint, true);

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            SetStyle(ControlStyles.DoubleBuffer, true);

            string AppPath = Application.StartupPath;

            BackgroundTemp = new Bitmap("C:\\Users\\Rahul Kalsangra\\Desktop\\Icon\\bg.jpg");

            Background = new Bitmap(BackgroundTemp, BackgroundTemp.Width, BackgroundTemp.Height);

        }

        protected override void OnPaint(PaintEventArgs e)

        {

            Graphics dc = e.Graphics;

            dc.DrawImageUnscaled(Background, 0, 0);

            base.OnPaint(e);

        }









        private void DashBoard_Load(object sender, EventArgs e)
        {

            mydropdown1();
            mydropdown2();
            
            Date.MinDate = DateTime.Now;
            this.Dock = DockStyle.Fill;
            this.fromInput.ForeColor = Color.Blue;
            this.ToInput.ForeColor = Color.Blue;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Visible = false;
           
            col.Text = "Book";
            col.FlatStyle = FlatStyle.Standard;
            col.CellTemplate.Style.BackColor = Color.Honeydew;
            col.HeaderText = "Book";
            col.Name = "Book";
            col.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(col);
            dataGridView1.CellClick += DataGridView1_CellClick;
            col.Visible = false;
           

        }
       
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string chfrom = fromInput.Text;
            string chto = ToInput.Text;
            if(fromInput.SelectedIndex<0 || ToInput.SelectedIndex<0)
            {
                MessageBox.Show("Field Can't Be Empty");
                return;
            }


            bookuser bookobj = new bookuser();
            tickets tobj = bookobj.get_details(Resources.Resource1.FilePathTickets, bookobj);

           

            
            dataGridView1.Visible = true;
           
            var dateAndTime = Date.Value;
            var date = dateAndTime.Date;
            senddate = Convert.ToString(date.ToString("dd/MM/yyyy"));
            

            
            
            bookuser bobj = new bookuser();
            tickets obj = bobj.get_details(Resources.Resource1.FilePathTickets, bobj);

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Departure", typeof(string));
            dt.Columns.Add("Fare", typeof(int));
            dt.Columns.Add("Seat", typeof(int));
            
            
                busdetials myobj = new busdetials();
                bsl tempobj = myobj.getbus_detials(Resources.Resource1.FilePathBus, myobj);
                for (var i = 0; i < tempobj.buslist.Count; i++)
                {
                    if (tempobj.buslist[i].from == fromInput.Text && tempobj.buslist[i].to == ToInput.Text)
                    {
                    int tempseat = 0;
                    if (obj != null)
                    {
                        for (int j = 0; j < obj.contactlist.Count; j++)
                        {
                          if(obj.contactlist[j].BusName==tempobj.buslist[i].busname && obj.contactlist[j].From==tempobj.buslist[i].from && obj.contactlist[j].to==tempobj.buslist[i].to && obj.contactlist[j].Date==senddate)
                            {
                                tempseat = obj.contactlist[j].seat;
                            }
                        }
                    }
                        DataRow dr = dt.NewRow();
                        dr["Name"] = tempobj.buslist[i].busname;
                        dr["Departure"] = tempobj.buslist[i].departure;
                        dr["Fare"] = tempobj.buslist[i].fare;
                        dr["Seat"] = tempobj.buslist[i].seatcount-tempseat;
                        dt.Rows.Add(dr);
                    }


                }



           
            

            dataGridView1.DataSource = dt;
          
            col.Visible = true;
            dataGridView1.Columns["Name"].DisplayIndex = 0;
            dataGridView1.Columns["Departure"].DisplayIndex = 1;
            dataGridView1.Columns["Fare"].DisplayIndex = 2;
            dataGridView1.Columns["Seat"].DisplayIndex = 3;
            dataGridView1.Columns["Book"].DisplayIndex = 4;
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
               
                UserDetials obj = new UserDetials();
                string busname = row.Cells[1].Value.ToString();
                string value = row.Cells[4].Value.ToString();
                string from = fromInput.Text;
                string to = ToInput.Text;
                string departure = row.Cells[2].Value.ToString();
                int fare = Convert.ToInt32(row.Cells[3].Value);
                obj.payment(value,e.RowIndex, busname, from, to,senddate,departure,fare);

                
                this.Hide();
                this.Parent.Controls.Add(obj);
                

            }
        }

        
        public void mydropdown1()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:/Users/Rahul Kalsangra/source/repos/Project02/cities.xml");
            XmlNodeList city = xDoc.GetElementsByTagName("City");
            for (int i = 0; i < city.Count; i++)
            {
               fromInput.Items.Add(city[i].Attributes["name"].InnerText);
            }
            fromInput.SelectedIndex = 0;
        }
        public void mydropdown2()
        {
           
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:/Users/Rahul Kalsangra/source/repos/Project02/cities.xml");
            XmlNodeList city = xDoc.GetElementsByTagName("City");
            for (int i = 0; i < city.Count; i++)
            {
                
                ToInput.Items.Add(city[i].Attributes["name"].InnerText);
            }
            ToInput.SelectedIndex = 1;

        }

        private void ToInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginUserControl obj = new LoginUserControl();
            this.Hide();
            this.Parent.Controls.Add(obj);
        }

        private void fromInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToInput.Items.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:/Users/Rahul Kalsangra/source/repos/Project02/cities.xml");
            XmlNodeList city = xDoc.GetElementsByTagName("City");
            for (int i = 0; i < city.Count; i++)
            {
                if(city[i].Attributes["name"].InnerText!=fromInput.SelectedItem.ToString())
                ToInput.Items.Add(city[i].Attributes["name"].InnerText);
            }
            ToInput.SelectedIndex = 0;

        }
    }
}
