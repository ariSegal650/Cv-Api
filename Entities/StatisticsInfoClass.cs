namespace Api.Entities
{
    public class StatisticsInfoClass
    {
        public DateTime loginDate { get; set; } = DateTime.UtcNow;

        public Guid id { get; set; }= Guid.NewGuid();
        public int? clicks { get; set; }

        public string? city { get; set; }

        public bool? download { get; set; }

    }
}