using VitoriaMariaStudio.DTO.Categories;
using VitoriaMariaStudio.DTO.Schedulings;

namespace VitoriaMariaStudio.DTO.Jobs
{
    public class JobDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public TimeSpan ExpectedTime { get; set; }

        public CategoryDto CategoryDto { get; set; }

        public IEnumerable<SchedulingDto> Schedulings { get; set; }
    }
}