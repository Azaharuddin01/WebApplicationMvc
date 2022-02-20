using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMvc.Models
{
    public class Customer
    {
        internal object location;

        public int Id { get; set; }

        public string Name { get; set; }

        public long Phone_No { get; set; }

        public string Email_id { get; set; }
        public location Location { get; set; }
    }
}
