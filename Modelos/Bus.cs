using Modelos.Interfaces;

namespace Modelos
{
    public class Bus : IModeloBase
    {
        public int Id { get; set; }
        public string Brand  { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }
        public string Color { get; set; }
        public DateTime Year { get; set; }
        public int? IdConductor { get; set; }
        public int? Idroute { get; set; }
        public bool availability { get; set; }
    }
}
