namespace VitoriaMariaStudio.Domain.Entities
{
    public class Scheduling
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public Person Client { get; set; }

        public IEnumerable<Job> Jobs { get; set; }

        public Scheduling()
        { }

        public Scheduling(long id, DateTime date, Person client, IEnumerable<Job> jobs)
        {
            Id = id;
            Date = date;
            Client = client;
            Jobs = jobs;
        }
    }
}