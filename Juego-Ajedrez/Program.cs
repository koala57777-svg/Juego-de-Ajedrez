string contraseña = "E$quizo1984";
string usuario = "Koalas";
string usuarioo = "";
int intentos= 3;
string contraseñaa = "";
bool login=false;

for (int i = 0; i < 3; i++)
{ 
    Console.Write($"Por favor ingrese el usuario, intento {intentos}: ");
    usuarioo = Console.ReadLine();
    Console.Write($"Por favor, ingrese la contraseña, intento {intentos}: ");
    contraseñaa = Console.ReadLine();
    Console.WriteLine();
    if (usuarioo == usuario && contraseñaa == contraseña)
    {
        login = true; break;
    }
    else
    {
        intentos--;
        Console.Write($"Datos incorrectos. Te quedan {intentos} intento(s).");
        Console.ReadKey();
        Console.Clear();
    }
 
}
Console.Clear();
if (login == true)
{
    Console.WriteLine("El usuario ingresado y la contraseña ingresada son correctos.\n¡Bienvenido!");
}
else if (login == false)
{

    Console.WriteLine("Intentos acabados. Acceso denegado.");
    Console.ReadKey(); return;
}