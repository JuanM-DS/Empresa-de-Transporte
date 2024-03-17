using Modelos.Interfaces;

namespace Modelos
{
    public class Conductor : IModeloBase
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string? DNI { get; set; }
        public int? IdBus { get; set; }
        public int? Idroute { get; set; }
        public bool availability { get; set; }
    }
}
