using NUnit.Framework;
using Pruebas_Unitarias;
using System.Drawing;
using Xunit;

namespace C_Prubeas_LineasH
{
    public class Test
    {
        //public int[] Vertices = { 1, 5, 8, 5 };
        CVerificadora_de_Lineas_Horizontales cvlh;

        [SetUp]
        public void setup(int[] Vertices)
        {
            cvlh = new CVerificadora_de_Lineas_Horizontales(Vertices);
        }

        [Test]
        public void PU_LineasHorizontales()
        {
            int[] Vertices = { 1, 5, 8, 5 };
            CVerificadora_de_Lineas_Horizontales cvlh = new(Vertices);
            var RectaHor = cvlh.Verificadora();
            //var Inclinacion = cvlh.ContieneInclinacion();
            NUnit.Framework.Assert.AreEqual(true, RectaHor);
        }

        [Test]
        public void PU_LineasInclinadas()
        {
            int[] Vertices = { 1, 2, 8, 5 };
            //var RectaHor = cvlh.Verificadora();
            var Inclinacion = cvlh.ContieneInclinacion();
            NUnit.Framework.Assert.AreEqual(true, Inclinacion);
        }
    }
}