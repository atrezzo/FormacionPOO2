using System;

namespace FormacionPOO.Herencia
{
    public class Coche : Vehiculo, ICoche
    {
        #region Campos
        private int _numeroRuedas;
        private int _numeroPuertas;
        private Motor _motor;
        private string _tipoTerreno;
        #endregion

        #region Propiedades
        

        public int NumeroRuedas
        {
            get
            {
                return _numeroRuedas;
            }
        }

        public int NumeroPuertas { get; set; }
        public Motor Motor  { get; set; }
        public string TipoTerreno { get; set; }
        #endregion

        #region Métodos


        public override void Frenar(int velocidad)
        {
            if (base._estado == "Parado" || base._estado == "Arrancado")
            {
                throw new Exception("El vehículo no está en movimiento. No se puede frenar.");
            }

            if (velocidad > base._velocidad)
            {
                base._velocidad = 0;
                base._estado = "Arrancado";
            }
            else
            {
                base._velocidad = base._velocidad - velocidad;

                if (base._velocidad < 0)
                {
                    base._velocidad = 0;
                    base._estado = "Arrancado";
                }
            }
        }
        #endregion

        #region Constructores
        public Coche() 
        {
            this._numeroRuedas = 4;
            this._motor = new Motor();
        }

        public Coche(string color, string marca, string modelo, int numeroPuertas, Motor motor, string tipoTerreno)
            : base(color, marca, modelo)
        {
            this._numeroRuedas = 4;
            this._numeroPuertas = numeroPuertas;
            this._motor = motor;
            this._tipoTerreno = tipoTerreno;
        }
        #endregion
    }
}
