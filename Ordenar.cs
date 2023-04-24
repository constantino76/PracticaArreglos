using System;

public class Class1
{
	public Class1()
	{
		//ordena ascendente

		public [,] Ordenaarray(int[,] arr) {

			
			int aux = 0
			for (int j = 0j < arr.GetLength(0); j++) {
				for (int i = 1; i < arr.GetLength(1); i++) {

					if (arr[j,i - 1] > arr[j,i]) {
						aux= arr[j, i - 1]; 
						arr[j,i-1]=arr[j,i];
                        arr[j,i]=aux
					}
				
				
				}
			
			
			}
		
		}
	}
}
