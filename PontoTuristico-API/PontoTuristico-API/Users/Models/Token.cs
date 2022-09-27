using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Models
{
    public class Token
    {
        public string Value { get; set; }

        public Token(string value)
        {
            Value = value;
        }
    }
}
