using System;
using System.Collections.Generic;

public class Ruta
{
    public string Nombre { get; set; }
    public double DistanciaKm { get; set; }
    public double PrecioBase { get; set; }

    public Ruta(string nombre, double distanciaKm, double precioBase)
    {
        Nombre = nombre;
        DistanciaKm = distanciaKm;
        PrecioBase = precioBase;
    }
}

public class Autobus
{
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public int Pasajeros { get; set; }
    public double MultiplicadorPrecio { get; set; }
    public Ruta RutaSeleccionada { get; set; }

    public Autobus(string nombre, int capacidad, double multiplicadorPrecio)
    {
        Nombre = nombre;
        Capacidad = capacidad;
        MultiplicadorPrecio = multiplicadorPrecio;
        Pasajeros = 0;
    }

    public void AsignarRuta(Ruta ruta)
    {
        RutaSeleccionada = ruta;
    }

    public double PrecioFinal()
    {
        return RutaSeleccionada.PrecioBase * MultiplicadorPrecio;
    }

    public void VenderPasaje()
    {
        if (Pasajeros < Capacidad)
        {
            Pasajeros++;
            Console.WriteLine($"1 asiento vendido en {Nombre} -> Quedan {AsientosDisponibles()} asientos disponibles");
        }
        else
        {
            Console.WriteLine("No hay asientos disponibles.");
        }
    }

    public int AsientosDisponibles()
    {
        return Capacidad - Pasajeros;
    }

    public double CalcularVentas()
    {
        return Pasajeros * PrecioFinal();
    }

    public void MostrarResumen()
    {
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine($"Auto Bus {Nombre}");
        Console.WriteLine($"Ruta: {RutaSeleccionada.Nombre}");
        Console.WriteLine($"Distancia: {RutaSeleccionada.DistanciaKm} km");
        Console.WriteLine($"Precio por pasajero: RD${PrecioFinal():N0}");
        Console.WriteLine($"Pasajeros: {Pasajeros}");
        Console.WriteLine($"Ventas: RD${CalcularVentas():N0}");
        Console.WriteLine($"Quedan {AsientosDisponibles()} asientos disponibles");
        Console.WriteLine("------------------------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Ruta> rutas = new List<Ruta>()
        {
            new Ruta("27 de Febrero - Independencia", 10, 25),
            new Ruta("Corredor Duarte - Máximo Gómez", 12.5, 40),
            new Ruta("Santo Domingo - San Cristóbal", 28, 50),
            new Ruta("Santo Domingo - Santiago", 155, 75)
        };

        Autobus gold = new Autobus("Gold", 15, 1.0);
        Autobus platinum = new Autobus("Platinum", 22, 1.5);

        Console.WriteLine("=== SISTEMA DE COBRO DE PASAJES ===");
        Console.WriteLine("Seleccione cómo desea viajar:");
        Console.WriteLine("1. Gold");
        Console.WriteLine("2. Platinum");
        Console.Write("Opción: ");
        int opcionBus = int.Parse(Console.ReadLine());

        Autobus busSeleccionado;

        if (opcionBus == 1)
        {
            busSeleccionado = gold;
        }
        else
        {
            busSeleccionado = platinum;
        }

        Console.WriteLine($"\nHa seleccionado viajar en {busSeleccionado.Nombre}");
        Console.WriteLine("\n=== RUTAS DISPONIBLES ===");

        for (int i = 0; i < rutas.Count; i++)
        {
            double precioRuta = rutas[i].PrecioBase * busSeleccionado.MultiplicadorPrecio;
            Console.WriteLine($"{i + 1}. {rutas[i].Nombre} | {rutas[i].DistanciaKm} km | Precio: RD${precioRuta:N0}");
        }

        Console.Write("\nSeleccione la ruta: ");
        int opcionRuta = int.Parse(Console.ReadLine());
        busSeleccionado.AsignarRuta(rutas[opcionRuta - 1]);

        Console.Write("¿Cuántos pasajeros desea comprar?: ");
        int cantidadPasajeros = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Compra de asientos ---");
        for (int i = 0; i < cantidadPasajeros; i++)
        {
            busSeleccionado.VenderPasaje();
        }

        busSeleccionado.MostrarResumen();
    }
}