using VitoriaMariaStudio.Domain.Entities;

namespace VitoriaMariaStudio.Application.Contracts.Roles
{
    public interface IRoleService
    {
        bool Add(Role entity);

        bool Delete(Role entity);

        Role Update(Role entity);

        Role GetOne(long id);

        List<Role> GetAll();
    }
}