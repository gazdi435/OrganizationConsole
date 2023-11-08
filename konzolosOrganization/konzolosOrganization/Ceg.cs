using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolosOrganization
{
    internal class Ceg
    {
        int index;
        string organizationID;
        string name;
        string website;
        string country;
        string description;
        int founded;
        string industry;
        int employees;

        public int Index { get => index; set => index = value; }
        public string OrganizationID { get => organizationID; set => organizationID = value; }
        public string Name { get => name; set => name = value; }
        public string Website { get => website; set => website = value; }
        public string Country { get => country; set => country = value; }
        public string Description { get => description; set => description = value; }
        public int Founded { get => founded; set => founded = value; }
        public string Industry { get => industry; set => industry = value; }
        public int Employees { get => employees; set => employees = value; }

        public Ceg(int index, string organizationID, string name, string website, string country, string description, int founded, string industry, int employees)
        {
            this.index = index;
            this.organizationID = organizationID;
            this.name = name;
            this.website = website;
            this.country = country;
            this.description = description;
            this.founded = founded;
            this.industry = industry;
            this.employees = employees;
        }
        public Ceg(string sor)
        {
            this.index = Convert.ToInt32(sor.Split(";")[0]);
            this.organizationID = sor.Split(";")[1];
            this.name = sor.Split(";")[2];
            this.website = sor.Split(";")[3];
            this.country = sor.Split(";")[4];
            this.description = sor.Split(";")[5];
            this.founded = Convert.ToInt32(sor.Split(";")[6]);
            this.industry = sor.Split(";")[7];
            this.employees = Convert.ToInt32(sor.Split(";")[8]);
        }
    }
}
