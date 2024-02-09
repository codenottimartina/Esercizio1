//statistiche numeri: si chiede ciclicamente all'utente di inserire una serie di numeri, al fine di calcolare delle semplici statistiche come media, min e max.
//Ad ogni iterazione quindi, l'utente potrà svolgere le seguenti operazioni
//-inserire un numero intero -> in tal caso il software lo acquisisce e si predispone per acquisire un nuovo numero
//-inserire il testo "fine" -> in tal caso il software termina il processo di acquisizione e stampa a video le statistiche di cui sopra rispetto ai numeri
//precedentemente inseriti: media, min e max.A questo punto, il programma termina in seguito alla pressione del tasto INVIO

Console.WriteLine("Inserisci dei valori [digita 'fine' per terminare l'inserimento]:");
var numeroAcquisito = Console.ReadLine();
var listaNumeri = new List<decimal>();

while (numeroAcquisito != "fine")
{
    try
    {
        var num = Convert.ToDecimal(numeroAcquisito);
        listaNumeri.Add(num);
    }
    catch
    {
        Console.WriteLine("Il valore inserito non è valido");
    }
    numeroAcquisito = Console.ReadLine();
}

Console.WriteLine("la media dei valori inseriti è: " + Utilities.CalcolaMedia(listaNumeri));
Console.WriteLine("Il valore maggiore inserito è: " + Utilities.CalcolaMax(listaNumeri));
Console.WriteLine("Il valore minore inserito è: " + Utilities.CalcolaMin(listaNumeri));

Console.ReadLine();
public static class Utilities
{
    public static decimal CalcolaMedia(List<decimal> listaNumeri)
    {
        decimal contaNumeri = 0;

        foreach (var num in listaNumeri)
        {
            contaNumeri += num;
        }

        decimal media = contaNumeri / listaNumeri.Count;

        return media;
    }

    public static decimal CalcolaMin(List<decimal> listaNumeri)
    {
        var min = listaNumeri[0];

        foreach (var num in listaNumeri)
        {
            if(num < min)
            {
                min = num;
            }
        }

        return min;
    }

    public static decimal CalcolaMax(List<decimal> listaNumeri)
    {
        var max = listaNumeri[0];

        foreach (var num in listaNumeri)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}