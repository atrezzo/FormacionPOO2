
namespace FormacionPOO.Herencia
{
    interface IVehiculoAereo : IVehiculo
    {
        int MaximaAltitud { get; }
        bool Volando { get; }

        void Aterrizar();
        void Despegar();
    }
}
