
namespace FormacionPOO.Herencia
{
    public interface IVehiculoAereo : IVehiculo
    {
        int MaximaAltitud { get; }
        bool Volando { get; }

        void Aterrizar();
        void Despegar();
    }
}
