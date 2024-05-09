using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StaffApp
{
    public enum Department { Marketing, Sales, Accounts }
    public enum AddressType { Permannt, Postal }

    class Program
    {
        static void Main()
        {
            
            List<Member> members = new List<Member>
            {
            new Member(21, Department.Marketing, "Mark B. Harbour", 6, 20000, null, "973-475-1512", "937-823-2348",
                       new Address(AddressType.Postal, "3971 Ingram Street", "Dayton", "Ohio(OH)", 45402, "USA")),
            new Member(23, Department.Sales, "Charles M Stewart", 6, 22000, 0.03, "740-803-7350", "740-272-9206",
                       new Address(AddressType.Postal, "3483", "Delaware", "Ohio(OH)", 43015, "USA")),
            new Member(24, Department.Sales, "Liz Elbow", 5, 22500, 0.02, "863-474-6774", "305-201-9879",
                       new Address(AddressType.Permannt, "1732 Single Street", "Cambridge", "Massachusetts(MA)", 2141, "USA")),
            new Member(27, Department.Accounts, "Fred L Slowik", 4, 28000, null, "925-469-7343", "818-421-8113",
                       new Address(AddressType.Permannt, "4860 Canis Heights Drive", "Los Angeles", "California(CA)", 90071, "USA")),
            new Member(28, Department.Marketing, "John E Anderson", 4, 27000, null, "305-300-4999", "561-754-9754",
                       new Address(AddressType.Postal, "881 Fincham Road", "Palm Springs", "California(CA)", 92262, "USA")),
            new Member(31, Department.Marketing, "Anthony J Wilkerson", 6, 18000, null, "401-770-0840", "401-309-1510",
                       new Address(AddressType.Permannt, "3020 Oakdale Avenue", "Avon Park", "Florida(FL)", 33825, "USA"))
            };


            CreateXml("staff.xml", members);
        }

        static void CreateXml(string fileName, List<Member> members)
        {
            XElement staffXml = new XElement("Staff",
                from member in members
                select new XElement("Member",
                    new XAttribute("Id", member.Id),
                    new XAttribute("Dept", member.Dept),
                    new XElement("Name", member.Name),
                    new XElement("Grade", member.Grade),
                    new XElement("Salary", member.Salary),
                    member.Bonus != null ? new XElement("Bonus", member.Bonus) : null,
                    new XElement("Phone",
                        new XElement("Home", member.HomePhone),
                        new XElement("Work", member.WorkPhone)
                    ),
                    new XElement("Address",
                        new XElement("Type", member.Address.Type),
                        new XElement("Street", member.Address.Street),
                        new XElement("City", member.Address.City),
                        new XElement("State", member.Address.State),
                        new XElement("Zip", member.Address.Zip),
                        new XElement("Country", member.Address.Country)
                    )
                )
            );

            staffXml.Save(fileName);
        }
    }
}

