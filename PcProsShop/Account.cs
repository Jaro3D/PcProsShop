using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcProsShop
{
    internal class Account
    {
        /*
         * Attributes
         */
        private int id;
        private string fname;
        private string lname;
        private string mail;
        private string password;
        private string city;
        private string street;
        private string zip;
        private bool isAdmin;
         
        /*
         * Setter and Getter
         */
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public string Name
        {
            get { return fname + " " + lname; }
        }

        /*
         * Constructors
         */
        public Account() { }
        public Account(int id, string fname, string lname, string mail, string password, string city, string street, string zip, bool isAdmin)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.mail = mail;
            this.password = password;
            this.city = city;
            this.street = street;
            this.zip = zip;
            this.isAdmin = isAdmin;
        }
        
        /*
         * Constructor with test data
         * Use paramater test with value "Test"
         */
        public Account(String test)
        {
            if (test == "Test")
            {
                this.id = 1;
                this.fname = "Max";
                this.lname = "Mustermann";
                this.mail = "Max.Musterman@test.de";
                this.password = "Musterpassword";
                this.city = "Musterstadt";
                this.street = "Musterstraße";
                this.zip = "69420";
                this.isAdmin = false;
            }

        }

        /*
         * Prints object data to console
         * For Testing Purposes
         */ 
        public void print()
        {
            Console.WriteLine("ID = " + this.id + "\n"
                + "First Name = " + this.fname + "\n"
                + "Last Name = " + this.lname + "\n"
                + "E-mail = " + this.mail + "\n"
                + "Password = " + this.password + "\n"
                + "City = " + this.city + "\n"
                + "Street = " + this.street + "\n"
                + "zip = " + this.zip + "\n"
                + "isAdmin = " + this.isAdmin + "\n");
        }
    }
}
