using System;

namespace Pizzaria.Business.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
