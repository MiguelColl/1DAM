/*Triangulo equilatero invertido.*/

using System;

class Triangulo{
	static void Main(){
		int asterisco=1, altura=1;
		bool error;
										
		do{		
			error=false;	
			try{
				Console.Write("Introduce una altura(minimo 2): ");
				altura=Convert.ToInt32(Console.ReadLine());
				if(altura<=1)
					Console.WriteLine("Error: altura minima 2");
			}
			catch(Exception errorEncontrado){
				Console.WriteLine("Error: "+errorEncontrado.Message);
				error=true;
			}
		}while((altura<=1)&&(error==true));
					
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
}
