/*Triangulo equilatero invertido.*/

using System;

class Triangulo{
	static void Main(){
		try{
			int asterisco=1, altura;
			
			do{
				Console.Write("Introduce una altura: ");
				altura=Convert.ToInt32(Console.ReadLine());
				if(altura<=1)
					Console.WriteLine("Error: altura minima 2");
			}while(altura<=1);
			
			for(int contador=1;contador<altura;contador++)
				asterisco+=2;
			
			for(int piso=1;piso<=altura;piso++){
				for(int espacios=piso;espacios>1;espacios--)
					Console.Write(" ");
				for(int ancho=1;ancho<=asterisco;ancho++)
					Console.Write("*");
				Console.WriteLine();
				asterisco-=2;
			}
		}
		catch(Exception error){
			Console.WriteLine("Error: "+error.Message);
		}
	}
}
