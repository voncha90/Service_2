using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Service_2
{
    public class ServiceBClass

    {

        public string GetServiceBClassData()
        {
            string result = string.Empty;
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
    {
        "User",
        "Admin"
    }
            };

            result = JsonConvert.SerializeObject(account, Formatting.Indented);



            JObject staff = new JObject();
            staff.Add(new JProperty("Name", "Jack"));
            staff.Add(new JProperty("Age", 33));
            staff.Add(new JProperty("Department", "Personnel Department"));
            staff.Add(new JProperty("Leader", new JObject(new JProperty("Name", "Tom"), new JProperty("Age", 44), new JProperty("Department", "Personnel Department"))));
            Console.WriteLine(staff.ToString());

            return result;

        }
    }

    public class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}
