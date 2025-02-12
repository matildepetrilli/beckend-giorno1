namespace giornoUno
{
    internal class Veicolo
    {
        public required int NumeroRuote { get; set; }
        public required string Colore { get; set; }

        public void ShowVeicolo()
        {
            Console.WriteLine(NumeroRuote + " " + Colore);
        }
    }
}
