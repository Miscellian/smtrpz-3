using SMTRPZ_3.Enums;
using System;

namespace SMTRPZ_3.Model
{
    public class Team
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public SportLevel Level { get; set; }
    }
}
