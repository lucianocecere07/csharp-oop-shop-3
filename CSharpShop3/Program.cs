// See https://aka.ms/new-console-template for more information


/*
A partire da quanto già fatto con csharp-oop-shop-2 dove vi era stato chiesto di creare una classe Prodotto generica 
per gestire un generico prodotto dello Shop, e di un paio di prodotti ereditati come Acqua, sacchetto di frutta, 
ecc ecc.
Ora vi chiedo di inserire correttamente le Eccezioni nei vostri Prodotti e sotto prodotti in modo da gestire 
correttamente gli eventi eccezionali, senza dover più fare un semplice Console.WriteLIne().
Ricordatevi poi di testare le vostre classi, in particolare poi gestite e “catturate” correttamente le eccezioni nel 
vostro programma principale Program.cs e fate delle prove per simulare qualche situazione spiacevole per i vostri 
prodotti che avete previsto, in modo da verificare il comportamento delle vostre eccezioni.
Come primo esercizio focalizzatevi bene SOLO sulla classe Prodotto e sottoclasse Acqua dove potete aggiungere le 
seguenti Eccezioni:
- nel costruttore di Acqua, non posso creare un’acqua se la bottiglia ha un ph negativo, oppure superiore a 10. 
O ancora non posso avere una capienza sopra la capienza massima o negativa e così via.
- nel metodo bevi (double litriDaBere) se l’acqua finisce, restituire un eccezione magari costruita da voi.
- metodo riempi(double litri) che riempie la bottiglia di acqua e restituisce un eccezione se supero la sua capienza 
massima.
- un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei 
litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti 
come 3.785 nel modo corretto come visto in classe).
Una volta terminata la classe Prodotto e Acqua correttamente gestite anche le Eccezioni, vi chiedo di inserire un 
attributo statico alla classe Prodotto che permetta di contare quanti Prodotti ho istanziato fino ad un determinato 
istante nel mio programma. Alla fine o durante l’esecuzione del programma principale stampare in Console l’ammontare 
dei prodotti creati nel vostro negozio online.
*/

using CSharpShop3;
using System;


//prova delle eccezioni nel costruttore (PRODOTTO)
try
{
    Prodotto prodottoDiProva = new Prodotto("", "descrizione del prodotto", 3, 22);
    prodottoDiProva.StampaProdotto();
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}


//prova delle eccezioni nei metodi Setter (PRODOTTO)
try
{
    Prodotto prodottoProvaSet = new Prodotto("nome del prodotto", "descrizione del prodotto", 3, 22);
    //prodottoProvaSet.SetNome(" ");
    //prodottoProvaSet.SetPrezzo(-27);
    prodottoProvaSet.SetIva(-7);
    prodottoProvaSet.StampaProdotto();
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

//spazio su console
Console.WriteLine();

//prova delle eccezioni nel costruttore (ACQUA)
try
{
    Acqua AcquaDiProva = new Acqua("nome dell'acqua", "descrizione dell'acqua", 1.05, 22, 1.5, 5.8, "nome sorgente");
    AcquaDiProva.StampaProdotto();
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}


//prova delle eccezioni nei metodi (ACQUA)
try
{
    Acqua acquaProvaSet = new Acqua("nome dell'acqua", "descrizione dell'acqua", 1.05, 22, 1.0, 6.8, "nome sorgente");
    //acquaProvaSet.SetNome(" ");
    //acquaProvaSet.SetPrezzo(-27);
    //acquaProvaSet.SetIva(-7);
    acquaProvaSet.StampaProdotto();
    
    acquaProvaSet.Bevi(1.0);
    //acquaProvaSet.Riempi(0.6);
    acquaProvaSet.StampaProdotto();
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}



//metodo statico converte In Galloni
Acqua acquaGalloni = new Acqua("acqua galloni", "prova galloni", 1, 22, 1.3, 7, "sorgente galloni");
acquaGalloni.StampaProdotto();
Console.WriteLine("galloni (dell'acqua) sono: " + Acqua.ConvertiInGalloni(acquaGalloni.GetLitri()) + " gal");

//spazio su console
Console.WriteLine();

//numero di prodotti presenti
//creazione di prodotti
Prodotto prodottoProva = new Prodotto("nome del prodotto", "descrizione del prodotto", 3, 22);
Acqua AcquaProva = new Acqua("nome dell'acqua", "descrizione dell'acqua", 1.05, 22, 1.5, 6.8, "nome sorgente");
Prodotto prodottoNegozio = new Prodotto("shampoo", "per capelli normali", 1.60, 22);
Acqua acquaNaturale = new Acqua("acqua naturale", "acqua minerale liscia", 0.85, 10, 1.5, 7.0, "fonte");
Frutta sacchettoDiFrutta = new Frutta("sacchetto di frutta", "ananas a pezzi", 3.45, 10, 5);
Elettrodomestico lavastoviglie = new Elettrodomestico("lavastoviglie", "lavastoviglie a incastro", 280, 22, "lava", "acciaio", "D");
CiboInScatola fagioli = new CiboInScatola("barattolo di fagioli", "fagioli lessi", 1.19, 4, 300, "fagioli borlotti", "barattolo di vetro");

//stampa in console numero di prodotti presenti 
Console.WriteLine("totale (prodotti presenti): " + Prodotto.GetNumeroProdottiPresenti()); 
