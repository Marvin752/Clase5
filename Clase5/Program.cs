static void Suma()
{
    int val1, val2 = 0;
    Console.Write("Ingrese valor 1: ");
    val1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese valor 2: ");
    val2 = Convert.ToInt32(Console.ReadLine());
    int respuesta = val1 + val2;
    Console.WriteLine("Suma = " + respuesta);
}

//Ejercicio 2

static string Datos()
{
    string nom = "";
    Console.Write("Ingrese nombre: ");
    nom = Console.ReadLine();
    return nom;
}

//Ejercicio 3

static void calculoEdad()
{
    Console.Write("Ingrese su año de nacimiento: ");
    int año = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - año;
    Console.WriteLine("Su edad es = " + edad);
}

static int osuma(int val1, int val2, int val3)
{
    return val1 + val2 + val3;
}

string name = Datos();
int sumanumeros = osuma(10, 20, 5);
Console.WriteLine(sumanumeros);
decimal promedio = osuma(30, 20, 40) / 3;
Console.WriteLine(name + " Tiene promedio de " + promedio);


int op = 0;
do
{
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Nombre");
    Console.WriteLine("3) Edad");
    Console.WriteLine("4) Salir");
    Console.WriteLine();
    Console.Write("> ");
    op = Convert.ToInt32(Console.ReadLine());
    if (op != 4)
    {
        switch (op)
        {
            case 1:
                Suma();
                break;
            case 2:
                Datos();
                break;
            case 3:
                calculoEdad();
                break;
            default:
                Console.WriteLine("La opcion es invalida");
                break;
        }
    }
} while (op != 4);