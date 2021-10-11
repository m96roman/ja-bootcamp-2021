using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LiveCoding9
{
    public class User
    {
        public string Nickname { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public string Password { get; set; }

        public string PasswordHash => ""; // do something;

        public int Age { get; set; }

        public override string ToString()
            => (Nickname, Password, Age).ToString();
    }
}
