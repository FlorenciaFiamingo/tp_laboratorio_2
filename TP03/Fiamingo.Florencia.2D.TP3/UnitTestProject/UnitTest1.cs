using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Archivos;
using Clases_Instanciables;
using EntidadesAbstractas;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaException()
        {
            Alumno alumno = new Alumno(2, "Florencia", "Gonzalez", "1234567", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
        }

        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestSinProfesorException()
        {
            Universidad universidad = new Universidad();

            universidad += Universidad.EClases.Legislacion;
        }

        [TestMethod]
        public void TestValorNuloNombre()
        {
            Alumno alumno = new Alumno(2, "Florencia", "Ibañez", "4555288", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Assert.IsNotNull(alumno);

        }

      
    }
}
