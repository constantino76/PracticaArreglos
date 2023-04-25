using System;

public class Ordenar
{
	public Ordenar()
	{
		//ordena ascendente

	
	}
	public void convertirarreglo(int[,] arreglo) {
		        
		int[] ar = new int[arreglo.Length];
		int j = 0;
		foreach (int elemento in arreglo)
        {
            ar[j]=elemento;
			j++;
		
		}
		int []a=Ordenaarray(ar);
		llenarArreglo(arreglo, a);
	}

	public int[] Ordenaarray(int[] arr)
	{



		int aux= arr[0];
		     for(int pasada=0;pasada <arr.Length;pasada++)
			for (int j = 1; j < arr.Length; j++)
			{

			if (arr[j-1] >arr[j]) {
				aux=arr[j];
				arr[j] = arr[j - 1];
				arr[j - 1] =aux;
				
              
			}


			}
	
		return arr;

	}

	public void llenarArreglo(int[,] m, int[] a) {
	int k=0;
		for (int j =0;j<m.GetLength(0);j++ ) {
			for (int i=0;i<m.GetLength(1);i++) {
				m[j, i] = a[k];
				k++;
			}
		
		
		}
	
	}
}
