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
BONUS:
Continuare gli stessi ragionamenti anche per tutte le altre sottoclassi che avevate pensato, come il sacchetto di 
frutta, l’elettrodomestico e così via.
*/

using CSharpShop3;

/*
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
*/

/*
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
*/

//prova delle eccezioni nei metodi (ACQUA)
try
{
    Acqua acquaProvaSet = new Acqua("nome dell'acqua", "descrizione dell'acqua", 1.05, 22, 1.0, 6.8, "nome sorgente");
    //acquaProvaSet.SetNome(" ");
    //acquaProvaSet.SetPrezzo(-27);
    //acquaProvaSet.SetIva(-7);
    acquaProvaSet.StampaProdotto();
    
    //acquaProvaSet.Bevi(0.3);
    acquaProvaSet.Riempi(1.6);
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































//-------------------------------------------------CSharpShop2-------------------------------------//
/*
//creazione nuovo prodotto
Prodotto prodottoNegozio = new Prodotto("shampoo", "per capelli normali", 1.60, 22);

//stampa nome completo del prodotto
prodottoNegozio.StampaProdotto();


//creazione da classe acqua
Acqua acquaNaturale = new Acqua("acqua naturale", "acqua minerale liscia", 0.85, 10, 1.5, 7.0, "fonte");
acquaNaturale.StampaProdotto();

//metodo bevi
acquaNaturale.Bevi(0.5);
Console.WriteLine(acquaNaturale.GetLitri());

//metodo riempi
acquaNaturale.Riempi(0.3);
Console.WriteLine(acquaNaturale.GetLitri());

//metodo svuota
acquaNaturale.Svuota();
Console.WriteLine(acquaNaturale.GetLitri());
*/

/*
//creazione da classe frutta
Frutta sacchettoDiFrutta = new Frutta("sacchetto di frutta", "ananas a pezzi", 3.45, 10, 5);
sacchettoDiFrutta.StampaProdotto();

//metodo togli un pezzo
sacchettoDiFrutta.TogliPezzo(3);
Console.WriteLine(sacchettoDiFrutta.GetPezzi());


//creazione da classe elettrodomestico
Elettrodomestico lavastoviglie = new Elettrodomestico("lavastoviglie", "lavastoviglie a incastro", 280, 22, "lava", "acciaio", "D");
lavastoviglie.StampaProdotto();

//creazione da classe cibo in scatola
CiboInScatola fagioli = new CiboInScatola("barattolo di fagioli", "fagioli lessi", 1.19, 4, 300, "fagioli borlotti", "barattolo di vetro");
fagioli.StampaProdotto();


//metodo bevi -> maggiore della quantità nella scatola
fagioli.Mangia(400);
Console.WriteLine(fagioli.GetGrammi());

//metodo svuota
fagioli.Svuota();
Console.WriteLine(fagioli.GetGrammi());

//prova metodo classe prodotto su sottoclasse cibo in scatola
fagioli.StampaPrezzo();
*/
//------------------------------------------------------------------------------------------------//
