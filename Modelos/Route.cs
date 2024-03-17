using Modelos.Interfaces;

namespace Modelos
{
    public class Route : IModeloBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? IdConductor { get; set; }
        public int? IdBus { get; set; }
        public bool availability { get; set; }
    }
}
