using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Project02
{
    public class DLL
    {

        public void Bus_Serialize(string path,bsl obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(bsl));

            if (!File.Exists(path))
            {
                FileStream read = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None);
                using (read)
                {
                    serializer.Serialize(read, obj);
                    read.Close();
                }
            }
            else
            {

                XDocument doc = XDocument.Load(path);


                var newElement = new XElement("Bus",
                new XElement("Name", obj.buslist[0].busname),
                new XElement("Departure", obj.buslist[0].departure),
                new XElement("From", obj.buslist[0].from),
                new XElement("To", obj.buslist[0].to),
                new XElement("Fare", obj.buslist[0].fare),
                new XElement("Seat", obj.buslist[0].seatcount)
                );
                doc.Element("BusDetails").Add(newElement);
                doc.Save(path);



            }

        }

        public bsl Bus_Deserialize(busdetials Obj, string filePath)
        {
            

            bsl result;
            XmlSerializer serializer = new XmlSerializer(typeof(bsl));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                result = (bsl)serializer.Deserialize(fileStream);

            }


            return result;
        }
        public void My_Serialize(gl Obj,string filePath)
        {

           
            XmlSerializer serializer = new XmlSerializer(typeof(gl));
           
            if (!File.Exists(filePath))
            {
                FileStream read = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.None);
                using (read)
                {
                    serializer.Serialize(read, Obj);
                    read.Close();
                }
            }
            else
            {
              
                XDocument doc = XDocument.Load(filePath);
               
              
                    var newElement = new XElement("User",
                    new XElement("Name", Obj.temp[0].Name),
                    new XElement("Email", Obj.temp[0].Email),
                    new XElement("Password",Obj.temp[0].Password),
                    new XElement("Confirm_Password", Obj.temp[0].Confirm_Password),
                    new XElement("Number", Obj.temp[0].Number)
                    );
                    doc.Element("Users_Details").Add(newElement);
                    doc.Save(filePath);

                

            }
        }
        public gl My_Deserialize(BLL Obj,string filePath)
        {
           
           
            gl result;
            XmlSerializer serializer = new XmlSerializer(typeof(gl));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
               result = (gl)serializer.Deserialize(fileStream);
               
            }


            return result;
        }

       public void contact_Serialize(string path, tickets obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(tickets));

            if (!File.Exists(path))
            {
                FileStream read = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None);
                using (read)
                {
                    serializer.Serialize(read, obj);
                    read.Close();
                }
            }
            else
            {

                XDocument doc = XDocument.Load(path);


                var newElement = new XElement("Contacts",
                new XElement("Name", obj.contactlist[0].Customername),
                new XElement("BusName", obj.contactlist[0].BusName),
                new XElement("From", obj.contactlist[0].From),
                new XElement("To", obj.contactlist[0].to),
                new XElement("Contact", obj.contactlist[0].number),
                new XElement("Date", obj.contactlist[0].Date),
                new XElement("Seat", obj.contactlist[0].seat),
                new XElement("Fare", obj.contactlist[0].fare),
                new XElement("Departure", obj.contactlist[0].dep)
                );
                doc.Element("Tickets").Add(newElement);
                doc.Save(path);



            }

       



    }

        public tickets ticket_Deserialize(string path, bookuser obj)
        {
            tickets result;
            XmlSerializer serializer = new XmlSerializer(typeof(tickets));
            if (File.Exists(path))
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    result = (tickets)serializer.Deserialize(fileStream);

                }


                return result;
            }
            else
            {
                result = null;
                return result;
            }


        }




    }
}
