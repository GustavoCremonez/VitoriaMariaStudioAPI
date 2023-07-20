using VitoriaMariaStudio.DTO.Jobs;
using VitoriaMariaStudio.DTO.Persons;
using VitoriaMariaStudio.DTO.Professionals;

namespace VitoriaMariaStudio.DTO.Schedulings
{
    public class SchedulingDto
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public PersonDto Client { get; set; }

        public ProfessionalDto ProfessionalDto { get; set; }

        public IEnumerable<JobDto> JobsDto { get; set; }
    }
}