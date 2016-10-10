using System;

namespace FormacionPOO
{
    public class Coche
    {
        #region Campos (Estado)
        private string _color;
        private int _velocidad;
        private string _estado;
        private string _matricula;
        private int _numeroRuedas;
        private int _numeroPuertas;
        private Motor _motor;
        private string _tipoTerreno;
        #endregion

        #region Propiedades (Estado)
        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int Velocidad
        {
            get
            {
                return _velocidad;
            }
        }

        /// <summary>
        /// Valores: Parado, Arrancado, En movimiento.
        /// </summary>
        public string Estado
        {
            get
            {
                return _estado;
            }
        }

        public string Matricula
        {
            get
            {
                return _matricula;
            }
        }

        public int NumeroRuedas
        {
            get
            {
                return _numeroRuedas;
            }
        }

        public int NumeroPuertas { get; set; }
        public Motor Motor { get; set; }
        public string TipoTerreno { get; set; }
        #endregion

        #region Métodos (Comportamiento)
        public void Matricular(string matricula) 
        {
            this._matricula = matricula;
        }

        public void Arrancar() 
        {
            if (this._estado == "Parado")
            {
                this._estado = "Arrancado";
            }
        }

        public void Parar()
        {
            if (this._estado == "Arrancado")
            {
                this._estado = "Parado";
            }
        }

        public void Acelerar(int _velocidad) 
        {
            if (this._estado == "Parado")
            {
                throw new Exception("El vehículo está parado. Arráncalo.");
            }

            if (this._estado != "En movimiento")
            {
                this._estado = "En movimiento";
            }

            this._velocidad = this._velocidad + _velocidad;
        }

        public void Frenar(int velocidad)
        {
            if (this._estado == "Parado" || this._estado == "Arrancado")
            {
                throw new Exception("El vehículo no está en movimiento. No se puede frenar.");
            }

            if (velocidad > this._velocidad)
            {
                this._velocidad = 0;
                this._estado = "Arrancado";
            }
            else
            {
                this._velocidad = this._velocidad - velocidad;

                if (this._velocidad < 0)
                {
                    this._velocidad = 0;
                    this._estado = "Arrancado";
                }
            }
        }
        #endregion


        // Constructores
        public Coche()
        {
            this._numeroRuedas = 4;
            this._motor = new Motor();
        }

        public Coche(string color, string marca, string modelo, int numeroPuertas, Motor motor)
        {
            _numeroRuedas = 4;
            _velocidad = 0;
            _estado = "Parado";
            _color = color;
            Marca = marca;
            Modelo = modelo;
            _numeroPuertas = numeroPuertas;
            _motor = motor;
        }

        // Destructor
        ~Coche()
        {
            _velocidad = 0;
        }
    }
}
