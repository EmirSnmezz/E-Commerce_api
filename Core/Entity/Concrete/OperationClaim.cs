using Entity.Abstract;

namespace Core.Entity.Concrete
{
    public class OperationClaim : IEntity
    {
        int Id { get; set; }
        public string Name { get; set; }
    }
}
