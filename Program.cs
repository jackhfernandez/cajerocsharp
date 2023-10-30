// Simulacion de un cajero en c#

float amount = 0f, deposit = 0f, withdraw = 0f, change = 3.69f;
int choice, pin = 0;
string? k;
Console.WriteLine("\nPor favor ingrese su clave PIN secreto:\n");
while (pin != 1212)
{
    pin = Convert.ToInt32(Console.ReadLine());
    if (pin != 1212)
    Console.WriteLine("PIN incorrecto, intentelo de nuevo: ");
}
do
{
    Console.WriteLine("\n***Hola Jack, bienvenido!***\n");
    Console.WriteLine("Que operacion deseas realizar?\n");
    Console.WriteLine("1. Verificar saldo.");
    Console.WriteLine("2. Depositar dinero en soles.");
    Console.WriteLine("3. Depositar dinero en dolares.");
    Console.WriteLine("4. Retirar dinero en soles.");
    Console.WriteLine("5. Retirar dinero en dolares.");
    Console.WriteLine("6. Salir.\n");
    Console.WriteLine("Ingrese su elección:\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("\nTu saldo es de S/ " + amount); break;
        case 2:
            Console.WriteLine("\nIngrese la cantidad en soles a depositar:\n");
            deposit = Convert.ToSingle(Console.ReadLine());
            amount = amount + deposit;
            Console.WriteLine("\nTu saldo ahora es de S/ " + amount); break;
        case 3:
            Console.WriteLine("\nIngrese la cantidad en dolares a depositar:\n");
            deposit = Convert.ToSingle(Console.ReadLine());
            amount = amount + (deposit * change);
            System.Console.WriteLine("\nTu saldo ahora es de S/ " + amount); break;
        case 4:
            Console.WriteLine("Ingrese el monto a retirar:\n");
            withdraw = Convert.ToSingle(Console.ReadLine());
            if (withdraw > amount)
            {
                Console.WriteLine("Saldo insuficiente.");
            } else
            {
                amount = amount - withdraw;
                Console.WriteLine("Retire su dinero en efectivo");
                Console.WriteLine("\nTu saldo actual es S/ " + amount);
            } break;
        case 5:
            Console.WriteLine("\nIngrese el monto a retirar:\n");
            withdraw = Convert.ToSingle(Console.ReadLine());
            if ((withdraw * change) > amount)
            {
                Console.WriteLine("Saldo insuficiente.");
            } else
            {
                amount = amount - (withdraw * change);
                Console.WriteLine("\nRetire su dinero en efectivo");
                Console.WriteLine("\nTu saldo actual es " + amount);
            } break;
        case 6:
            Console.WriteLine("Gracias por usar el cajero automático!"); break;
        default:
            Console.WriteLine("Opcion invalida!"); break;
    }
    Console.WriteLine("\nDesea realizar otra operacion? (s/n)\n");
    k = Console.ReadLine();


} while (k == "s"); 
{
    System.Console.WriteLine("Gracias por utilizar el servicio del cajero automático!\n");
}