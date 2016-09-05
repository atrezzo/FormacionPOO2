using System;

namespace FormacionPOO.Herencia
{
    public abstract class Vehiculo : IVehiculo
    {
        #region Campos
        private string _color;
        private string _marca;
        private string _modelo;
        protected int _velocidad;
        protected string _estado;
        protected IRadio _radio;
        #endregion

        #region Propiedades
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

        public IRadio Radio { get; set; }

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
        #endregion

        #region Métodos
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

        public void Acelerar(int velocidad) 
        {
            if (this._estado == "Parado")
            {
                throw new Exception("El vehículo está parado. Arráncalo.");
            }

            if (this._estado != "En movimiento")
            {
                this._estado = "En movimiento";
            }

            this._velocidad = this._velocidad + velocidad;
        }

        public abstract void Frenar(int velocidad);

        #endregion

        #region Constructores y Destructores
        // Constructor sin parámetros.
        public Vehiculo() 
        {
            _velocidad = 0;
            _estado = "Parado";
            _radio = new Radio(); //new RadioSecuencial(); --> Cumplen misma interfaz.
        }

        // Constructor con parámetros.
        public Vehiculo(string color, string marca, string modelo)
        {
            _velocidad = 0;
            _estado = "Parado";
            _radio = new Radio(); //new RadioSecuencial(); --> Cumplen misma interfaz.
            _color = color;
            _marca = marca;
            _modelo = modelo;
        }

        // Destructor.
        ~Vehiculo()
        {
            _velocidad = 0;
        }
        #endregion
    }
}
