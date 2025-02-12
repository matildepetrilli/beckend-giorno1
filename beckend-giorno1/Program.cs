
using giornoUno;

Atleta atleta1 = new Atleta()
{
    FirstName = "Mario",
    LastName = "Rossi",
    Age = 50,
    Sport = "Salto in alto",
};
//assegno subito dei valori alle mie prorpietà

atleta1.ShowData();

var dipendente1 = new Dipendente()
{
    FirstName = "Giorgio",
    Impiego = "cuoco",
};

dipendente1.ShowDipendente();

var animale1 = new Animale()
{
    Nomignolo = "Flash",
    Tipo = "Tartaruga",
};

animale1.ShowAnimale();

var Veicolo1 = new Veicolo()
{
    NumeroRuote = 4,
    Colore = "rosso",
};

Veicolo1.ShowVeicolo();
