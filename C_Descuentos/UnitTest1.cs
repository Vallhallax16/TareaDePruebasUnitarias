using Pruebas_Unitarias;

namespace C_Descuentos
{
    public class Test
    {
        private CCalculo_De_Descuento des;

        public Test()
        {
            des = new CCalculo_De_Descuento();
        }

        [Test]
        public void PU_CalculoDescuento()
        {
            int descuento = 20;
            decimal esperado = 0.0M; // Ajusta el valor esperado seg�n la l�gica de tu c�digo
            decimal obtenido = Convert.ToDecimal(des.Calculo_Dinero_Descontado(descuento));
            Assert.IsTrue(esperado == obtenido);
        }
    }
}