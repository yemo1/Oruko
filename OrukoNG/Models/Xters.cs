using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrukoNG.Models
{
    public class Xters
    {
        public List<string> All()
        {

            List<string> letters = new List<string>(new string[]
            {"A", "B", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O","P", "R", "S", "T", "U",  "W",  "Y"});
            return letters.ToList();
        }
    }
}