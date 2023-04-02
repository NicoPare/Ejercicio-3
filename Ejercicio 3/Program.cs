// Lea las teclas presionadas y finalice al presionar la tecla “X”.

Console.WriteLine("Ingrese una tecla, si presiona X el programa finaliza");
var tecla = Console.ReadLine();

do
{
    do
    {
        // valido que se ingrese solo una tecla en la variable
        if (tecla.Length > 1 || tecla.Length == 0)
        {
            Console.WriteLine("Por favor, ingrese una sola tecla");
            tecla = Console.ReadLine();
        }
    } while (tecla.Length > 1 || tecla.Length == 0);
    
    // luego de validar que sea una sola tecla, creo condicion para finalizar programa cuando el usuario ingresa "X"
    if (tecla.ToUpper() != "X") ;
    {
        Console.WriteLine("Ingrese otra tecla, si presiona X el programa finaliza");
        tecla = Console.ReadLine();
    }     
} while (tecla.ToUpper() != "X");
Console.WriteLine("El programa va a finalizar");