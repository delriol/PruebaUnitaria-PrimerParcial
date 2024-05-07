using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using primer_parcial_unit_test_procesador_matematico;


namespace PruebaUnitaria
{
    [TestClass]
    public class PruebaUnitaria
    {
        public class procesadorMatematicoTests
        {
            public void DevolverElMayorEntreDosNumeros()
            {
                //Arrange
                var procesador = new ProcesadorMatematico();
                var primerNumero = 5;
                var segundoNumero = 10;

                //Act
                procesador.CalcularMayor(primerNumero, segundoNumero);
                var resultado = procesador._resultado;

                //Assert - Tiene que devolver el segundo numero
                Assert.AreEqual(segundoNumero, resultado);
            }
            public void Dividendo_ResultadoCorrecto()
            {
                //Arrange
                ProcesadorMatematico procesador = new ProcesadorMatematico();
                int dividendo = 6;
                int divisor = 3;
                int resultadoEsperado = 2;

                //Act
                procesador.Dividir(dividendo, divisor);

                //Assert - El resultado debe ser un 2
                Assert.AreEqual(resultadoEsperado, procesador._resultado);
            }
        }

    }
}
