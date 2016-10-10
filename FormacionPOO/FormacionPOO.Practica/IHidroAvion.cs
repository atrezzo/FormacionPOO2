using FormacionPOO.Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormacionPOO.Practica
{
    public enum Tipo
    {
        HidroCanoa,
        HidroFlotador,
    }

    public interface IHidroAvion : IVehiculoAcuatico, IVehiculoAereo
    {
        Tipo TipoHidroavion { get; set; }
        void Amerizar();
    }
}
