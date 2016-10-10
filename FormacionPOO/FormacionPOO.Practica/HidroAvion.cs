using FormacionPOO.Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormacionPOO.Practica
{
    public class HidroAvion : FormacionPOO.Herencia.Avion, IHidroAvion
    {
        #region private fields

        private Tipo _tipoHidroavion;
        private bool _tieneVelas;
        private double _presoancla;
        private bool _navegando;


        #endregion

        #region public properties

        public Tipo TipoHidroavion
        {
            get
            {
                return _tipoHidroavion;
            }
            set
            {
                _tipoHidroavion = value;
            }
        }

        public bool TieneVelas
        {
            get
            {
                return _tieneVelas;
            }
            set
            {
                _tieneVelas = value;
            }
        }

        public double PesoAncla
        {
            get
            {
                return _presoancla;
            }
            set
            {
                _presoancla = value;
            }
        }

        public bool Navegando
        {
            get { return _navegando; }
        }

        #endregion


        public HidroAvion(string color, string marca, string modelo, Tipo tipoHidroavion, int numeroMotores, int maximaAltitud, int velocidadDespegue, int velocidadAterrizaje)
            : base(color, marca, modelo, numeroMotores, maximaAltitud, velocidadDespegue, velocidadAterrizaje)
        {
            TieneVelas = false;
            TipoHidroavion = tipoHidroavion;
        }

        public void Amerizar()
        {

            if (this._estado == "En movimiento" && this._velocidad == this._velocidadAterrizaje && this._volando == true && this._navegando == false)
            {
                this._volando = false;
                this._navegando = true;
            }
            else
            {
                throw new Exception("El avión no puede amerizar. Los parámetros de aterrizaje no son correctos.");
            }
        }

       

        
    }
}
