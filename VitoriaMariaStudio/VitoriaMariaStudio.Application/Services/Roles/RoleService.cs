using VitoriaMariaStudio.Application.Contracts.Roles;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Contracts;

namespace VitoriaMariaStudio.Application.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly IGenericRepository _genericRepository;

        public RoleService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(Role entity)
        {
            return _genericRepository.Add(entity);
        }

        public bool Delete(Role entity)
        {
            return _genericRepository.Delete(entity);
        }

        public List<Role> GetAll()
        {
            return _genericRepository.GetAll<Role>();
        }

        public Role GetOne(long id)
        {
            return _genericRepository.GetOne<Role>(id);
        }

        public Role Update(Role entity)
        {
            _genericRepository.Update(entity);

            return _genericRepository.GetOne<Role>(entity.Id);
        }
    }
}