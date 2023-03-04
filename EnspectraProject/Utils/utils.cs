using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EnspectraProject
{
    public static class utils
    {
        public static bool validate_name(string name)
        {
            return !String.IsNullOrWhiteSpace(name) && (name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)));
        }

        public static bool validate_id(String id)
        {
            return !String.IsNullOrWhiteSpace(id) && id.All(c => char.IsDigit(c) || c == '-');
        }
    }
}