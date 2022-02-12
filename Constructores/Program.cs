class Dog
{
    public int Id { get; set; }
    public string Race { get; set; }
    public static string Name { get; set; }

    //constructor estatico
    static Dog()
    {
        System.Console.WriteLine("Llamada desde el constructor estatico");
        Name = "Firulay";
    }

    //constructor de instancia
    /*public Dog()
    {
        System.Console.WriteLine("Llamada desde el contructor de instancia ");
        Id=1;
        Race="Pitbull";
    }*/

    //constructor privado
    private Dog()
    {
        System.Console.WriteLine("Llamada desde el constructor privado");
    }
    public static Dog GetDog()
    {
        return new Dog();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        /*var res = new Dog();
        int id=res.Id;
        string race=res.Race;
        string name =Dog.Name;
        System.Console.WriteLine($"\nID: {id}  \nRACE: {race}  \nNAME: {name}");

        var res2= new Dog();
        int id2= res.Id=2;
        string race2=res.Race="Doberman";
        string name2= Dog.Name;
        System.Console.WriteLine($"\nID: {id2}  \nRACE: {race2}  \nNAME: {name}");

        var res3 = new Dog(){
            Id=3,
            Race="Chihuahua"
        };
        int id3=res3.Id;
        string race3=res3.Race;
        System.Console.WriteLine($"\nID: {id3}  \nRACE: {race3}  \nNAME: {name}");*/


        var objetoDog = Dog.GetDog(); //creando una nueva instancia
        objetoDog.Id = 4;
        objetoDog.Race = "Presa canario";
        System.Console.WriteLine($"\nID: {objetoDog.Id}  \nRACE: {objetoDog.Race}  \nNAME: {Dog.Name}");

        objetoDog.Id = 5;
        objetoDog.Race = "Bull-dog";
        System.Console.WriteLine($"\nID: {objetoDog.Id}  \nRACE: {objetoDog.Race}  \nNAME: {Dog.Name}");
    }
}