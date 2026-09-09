
class Program
{

    static void Main()
    {
        Estudiante fernando = new Estudiante(
                    "Tecnologia en desarrollo de software",
                    "2026-2",
                    4.4,
                    "Fernando",
                    "Carta",
                    "1234567",
                    "fernandocarta@correo.com",
                    "3001234567"
        );

        Console.WriteLine("Estudiante: " + fernando.getNombre());
        fernando.setNombre("Juan");
        Console.WriteLine("Estudiante: " + fernando.getNombre());


    }

}