using FormacionPOO.Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormacionPOO.Practica
{
    public interface IVehiculoAcuatico : IVehiculo
    {
        bool TieneVelas { get; set; }
        double PesoAncla { get; set; }
        bool Navegando { get; }

    }
}
