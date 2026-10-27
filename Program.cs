class Animal
{
    public string Nome {get; set;}
    public int Idade {get; set;}

    
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade) { }
    
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo: Au au!");
    }
}

class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade) { }
    
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE ANIMAIS ===\n");

        List<Animal> animais = new List<Animal>();
        animais.Add(new Cachorro("Rex", 3));
        animais.Add(new Gato("Mimi", 2));

        foreach (var a in animais)
        {
            Console.WriteLine($"Animal: {a.Nome}");
            Console.WriteLine($"Idade: {a.Idade} anos");
            Console.Write("Som: ");
            a.EmitirSom();
            Console.WriteLine();
        }
    }
}