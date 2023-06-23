namespace VitoriaMariaStudio.Domain.Entities
{
    public class Person
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public long RoleId { get; set; }

        public Role Role { get; set; }

        public Person()
        {
        }

        public Person(long id, string name, string email, string telefone, string address, long roleId, Role role)
        {
            Id = id;
            Name = name;
            Email = email;
            Telefone = telefone;
            Address = address;
            RoleId = roleId;
            Role = role;
        }
    }
}