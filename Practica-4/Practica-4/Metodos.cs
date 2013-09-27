using System;
using System.Collections;
namespace Practica4
{
	public class Metodos
	{
		public Hashtable h; 
			
		public Metodos ()
		{
			
			this.h = new Hashtable();
		}
		public void datos()
		{
			for(int i=0;i<4;i++)
			{
				Persona p= new Persona();
				
				Console.WriteLine("Ingrese los siguientes datos: ");
				
				Console.WriteLine ("Codigo");
				p.codigo = double.Parse (Console.ReadLine());
				
				Console.WriteLine ("Nombre");
				p.nombre = Console.ReadLine ();
				
				Console.WriteLine ("Facebook");
				p.facebook = Console.ReadLine ();
				
				Console.WriteLine("Telefono");
				p.telefono = double.Parse(Console.ReadLine ());
				
				h.Add(p.codigo,p);
				Console.Clear ();
				
			}
			
		}
			
			
			
		
	}
}

