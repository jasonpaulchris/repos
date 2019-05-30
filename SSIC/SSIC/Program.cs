using System;
using System.Collections.Generic;

class Program
{
    static IEnumerable<Dictionary<string, string>> Users = new List<Dictionary<string, string>>
{
new Dictionary<string, string>
{
["username"] = "BeerBaron",
["firstname"] = "Homer",
["lastname"] = "Simpson",
["password"] = "mrburnsstinks"
},
new Dictionary<string, string>
{
["username"] = "Margie",
["firstname"] = "Marge",
["lastname"] = "Simpson",
["password"] = "bartlisamaggie"
},
new Dictionary<string, string>
{
["username"] = "Elbarto",
["firstname"] = "Bart",
["lastname"] = "Simpson",
["password"] = "PRINCIPALSKINNERSTINKS"
},
new Dictionary<string, string>
{
["username"] = "Bookworm",
["firstname"] = "Lisa",
["lastname"] = "Simpson",
["password"] = "IFoundMyPerspicacity"
},
new Dictionary<string, string>
{
["username"] = "LeftyNed",
["firstname"] = "Ned",
["lastname"] = "Flanders",
["password"] = "Passwordarino"
},
new Dictionary<string, string>
{
["username"] = "DuffFan",
["firstname"] = "Barney",
["lastname"] = "Gumble",
["password"] = "iforgotmypasswordhelp"
},
};
    static void Main(string[] args)
    {
        foreach (var user in GetFamilyMemberNames(Users, "Simpson"))
            Console.WriteLine(String.Join(" ", user.Values));
        Console.ReadKey(); // Pause to read output
    }

    static IEnumerable<Dictionary<string, string>>
GetFamilyMemberNames(IEnumerable<Dictionary<string, string>> users, string familyName)
    {

        IEnumerable<Dictionary<string, string>> fullName = new List<Dictionary<string, string>>(users);

        foreach (var user in fullName)
        {
            if (!user.ContainsValue(familyName))
            {
                user.Remove("username");
                user.Remove("password");
                user.Remove("firstname");
                user.Remove("lastname");
                // user.Clear();
            }
            else
            {

                user.Remove("username");
                user.Remove("password");
            }
        }

        return fullName;


    }
};




