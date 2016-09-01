using System;

namespace FormacionPOO.Herencia
{
    public interface ICoche : IVehiculo
    {
        string Matricula { get; }
        Motor Motor { get; }
        int NumeroPuertas { get; }
        int NumeroRuedas { get; }

        void Matricular(string matricula);
    }
}
