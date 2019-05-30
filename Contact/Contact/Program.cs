using System;

namespace Contact
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }

        public virtual string GetDetails()
        {
            return FirstName + " " + LastName + "  (" + EmailAddress + "," + PhoneNo + ")";
        }
    }

    public class BusinessContact : Contact
    {
        public string CompanyName { get; set; }
        public string Designation { get; set; }

        public override string GetDetails()
        {
            return FirstName + " " + LastName + "  (" + CompanyName + "," + Designation + ")";

        }
    }

    public class ProfessionalContact : Contact
    {
        public string Service { get; set; }
        public string Address { get; set; }
        public string Timing { get; set; }

        public override string GetDetails()
        {
            return FirstName + " " + LastName + "  (" + Service + "," + Timing + ")";

        }
    }

    public class PersonalContact : Contact
    {
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public override string GetDetails()
        {
            return FirstName + " " + LastName + "  (" + BirthDate.ToString("dd-MMM-yyyy") + ")";
        }
    }

    public static void ShowDetails(Contact c)
    {
        string details = c.GetDetails();
        Console.WriteLine(details);
        Console.ReadLine();
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
}
