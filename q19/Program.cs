using System;

Vetor v = (1, 2);
Vetor u = (4, 3);
Vetor r = (5, 5);

Console.WriteLine($"{v} + {u} = {r}?");

if (v + u == r)
    Console.WriteLine("Sim!");
else Console.WriteLine("Não! (mas devia)");


public class Vetor
{

    public int[] valores { get; set; }

    public Vetor(int[] dados)
    {
        this.valores = dados;
    }

    public bool EIgual(Vetor vetor)
    {
        if (this.valores[0] == vetor.valores[0] & this.valores[1] == vetor.valores[1])
        // Por algum motivo que eu NAO TENHO IDEIA,   "this.valores == vetor.valores"   NAO FUNCIONA
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Vetor Soma(Vetor vetor)
    {
        int val1 = this.valores[0] + vetor.valores[0];
        int val2 = this.valores[1] + vetor.valores[1];
        Vetor retorno = ((val1),(val2));
        return retorno;
    }

    public override string ToString()
    {
        return "(" + valores[0].ToString() + "," + valores[1].ToString() + ")";
    }

    public static implicit operator Vetor((int, int) tupla)
        => new Vetor(new int[] {
            tupla.Item1, 
            tupla.Item2
        });

    public static implicit operator Vetor((int, int, int) tupla)
        => new Vetor(new int[] {
            tupla.Item1, 
            tupla.Item2,
            tupla.Item3
        });

    public static Vetor operator +(Vetor v, Vetor u)
        => v.Soma(u);

    public static bool operator ==(Vetor v, Vetor u)
        => v.EIgual(u);

    public static bool operator !=(Vetor v, Vetor u)
        => !v.EIgual(u);
}
