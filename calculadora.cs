
public class calculadora
{
    public double resultado;

    public calculadora (double valorInicial)
    {
        resultado = valorInicial;
    }

    public void Suma (double valor)
    {
        resultado += valor;
    }

    public void Resta (double valor)
    {
        resultado -= valor;
    }

    public void Multiplicacion (double valor)
    {
        resultado *= valor;
    }

    public void Division (double valor)
    {
        if (valor!=0)
        {
            resultado /= valor;  
        }
        else
        {
            Console.WriteLine("No se puede dividir por 0!!");
        }
    }

    public void Limpiar (){
        resultado = 0;
    }
}
