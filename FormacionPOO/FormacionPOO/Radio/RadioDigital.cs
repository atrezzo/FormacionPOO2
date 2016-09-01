using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormacionPOO
{
    /// <summary>
    /// Radio que permite colocar el volumen por teclado, en vez de subir/bajar de uno en uno.
    /// </summary>
    public class RadioDigital : Radio
    {
        #region Métodos (Comportamiento)

        public override void SubirVolumen()
        {
            SubirVolumen(1, true);
        }

        public void SubirVolumen(int volumen)
        {
            SubirVolumen(volumen, true);
        }

        public void SubirVolumen(int volumen, bool VerPantalla)
        {
            ModificarVolumen(volumen, VerPantalla);

        }

        public override void BajarVolumen()
        {
            BajarVolumen(1, true);
        }

        public void BajarVolumen(int volumen)
        {
            BajarVolumen(volumen, true);
        }

        public void BajarVolumen(int volumen, bool VerPantalla)
        {
            ModificarVolumen((-1) * volumen, VerPantalla);

        }

        #endregion

        #region private methods

        private void ModificarVolumen(int volumen, bool VerPantalla)
        {
            _volumen = _volumen + volumen;
            
            if (_volumen < 0) 
                volumen = 0;
            else if (_volumen > 10) 
                volumen = 10;

            _circuteria.CambiarVolumen(_volumen);
            if (VerPantalla) VerPantallaLcd();
        }

        #endregion
    }
}
