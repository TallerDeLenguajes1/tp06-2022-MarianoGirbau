public class empleado
{
    public string? nombre;
    public string? apellido;
    public char estadoCivil;
    public char genero;
    public DateTime fechaDeNacimiento;
    public DateTime fechaDeIngreso;
    public double sueldoBasico;
    public cargos cargo;
    public double salario;


    public enum cargos
    {
        auxiliar,
        administrativo,
        ingeniero,
        especialista,
        investigador,
    }

    public int Edad (){
        DateTime fechaActual= DateTime.Now;
        int edad = fechaActual.Year - fechaDeNacimiento.Year;
        if (fechaActual.Month >= fechaDeNacimiento.Month && fechaActual.Day >= fechaDeNacimiento.Day)
        {
            return edad;
        }else
        {
            return edad-1;
        }
    }

    public void Jubilacion (){
        int jubi;
        if(genero=='M'){
            jubi = 65-Edad();
        }else
        {
            jubi = 60 - Edad();
        }

        Console.WriteLine("Le faltan "+ jubi +" para jubilarse");
    }
    public int Antiguedad ()
    {
        DateTime fechaActual= DateTime.Now;
        int ano = fechaActual.Year - fechaDeIngreso.Year;
        int mes = fechaActual.Month - fechaDeIngreso.Month;
        int dia = fechaActual.Day - fechaDeIngreso.Day;

        if (fechaActual.Month >= fechaDeIngreso.Month && fechaActual.Day >= fechaDeIngreso.Day)
        {
            return ano;
        }else
        {
            return ano-1;
        }
    }

    public void Salario (double sueldoBasico)
    {
        salario = sueldoBasico + Adicional();
    }

    public double Adicional ()
    {
        double adicional=0;
        if (Antiguedad()<20)
        {
            adicional = sueldoBasico * (Antiguedad() * 0.1);
            
        }else if(Antiguedad()>=20){

            adicional = sueldoBasico * 0.25;

        }

        if (cargo==cargos.ingeniero || cargo==cargos.especialista)
        {
            adicional = adicional + sueldoBasico * (0.5); // 50%
        }
        
        if (estadoCivil=='C')
        {
            adicional += 15000;
        }

        return adicional;
    }
}