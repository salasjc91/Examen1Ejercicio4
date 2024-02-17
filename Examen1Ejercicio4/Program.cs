namespace Examen1Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)


        {
             //solicita al usuario  la cantidad de color. convierte una cadena de texto a numero entero

            Console.WriteLine("Ingrese la cantidad de rojo (0-255):");
            int rojo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de verde (0-255):");
            int verde = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de azul (0-255):");
            int azul = Convert.ToInt32(Console.ReadLine());

            // Crea un nuevo objeto de la clase ColorRGB, ademas que asignan los valores de las cantidades de rojo, verde y azul que el usuario ingresó a las propiedades correspondientes del objeto color
            ColorRGB color = new ColorRGB();
            color.Rojo = rojo;
            color.Verde = verde;
            color.Azul = azul;

            //Llamamos al método CalcularEscalaGrises del objeto color para calcular el valor en escala de grises del color utilizando la fórmula de la NTSC. El resultado se almacena en la variable escalaGrises.
            double escalaGrises = color.CalcularEscalaGrises();

            // muestra en consola el valor en escala de los grises
            Console.WriteLine($"El valor en escala de grises es: {escalaGrises}");
        }
    }
}
