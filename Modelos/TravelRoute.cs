using Modelos.Interfaces;

namespace Modelos
{
    public class TravelRoute : IModeloBase
    {
        public int Id { get; set; }
        public int IdConductor { get; set; }
        public int IdRoute { get; set; }
        public int IdBus { get; set; }
    }
}
