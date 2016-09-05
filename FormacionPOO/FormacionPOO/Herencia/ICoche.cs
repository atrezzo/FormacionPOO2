using System;

namespace FormacionPOO.Herencia
{
    interface ICoche : IVehiculoTerrestre
    {
        string Matricula { get; }
        Motor Motor { get; }
        int NumeroPuertas { get; }
        int NumeroRuedas { get; }

        void Matricular(string matricula);
    }
}
