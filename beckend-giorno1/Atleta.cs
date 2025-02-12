
namespace giornoUno
{
    public class Atleta
    {
        //sicuramente le proprietà avranno dei valore
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Sport { get; set; }
        public required int Age { get; set; }


        //metodo, che sarà sempre public o internal
        public void ShowData()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Age + " " + Sport);
        }

    }


}
