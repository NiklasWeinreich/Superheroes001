namespace Superheroes001.Entities
{
    public class Superman
    {
        [Key]
        public int Id { get; set; }
        public string RealName { get; set; }
        public string SuperPower { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public DateTime DebutYear { get; set; }
    }
}
