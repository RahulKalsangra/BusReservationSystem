using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Project02;
namespace UnitTests
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void BusSer_TestCase()
        {
            DLL obj = new DLL();
            busdetials busobj = new busdetials();
            bsl ch = obj.Bus_Deserialize(busobj, "C:/Users/Rahul Kalsangra/source/repos/Project02/bus.xml");
          //  busobj.busname = "Ajanata Travels";
            Assert.AreEqual(ch.buslist[0].busname,"Ajanata Travels");    
        }
        [TestCase]
        public void mydata_Testcase()
        {
            DLL obj = new DLL();
            BLL globj = new BLL();
            gl temp = obj.My_Deserialize(globj, "C:/Users/Rahul Kalsangra/source/repos/Project02/data.xml");
            Assert.AreEqual(temp.temp[0].Name, "rr");
        }
        [TestCase]
        public void tic_test()
        {
            DLL obj = new DLL();
            bookuser bobj = new bookuser();
            tickets ch = obj.ticket_Deserialize( "C:/Users/Rahul Kalsangra/source/repos/Project02/tickets.xml",bobj);
            Assert.AreEqual(ch.contactlist[0].BusName, "Ajanata Travels");   
                 

        }
    }
}
