using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogic
{
    public class User
    {
       public string _id { get; set; }
       public string name { get; set; }
       public string email { get; set; }
       public string phone { get; set; }
       public string token { get; set; }
       public List<Chip> MyChips { get; set; }
        public User()
        {

        }
    }
}
