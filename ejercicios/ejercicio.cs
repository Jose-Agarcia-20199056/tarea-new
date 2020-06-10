using System;
					
public class Program
{
	public static void Main()
	{
		int num;
		
		Console.WriteLine("Escribe el numero");
        num = int.Parse(Console.ReadLine());
		
		if (num>0 ){
			
		Console.WriteLine(num );	
			
	   }	
       
		else{    
	
	       Console.WriteLine("" + Math.Abs(num) );	
		}		
      
	}
}