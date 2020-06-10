using SMTRPZ_3.Enums;
using System;

namespace SMTRPZ_3.Dto
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public SportLevel Level { get; set; }
    }
}
