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
		public void editar()
		{
			for(int i=0; i<2; i++)
			{
				Console.WriteLine("Ingrese el codigo si quiere EDITAR datos");
				double codigo = double.Parse(Console.ReadLine ());
				
				if(h.ContainsKey(codigo)==true)
				{	
				
					Persona Edit = (Persona)(h[codigo]); 
					
					Console.WriteLine ("CODIGO: ");
					Console.WriteLine(Edit.codigo);
					
					Console.WriteLine ("Nombre: ");
					Console.WriteLine(Edit.nombre);
					
					Console.WriteLine("Facebook");
					Console.WriteLine(Edit.facebook);
					
					Console.WriteLine("Telefono");
					Console.WriteLine(Edit.telefono);
												
					///Edicion
					Console.WriteLine ("Nuevos datos");
					
					Console.WriteLine ("\nNombre: ");
					Edit.nombre= Console.ReadLine ();

					Console.WriteLine("Facebook");
					Edit.facebook=Console.ReadLine();
					
					Console.WriteLine("Telefono");
					Edit.telefono= double.Parse(Console.ReadLine());	
				
				}
				else
				{
					Console.WriteLine("El codigo no existe");
				}
				System.Threading.Thread.Sleep(1000);	
				Console.Clear();
					
				
			}
			
		}	
			
			
		
	}
}

