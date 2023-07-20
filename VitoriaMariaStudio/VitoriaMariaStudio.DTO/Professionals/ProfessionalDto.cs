using VitoriaMariaStudio.DTO.Roles;

namespace VitoriaMariaStudio.DTO.Professionals
{
    public class ProfessionalDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public RoleDto RoleDto { get; set; }
    }
}