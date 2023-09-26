using Pruebas_Unitarias;

namespace PruebaParaInteresCompuesto
{
	public class Tests
	{
		CInteres_Compuesto cic;

        [SetUp]
		public void Setup()
		{
			cic = new CInteres_Compuesto(5);
		}

		[Test]
		public void PU_Normal()
		{
			decimal mult = 1.10M;
			decimal monto = 50M;
			decimal esperado = 30.5255M;
			decimal obtenido = cic.Obtener_Ganancias(mult,monto);
			Assert.AreEqual(esperado, obtenido);
		}

		[Test]
		public void PU_DePrecision()
		{
			decimal mult = 1.39M;
			decimal monto = 133.59M;
			decimal esperado = 559.593076333941M;
			decimal obtenido = cic.Obtener_Ganancias(mult,monto);
			Assert.AreEqual(esperado,obtenido);
		}

		[Test]
		public void PU_NormalF2()
		{
			decimal mult = 1.20M;
			decimal a_obtener = 248.832M;
			decimal esperado = 100M;
			decimal obtenido = cic.Obtener_Monto_Inicial(mult,a_obtener);
			Assert.AreEqual(esperado ,obtenido);
		}

		[Test]
		public void PU_DePrecisionF2()
		{
			decimal mult = 1.73M;
			decimal a_obtener = 1573.1934325M;
			decimal esperado = 101.52M;
			decimal obtenido = cic.Obtener_Monto_Inicial(mult,a_obtener);
			Assert.AreEqual (esperado ,obtenido);	
		}
	}
}