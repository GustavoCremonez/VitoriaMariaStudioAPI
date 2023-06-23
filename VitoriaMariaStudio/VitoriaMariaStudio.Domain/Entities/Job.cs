namespace VitoriaMariaStudio.Domain.Entities
{
    public class Job
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public Job()
        { }

        public Job(long id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}