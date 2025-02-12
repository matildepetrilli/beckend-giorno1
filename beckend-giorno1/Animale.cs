namespace giornoUno
{
    internal class Animale
    {
        public required string Nomignolo { get; set; }
        public required string Tipo { get; set; }


        public void ShowAnimale()
        {
            Console.WriteLine(Nomignolo + " " + Tipo);
        }
    }
}