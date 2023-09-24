﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unitarias
{
	public class CVerificadora_de_Lineas_Horizontales
	{
		//Acepta coordenadas del tipo X,Y enteras
		//Los valores deben ser contiguos
		// [0] = X1
		// [1] = Y1
		// [2] = X2
		// [3] = Y2
		public int[] Vertices = new int[4];

		public CVerificadora_de_Lineas_Horizontales(int[] Coordenadas_vertices) 
		{
			Vertices = Coordenadas_vertices;
		}

		public bool Verificadora()
		{
			if (Vertices[1] == Vertices[3] && Vertices[0] != Vertices[1])
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
