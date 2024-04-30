using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Runtime.InteropServices;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Fase 1" +  Environment.NewLine);

            Producto ObjeProducto = new Producto("Producto A", "Descripcion del producto A", 10, .25,.21,
                "Acme","Categoria A"  );

            

            Console.WriteLine("Producto" + Environment.NewLine );

            Console.WriteLine("Nombre {0} ", ObjeProducto.Nombre);
            Console.WriteLine("Descripcion: {0}", ObjeProducto.Descriccion);
            Console.WriteLine("Precio de costo: {0}", ObjeProducto.PrecioCosto.ToString("C"));  
            Console.WriteLine("Margen: {0}", ObjeProducto.Margen.ToString("p"));
            Console.WriteLine("IVA: {0}", ObjeProducto.Iva.ToString("p"));
            Console.WriteLine("Precio Bruto: {0}", ObjeProducto.PrecioBruto.ToString("C"));
            Console.WriteLine("Precio Venta: {0}", ObjeProducto.PrecioVenta.ToString("C"));
            Console.WriteLine("Proeedor: {0}", ObjeProducto.Proveedor);
            Console.WriteLine("Categoria: {0}", ObjeProducto.Categoria);


           

            Pausa();
           
          ClienteIndividuo viduo= new ClienteIndividuo("Luis", "Trech", "20-28897819-",
              "Luistrech@gmail","4212025","Los Nogales 3333");

            Console.WriteLine("Cliente Individuo" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", viduo.Nombre);
            Console.WriteLine("Apellido: {0}", viduo.Apellido);
            Console.WriteLine("CUIT: {0}", viduo.CUIT);
            Console.WriteLine("Email: {0}", viduo.Email);
            Console.WriteLine("Telefono: {0}", viduo.Telefono);
            Console.WriteLine("Direccion: {0} ", viduo.Direccion);

            Pausa();

            Vendedor nVendedor = new Vendedor("DON OMAR", "LOCO BIL", "27877827");
            Console.WriteLine("Vendedor " + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", nVendedor.Nombre);
            Console.WriteLine("Apellido: {0}", nVendedor.Apellido);
            Console.WriteLine("DNI: {0} ", nVendedor.DNI);

            Pausa();

            Console.WriteLine(Environment.NewLine + "Pulsa una tecla para terminar.....");
            Console.ReadKey();
            Console.Clear();

        }

        
        private static void Pausa()
        {
            Console.WriteLine(Environment.NewLine + "Pulse una Tecla....");
            Console.ReadKey();
            Console.Clear();
            
        }
        
    }
}
