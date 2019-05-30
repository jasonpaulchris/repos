using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

class User
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}
class Program
{
    static void Main()
    {
        ListViewItem[] userList;
        bool success = GetUsersByGroup("Administrators", out userList);
        if (success)
            foreach (var item in userList)
                Console.WriteLine(((User)item.Tag).Name);
        Console.WriteLine("(Press ENTER to continue)");
        Console.ReadLine(); // Pause to read output
    }
    static bool GetUsersByGroup(string group_name, out ListViewItem[] userList)
    {
        bool success = false;
        SqlConnection sqlConnection1 = new SqlConnection(
        @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SkylineDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = @"
select *
from Users
inner join
GroupMembership on Users.ID = GroupMembership.User_ID
inner join
Groups on Groups.ID = GroupMemberShip.Group_ID
where Groups.Name = '" + group_name + "';";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = sqlConnection1;
        sqlConnection1.Open();
        reader = cmd.ExecuteReader();
        ListViewItem user = new List<ListViewItem>();
        while (reader.Read())
        {
            var u = new User();
            u.ID = reader.GetInt32(0);
            u.Username = reader.GetString(1);
            u.Name = reader.GetString(2);
            u.Password = reader.GetString(3);
            u.Email = reader.GetString(4);
            var item = new ListViewItem();
            item.Tag = u;
            user.Add(item);
        }
        user = user.ToArray();
        userList = user;
        success = true;
        return success;
    }

    private class SqlConnection
    {
        private string v;

        public SqlConnection(string v)
        {
            this.v = v;
        }
    }
}