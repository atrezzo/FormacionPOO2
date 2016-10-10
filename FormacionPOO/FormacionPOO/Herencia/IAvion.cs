using System;

namespace FormacionPOO.Herencia
{
    public interface IAvion : IVehiculoAereo
    {
        int NumeroMotores { get; }
        int VelocidadAterrizaje { get; }
        int VelocidadDespegue { get; }
    }
}
