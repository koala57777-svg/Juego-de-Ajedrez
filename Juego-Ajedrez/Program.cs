string contraseña = "";
string usuario = "";
int intentos= 3;
do {
    Console.WriteLine("Por favor ingrese el usuario");
    for (int i = 0; i<3; i++)
    {
        Console.WriteLine($"Intento {i + 1}");
        usuario= Console.ReadLine();
        intentos--;
    }

}while (intentos>0);