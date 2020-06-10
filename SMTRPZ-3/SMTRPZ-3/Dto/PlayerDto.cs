using SMTRPZ_3.Enums;

namespace SMTRPZ_3.Dto
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public SportLevel Level { get; set; }
    }
}
