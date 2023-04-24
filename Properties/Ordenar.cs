using System;

public class Ordenar
{
	public Ordenar()
	{
		//ordena ascendente

	
	}


	public int[,] Ordenaarray(int[,] arr)
	{



		int aux = arr[0, 0];
		for (int pasada = 0; pasada < arr.Length/2; pasada++) { 
			for (int j = 0; j < arr.GetLength(0); j++)
			{
			
				for (int i = 1; i < arr.GetLength(1); i++)
				{
					//////int[,] arreglo = { { 8, 12, 11, 34, 56, 67 }, { 9, 3, 2, 1, 22, 78 } };
					if (arr[j,i-1]>arr[j,i])
					{      aux = arr[j, i];	
						arr[j, i] = arr[j, i-1];
						arr[j, i - 1] = aux;
						
					}
					

				}


			}
	}
		return arr;

	}
}
