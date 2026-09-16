
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

        //Console.WriteLine("Estudiante: " + fernando.getNombre());
        //fernando.setNombre("Juan");
        //Console.WriteLine("Estudiante: " + fernando.getNombre());
        //fernando.imprimirNombreCompleto();

        //Console.WriteLine( "Promedio calculado = " + fernando.getPromedio() ); 
        
        fernando.toString();

        Docente docente = new Docente ( 
            "Ingenieria en software",
            "Prestación de servicios",
            0,
            "Fernando José",
            "Carta",
            "12345678",
            "cartafernando@corre.com",
            "12341234" );

        CalculoSalario calculoSalario = new CalculoSalario();
        double salario = calculoSalario.calculoSalarioDocente( 12 );

        docente.setSueldo( salario );
        Console.WriteLine( "Salario del docente = " + docente.getSueldo() );

        Administrativo administrativo = new 
        Administrativo( "Secretaria", "Decanatura", calculoSalario.calculoSalarioAdministrativo(2) );
        Console.WriteLine("Salario Secretaria = " + administrativo.getSalario());






    }

}