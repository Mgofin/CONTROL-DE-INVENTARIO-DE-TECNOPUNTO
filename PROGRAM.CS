using System;
using System.Collections.Generic;

class Producto
{
    private string nombre;
    private decimal precio;
    private int cantidad;

    public string Codigo { get; set; }

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("El nombre no puede estar vacío.");

            nombre = value;
        }
    }

    public decimal Precio
    {
        get { return precio; }
        set
        {
            if (value <= 0)
                throw new Exception("El precio debe ser mayor que cero.");

            precio = value;
        }
    }

    public int Cantidad
    {
        get { return cantidad; }
        set
        {
            if (value < 0)
                throw new Exception("La cantidad no puede ser negativa.");

            cantidad = value;
        }
    }

    public decimal ValorTotal
    {
        get { return Precio * Cantidad; }
    }

    public Producto(string codigo, string nombre, decimal precio, int cantidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine("\n----------------------------");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: RD${Precio}");
        Console.WriteLine($"Cantidad: {Cantidad}");
        Console.WriteLine($"Valor Total: RD${ValorTotal}");
    }
}

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>();

        Console.WriteLine("INVENTARIO TECNOPUNTO");

        for (int i = 1; i <= 3; i++)
        {
            try
            {
                Console.WriteLine($"\nProducto #{i}");

                Console.Write("Código: ");
                string codigo = Console.ReadLine();

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Precio: ");
                decimal precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Cantidad: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Producto producto = new Producto(
                    codigo,
                    nombre,
                    precio,
                    cantidad);

                productos.Add(producto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                i--;
            }
        }

        Console.WriteLine("\nPRODUCTOS REGISTRADOS");

        foreach (Producto p in productos)
        {
            p.MostrarInfo();
        }

        Console.WriteLine("\nPresione una tecla para finalizar...");
        Console.ReadKey();
    }
}
