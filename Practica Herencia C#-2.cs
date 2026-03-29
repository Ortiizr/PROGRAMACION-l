using System;

public class Hamburguesa
{
    protected string nombre;
    protected string tipoPan;
    protected string carne;
    protected double precioBase;

    protected string adicional1Nombre;
    protected double adicional1Precio;

    protected string adicional2Nombre;
    protected double adicional2Precio;

    protected string adicional3Nombre;
    protected double adicional3Precio;

    protected string adicional4Nombre;
    protected double adicional4Precio;

    public Hamburguesa(string nombre, string tipoPan, string carne, double precioBase)
    {
        this.nombre = nombre;
        this.tipoPan = tipoPan;
        this.carne = carne;
        this.precioBase = precioBase;
    }

    public virtual void AgregarIngrediente1(string nombre, double precio)
    {
        adicional1Nombre = nombre;
        adicional1Precio = precio;
    }

    public virtual void AgregarIngrediente2(string nombre, double precio)
    {
        adicional2Nombre = nombre;
        adicional2Precio = precio;
    }

    public virtual void AgregarIngrediente3(string nombre, double precio)
    {
        adicional3Nombre = nombre;
        adicional3Precio = precio;
    }

    public virtual void AgregarIngrediente4(string nombre, double precio)
    {
        adicional4Nombre = nombre;
        adicional4Precio = precio;
    }

    public virtual double ItemizarHamburguesa()
    {
        double total = precioBase;

        Console.WriteLine("========================================");
        Console.WriteLine("Hamburguesa: " + nombre);
        Console.WriteLine("Pan: " + tipoPan);
        Console.WriteLine("Carne: " + carne);
        Console.WriteLine("Precio base: RD$" + precioBase);

        if (adicional1Nombre != null)
        {
            Console.WriteLine("Adicional 1: " + adicional1Nombre + " RD$" + adicional1Precio);
            total += adicional1Precio;
        }

        if (adicional2Nombre != null)
        {
            Console.WriteLine("Adicional 2: " + adicional2Nombre + " RD$" + adicional2Precio);
            total += adicional2Precio;
        }

        if (adicional3Nombre != null)
        {
            Console.WriteLine("Adicional 3: " + adicional3Nombre + " RD$" + adicional3Precio);
            total += adicional3Precio;
        }

        if (adicional4Nombre != null)
        {
            Console.WriteLine("Adicional 4: " + adicional4Nombre + " RD$" + adicional4Precio);
            total += adicional4Precio;
        }

        Console.WriteLine("Total de la hamburguesa: RD$" + total);
        Console.WriteLine("========================================");
        return total;
    }
}

public class HamburguesaSaludable : Hamburguesa
{
    private string adicionalSaludable1Nombre;
    private double adicionalSaludable1Precio;

    private string adicionalSaludable2Nombre;
    private double adicionalSaludable2Precio;

    public HamburguesaSaludable(string carne, double precioBase)
        : base("Hamburguesa Saludable", "Pan Integral", carne, precioBase)
    {
    }

    public void AgregarIngredienteSaludable1(string nombre, double precio)
    {
        adicionalSaludable1Nombre = nombre;
        adicionalSaludable1Precio = precio;
    }

    public void AgregarIngredienteSaludable2(string nombre, double precio)
    {
        adicionalSaludable2Nombre = nombre;
        adicionalSaludable2Precio = precio;
    }

