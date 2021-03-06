﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormacionPOO.Herencia;
using System.Diagnostics;

namespace FormacionPOO.Test
{
    [TestClass]
    public class FormacionPOOTest
    {
        /// <summary>
        /// Clase - Objeto
        /// </summary>
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
            Radio _radio = new Radio();



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
            RadioSecuencial _radio = new RadioSecuencial();



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
        /// polimorfismo
        /// <remarks>
        /// El metodo Frenar() es el metodo que aplica polimorfismo.
        /// </remarks>
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
            FormacionPOO.Herencia.Coche _turismo = new FormacionPOO.Herencia.Coche("CELESTE", "SEAT", "PANDA", 1, _motorTurismo, "CARRETERA");

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

        /// <summary>
        /// polimorfismo
        /// <remarks>
        /// El metodo Frenar() es el metodo que aplica polimorfismo.
        /// </remarks>
        /// </summary>
        [TestMethod]
        public void FormacionPOOTest_Ejemplo4()
        {
            RadioDigital _radioDigital = new RadioDigital();

            _radioDigital.SubirVolumen(5); //5
            _radioDigital.SubirVolumen(); //6
            _radioDigital.BajarVolumen(2, false); //4 + No mostrar por pantalla
            _radioDigital.BajarVolumen(); //3
            _radioDigital.BajarVolumen(3); //0

        }

        /// <summary>
        /// interfaz
        /// <remarks>
        /// Las dos clases tiene el contrato IRadio.
        /// </remarks>
        /// </summary>
        [TestMethod]
        public void FormacionPOOTest_Ejemplo5()
        {
            bool ES_RADIO_POO = true;
            IRadio _radio;

            if (ES_RADIO_POO)
            {
                _radio = new Radio();
            }
            else
            {
                _radio = new RadioSecuencial();
            }

            // Funcionamiento radio.
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
        /// interfaz (aplicación)
        /// <remarks>
        /// Las dos clases tiene el contrato IRadio.
        /// </remarks>
        /// </summary>
        [TestMethod]
        public void FormacionPOOTest_Ejemplo6() 
        {
            bool ES_RADIO_POO = true;
            IRadio _radio;

            if (ES_RADIO_POO)
            {
                _radio = new Radio();
            }
            else
            {
                _radio = new RadioSecuencial();
            }

            // Crear turismo.
            var _motorTurismo = new Motor
            {
                Cilindrada = 1500,
                Combustible = "DIESEL",
                Potencia = 70
            };

            FormacionPOO.Herencia.Coche _turismo = new FormacionPOO.Herencia.Coche("CELESTE", "SEAT", "PANDA", 1, _motorTurismo, "CARRETERA");

            // Utilizar radio del turismo.
            _turismo.Radio.VerPantallaLcd();

            // EJERCICIO: Cambiar la radio del coche.

            Assert.IsTrue(true);
        }

        /// <summary>
        /// interfaz (implementación múltiple)
        /// </summary>
        public void FormacionPOOTest_Ejemplo7() 
        {
            // EJERCICIO: implementar HIDROAVION.

            Assert.IsTrue(true);
        }

        /// <summary>
        /// Modificadores de ámbito
        /// <remarks>
        /// Ejemplos de miembros publicos, privados y protected
        /// </remarks>
        /// </summary>
        [TestMethod]
        public void FormacionPOOTest_Ejemplo8()  
        {
            var _radio = new Radio();
            var _radioDigital = new RadioDigital();

           
            //private 
            //_radio._frecuencia; //-- solo accesible desde class Radio NO accessible desde ningún lado. 
            //protected 
            //_radio._volumen; //-- NO accesible desde fuera de class RadioDigital, pero sí desde class Radio y RadioDigital.
            //public
            _radio.BajarVolumen(); //--  Accessible desde todos los sitios (class Radio, class RadioDigital, y cualquier otro lado, como aquí el test).
            

        } 
    }
}
