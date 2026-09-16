public class CalculoSalario
{
    
    public double calculoSalarioDocente ( int cantidadHoras )
    {
        double salario = 0, valorHoras = 45000;
        double deduccionPension = 0.07;
        double deduccionSalud = 45000;

        salario = cantidadHoras * valorHoras - ( deduccionSalud );

        salario = salario - salario * deduccionPension;


        return salario;

    }

    public double calculoSalarioAdministrativo ( short jornada )
    {
        
        double salario = 0;
        double valorHoras = 51500;
        int cantidadHoras = 0;

        switch (jornada)
        {
            case 1:
                cantidadHoras = 20; //Jornada = 1 (Medio tiempo)
            break; 

            case 2:
                cantidadHoras = 40; //Jornada = 2 (Tiempo completo)
            break;
        }
        
        salario = cantidadHoras * valorHoras;

        return salario; 
    }


}


