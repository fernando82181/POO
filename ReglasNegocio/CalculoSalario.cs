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


}


