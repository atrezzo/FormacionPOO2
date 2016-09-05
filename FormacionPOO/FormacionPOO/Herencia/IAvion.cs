using System;

namespace FormacionPOO.Herencia
{
    interface IAvion : IVehiculoAereo
    {
        int NumeroMotores { get; }
        int VelocidadAterrizaje { get; }
        int VelocidadDespegue { get; }
    }
}
