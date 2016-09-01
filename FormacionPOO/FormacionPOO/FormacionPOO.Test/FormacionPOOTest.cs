using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormacionPOO.Herencia;
using System.Diagnostics;

namespace FormacionPOO.Test
{
    [TestClass]
    public class FormacionPOOTest
    {
        [TestMethod]
        public void FormacionPOOTest_Ejemplo1() 
        {
            // Crear coche 1: turismo.
            var _motorTurismo = new Motor
            {
                Cilindrada = 1500,
                Combustible = "DIESEL",
                Potencia = 70
            };

            var _turismo = new Coche("CELESTE", "SEAT", "PANDA", 1, _motorTurismo);

            // Crear coche 2: deportivo.
            var _motorDeportivo = new Motor
            {
                Cilindrada = 3000,
                Combustible = "GASOLINA",
                Potencia = 300
            };

            var _deportivo = new Coche("ROJO", "FERRARI", "TESTARROSA", 2, _motorDeportivo);

            Assert.IsNotNull(_turismo);
        }

        
        /// <summary>
        /// Diapositiva 
        /// </summary>
        [TestMethod]
        public void FormacionPOOTest_Ejemplo2_POO()
        {
            // Crear radio POO.
            IRadio _radio = new Radio();

           

            // Recorrido turismo.
            _radio.VerPantallaLcd();
            _radio.SubirVolumen();
            _radio.SubirVolumen();
            _radio.SubirVolumen();
            _radio.BajarVolumen();
            _radio.BuscarNuevaEmisora();
            _radio.SubirVolumen();
            _radio.BuscarNuevaEmisora();
            _radio.BajarVolumen();
            _radio.BajarVolumen();
            _radio.BajarVolumen();

            Assert.IsTrue(true);
        }

        /// <summary>
        /// Abstracción/Encapsulamiento
        /// </summary>
        [TestMethod]
        public void FormacionPOOTest_Ejemplo2_Secuencial()
        {
            // Crear radio secuencial.
            IRadio _radio = new RadioSecuencial();



            // Recorrido turismo.
            _radio.VerPantallaLcd();
            _radio.SubirVolumen();
            _radio.SubirVolumen();
            _radio.SubirVolumen();
            _radio.BajarVolumen();
            _radio.BuscarNuevaEmisora();
            _radio.SubirVolumen();
            _radio.BuscarNuevaEmisora();
            _radio.BajarVolumen();
            _radio.BajarVolumen();
            _radio.BajarVolumen();

            Assert.IsTrue(true);
        }

        /// <summary>
        /// Poliformismo
        /// </summary>
        [TestMethod]
        public void FormacionPOOTest_Ejemplo3()
        {
            // Crear coche: turismo.
            var _motorTurismo = new Motor
            {
                Cilindrada = 1500,
                Combustible = "DIESEL",
                Potencia = 70
            };

            // Crear coche.
            FormacionPOO.Herencia.Coche _turismo = new FormacionPOO.Herencia.Coche("CELESTE", "SEAT", "PANDA", 1, _motorTurismo);

            // Crear avión.
            FormacionPOO.Herencia.Avion _avion = new FormacionPOO.Herencia.Avion("BLANCO", "BOEING", "747", 4, 13000, 220, 200);


            _avion.Arrancar();
            _avion.Acelerar(220); //Vamos a 220 kmh - Podemos despegar.
            _avion.Despegar(); 
            _avion.Acelerar(680); //Vamos a 900kmH - volando.



            try
            {
                _avion.Frenar(100);  //Vamos a 800kmh - NO se puede aterrizar!!
                _avion.Aterrizar(); //

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); //El avión no puede aterrizar. Los parámetros de aterrizaje no son correctos."
            }

            _avion.Frenar(600); //800kmh - 600kmh = 200Kmh. Ya estamos en velocidad de aterrizaje!
            _avion.Aterrizar();

            _avion.Frenar(110);
            _avion.Frenar(90); //Parados.
            
            //OK

            _turismo.Arrancar();
            _turismo.Acelerar(220);
            _turismo.Frenar(100);
            _turismo.Frenar(120);
            //OK
           

            Assert.IsTrue(true);
        }

    }
}
