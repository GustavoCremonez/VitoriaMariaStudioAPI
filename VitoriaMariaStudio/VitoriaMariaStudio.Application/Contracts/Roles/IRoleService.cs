using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Roles;

namespace VitoriaMariaStudio.Application.Contracts.Roles
{
    public interface IRoleService
    {
        bool Add(RoleDto dto);

        bool Delete(long id);

        RoleDto Update(RoleDto dto);

        RoleDto GetOne(long id);

        List<RoleDto> GetAll();
    }
}