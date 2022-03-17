using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class Bank
    {
        public int BankId{ get; set; }
        public string BankName { get; set; }

        public string BankCode{ get; set; }

        public string Branch { get; set; }
    }
}