    public override double ItemizarHamburguesa()
    {
        double total = precioBase;

        Console.WriteLine("========================================");
        Console.WriteLine("Hamburguesa: " + nombre);
        Console.WriteLine("Pan: " + tipoPan);
        Console.WriteLine("Carne: " + carne);
        Console.WriteLine("Precio base: RD$" + precioBase);

        if (adicional1Nombre != null)
        {
            Console.WriteLine("Adicional 1: " + adicional1Nombre + " RD$" + adicional1Precio);
            total += adicional1Precio;
        }

        if (adicional2Nombre != null)
        {
            Console.WriteLine("Adicional 2: " + adicional2Nombre + " RD$" + adicional2Precio);
            total += adicional2Precio;
        }

        if (adicional3Nombre != null)
        {
            Console.WriteLine("Adicional 3: " + adicional3Nombre + " RD$" + adicional3Precio);
            total += adicional3Precio;
        }

        if (adicional4Nombre != null)
        {
            Console.WriteLine("Adicional 4: " + adicional4Nombre + " RD$" + adicional4Precio);
            total += adicional4Precio;
        }

        if (adicionalSaludable1Nombre != null)
        {
            Console.WriteLine("Adicional saludable 1: " + adicionalSaludable1Nombre + " RD$" + adicionalSaludable1Precio);
            total += adicionalSaludable1Precio;
        }

        if (adicionalSaludable2Nombre != null)
        {
            Console.WriteLine("Adicional saludable 2: " + adicionalSaludable2Nombre + " RD$" + adicionalSaludable2Precio);
            total += adicionalSaludable2Precio;
        }

        Console.WriteLine("Total de la hamburguesa: RD$" + total);
        Console.WriteLine("========================================");
        return total;
    }
}

public class HamburguesaPremium : Hamburguesa
{
    private string bebida;

    public HamburguesaPremium(string bebidaSeleccionada)
        : base("Hamburguesa Premium", "Pan Brioche", "Carne Angus", 500)
    {
        bebida = bebidaSeleccionada;

        adicional1Nombre = "Papitas";
        adicional1Precio = 100;

        adicional2Nombre = bebida;
        adicional2Precio = 75;
    }

    public override void AgregarIngrediente1(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la Hamburguesa Premium.");
    }

    public override void AgregarIngrediente2(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la Hamburguesa Premium.");
    }

    public override void AgregarIngrediente3(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la Hamburguesa Premium.");
    }

    public override void AgregarIngrediente4(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la Hamburguesa Premium.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("********** CHIMI MIBARRIGA **********");
        Console.WriteLine("1. Hamburguesa Clasica");
        Console.WriteLine("2. Hamburguesa Saludable");
        Console.WriteLine("3. Hamburguesa Premium");
        Console.Write("Seleccione una opcion: ");
        int opcionHamburguesa = int.Parse(Console.ReadLine());

        switch (opcionHamburguesa)
        {
            case 1:
                Hamburguesa clasica = new Hamburguesa("Hamburguesa Clasica", "Pan de Agua", "Carne de Res", 250);

                clasica.AgregarIngrediente1("Lechuga", 20);
                clasica.AgregarIngrediente2("Tomate", 25);
                clasica.AgregarIngrediente3("Bacon", 50);
                clasica.AgregarIngrediente4("Queso", 35);

                clasica.ItemizarHamburguesa();
                break;

            case 2:
                HamburguesaSaludable saludable = new HamburguesaSaludable("Pechuga de Pollo", 300);

                saludable.AgregarIngrediente1("Lechuga", 20);
                saludable.AgregarIngrediente2("Tomate", 25);
                saludable.AgregarIngrediente3("Pepino", 20);
                saludable.AgregarIngrediente4("Cebolla", 15);
                saludable.AgregarIngredienteSaludable1("Aguacate", 60);
                saludable.AgregarIngredienteSaludable2("Maiz", 30);

                saludable.ItemizarHamburguesa();
                break;

            case 3:
                Console.WriteLine("Seleccione su refresco:");
                Console.WriteLine("1. Coca-Cola");
                Console.WriteLine("2. Pepsi");
                Console.WriteLine("3. Sprite");
                Console.WriteLine("4. Country Club Merengue");
                Console.Write("Opcion: ");
                int opcionRefresco = int.Parse(Console.ReadLine());

                string bebida = "";

                switch (opcionRefresco)
                {
                    case 1:
                        bebida = "Coca-Cola";
                        break;
                    case 2:
                        bebida = "Pepsi";
                        break;
                    case 3:
                        bebida = "Sprite";
                        break;
                    case 4:
                        bebida = "Country Club Merengue";
                        break;
                    default:
                        bebida = "Coca-Cola";
                        break;
                }

                HamburguesaPremium premium = new HamburguesaPremium(bebida);

                premium.AgregarIngrediente1("Bacon Extra", 50);

                premium.ItemizarHamburguesa();
                break;

            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }
    }
}