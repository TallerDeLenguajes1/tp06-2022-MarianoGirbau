
public class Calculadora
{
    public double resultado;

    public Calculadora (void)
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
        resultado /= valor;
    }
}
