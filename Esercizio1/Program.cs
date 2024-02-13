

//statistiche numeri: si chiede ciclicamente all'utente di inserire una serie di numeri, al fine di calcolare delle semplici statistiche come media, min e max.
//Ad ogni iterazione quindi, l'utente potrà svolgere le seguenti operazioni
//-inserire un numero intero -> in tal caso il software lo acquisisce e si predispone per acquisire un nuovo numero
//-inserire il testo "fine" -> in tal caso il software termina il processo di acquisizione e stampa a video le statistiche di cui sopra rispetto ai numeri
//precedentemente inseriti: media, min e max.A questo punto, il programma termina in seguito alla pressione del tasto INVIO

Console.WriteLine("Inserisci dei valori [digita 'fine' per terminare l'inserimento]:");
var numeroAcquisito = Console.ReadLine();
var listaNumeri = new List<int>();

while (numeroAcquisito != "fine")
{
    try
    {
        var num = Convert.ToInt32(numeroAcquisito);
        listaNumeri.Add(num);
    }
    catch
    {
        Console.WriteLine("Il valore inserito non è valido");
    }
    numeroAcquisito = Console.ReadLine();
}

Console.WriteLine("la media dei valori inseriti è: " + Utilities.CalcolaMedia(listaNumeri));
Console.WriteLine("Il valore maggiore inserito è: " + listaNumeri.Max());
Console.WriteLine("Il valore minore inserito è: " + listaNumeri.Min());

Console.ReadLine();

public static class Utilities
{
    public static decimal CalcolaMedia(List<int> listaNumeri)
    {
        int contaNumeri = 0;

        foreach (var num in listaNumeri)
        {
            contaNumeri += num;
        }

        decimal media = (decimal)contaNumeri / listaNumeri.Count;

        return media;
    }

    public static decimal CalcolaMin(List<int> listaNumeri)
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

    public static decimal CalcolaMax(List<int> listaNumeri)
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

//try
//{
//    throw new Exception("eccezione speciale 1");
//}
//catch (EccezioneSpeciale1 ex1)
//{
//    throw ex1;
//}
//catch (Exception ex)
//{

//}


//public class EccezioneSpeciale1 : Exception
//{
//    public EccezioneSpeciale1(string message) : base(message)
//    {

//    }
//}

//public class EccezioneSpeciale2 : Exception
//{
//    public EccezioneSpeciale2(string message) : base(message)
//    {

//    }
//}