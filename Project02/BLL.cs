using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project02
{
    [Serializable]
    [XmlRoot("Tickets")]
    public class tickets
    {
        [XmlElement("Contacts")]
        public List<bookuser> contactlist;
        public tickets()
        {
            contactlist = new List<bookuser>();
        }

    }
    public class bookuser
    {
        tickets tobj = new tickets();


        [XmlElement("Name")]
        public string Customername;
        [XmlElement("BusName")]
        public string BusName;
        [XmlElement("From")]
        public string From;
        [XmlElement("To")]
        public string to;

        [XmlElement("Contact")]
        public string number;

        [XmlElement("Date")]
        public string Date;

        [XmlElement("Seat")]
        public int seat;
        [XmlElement("Fare")]
        public int fare;
        [XmlElement("Departure")]
        public string dep;

        public void sendcontact_details(string path, bookuser bobj)
        {

            tobj.contactlist.Add(bobj);
            DLL obj = new DLL();
            obj.contact_Serialize(path, tobj);
        }
        public tickets get_details(string path,bookuser Obj)
        {
            DLL obj = new DLL();
            return obj.ticket_Deserialize( path,Obj);

        }

    }







    [XmlRoot("BusDetails")]
    public class bsl
    {
        [XmlElement("Bus")]
        public List<busdetials> buslist;
        public  bsl()
        {
            buslist = new List<busdetials>();
        }
    }
    
    public class busdetials
    {
        bsl buslistobj = new bsl();
        
        [XmlElement("Name")]
        public string busname;
        [XmlElement("Fare")]
        public int fare;
        [XmlElement("Departure")]
        public string departure;
        [XmlElement("From")]
        public string from;
        [XmlElement("To")]
        public string to;
        [XmlElement("Seat")]
        public int seatcount;

        DLL obj = new DLL();
        public void  sendbus_details(string path,busdetials bobj)
        {

            buslistobj.buslist.Add(bobj);
            DLL obj = new DLL();
            obj.Bus_Serialize(path, buslistobj);
        }
        public bsl getbus_detials(string path,busdetials Obj)
        {
            DLL obj = new DLL();
            return obj.Bus_Deserialize( Obj,path);
        }
    }
    [XmlRoot("Users_Details")]
    public class gl
    {
        [XmlElement("User")]
        public List<BLL> temp;
        public gl()
        {

            temp = new List<BLL>();
        }
       
    }
    public class BLL
    {
        DLL dobj = new DLL();
        gl globj = new gl();
        [XmlElement("Name")]
        public string Name;
        [XmlElement("Email")]
        public string Email;
       
        

        [XmlElement("Password")]
        public string Password;
        [XmlElement("Confirm_Password")]
        public string Confirm_Password;
        [XmlElement("Number")]
        public string Number;
        public bool send_details(BLL obj,string file)
        {
            
                if (String.IsNullOrEmpty(obj.Name) || String.IsNullOrEmpty(obj.Email) || String.IsNullOrEmpty(obj.Password) || String.IsNullOrEmpty(obj.Confirm_Password) || String.IsNullOrEmpty(obj.Number))
                {
                
                
                
                return false; 
                }
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(obj.Email);
                if (!(match.Success))
                {
                    
                    
                    return false;
                }
                if (!(Regex.Match(obj.Number, @"^[0-9]{10}").Success))
                {
                   
                    return false;
                }
                if(obj.Confirm_Password!=obj.Password)
                {
             
                return false;
                }
               
           
            globj.temp.Add(obj);
                dobj.My_Serialize(globj, file);

            return true;
            
        }

         public gl get_details(BLL obj,string file)
        {
            DLL dobj = new DLL();
             
            
            gl  t = dobj.My_Deserialize(obj, file);
            return t;
        }

    }
}
