using System;

namespace FormacionPOO.Herencia
{
    interface IAvion : IVehiculo
    {
        int MaximaAltitud { get; }
        int NumeroMotores { get; }
        int VelocidadAterrizaje { get; }
        int VelocidadDespegue { get; }
        bool Volando { get; }

        void Aterrizar();
        void Despegar();
    }
}
