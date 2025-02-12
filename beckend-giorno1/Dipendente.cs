namespace giornoUno
{
    internal class Dipendente
    {
        public required string FirstName { get; set; }
        public required string Impiego { get; set; }


        public void ShowDipendente()
        {
            Console.WriteLine(FirstName + " " + Impiego);
        }
    }
}