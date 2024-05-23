using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Gato Gat1 = new Gato("BOB", "Viralata");
        Cachorro Cach1 = new Cachorro("Renata", "Viralata");
        Veterinario Vet1 = new Veterinario("Joao", "123456456");
        Vet1.animais.Add(Gat1);
        Vet1.animais.Add(Cach1);

        foreach (Animal todosAnimais in Vet1.animais)
        {
            Console.WriteLine("{0}\n{1}", todosAnimais.Nome, todosAnimais.Raca);
        }

        Vet1.Examinar(Gat1);
        Vet1.Examinar(Cach1);

        Vet1.Examinar1(Vet1.animais);
    }
}

public abstract class Animal
{
    public string Nome { get; set; }
    public string Raca { get; set; }

    public Animal(string Nome, string Raca)
    {
        this.Nome = Nome;
        this.Raca = Raca;
    }

    public abstract void EmitirSom();
}

public class Gato : Animal
{
    public Gato(string Nome, string Raca) : base(Nome, Raca) { }

    public override void EmitirSom()
    {
        Console.WriteLine("MIAU");
    }
}

public class Cachorro : Animal
{
    public Cachorro(string Nome, string Raca) : base(Nome, Raca) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Au Au");
    }
}

public class Veterinario
{
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public List<Animal> animais { get; set; }

    public Veterinario(string Nome, string CNPJ)
    {
        this.Nome = Nome;
        this.CNPJ = CNPJ;
        animais = new List<Animal>();
    }

    public void Examinar(Animal animal)
    {
        Console.WriteLine("Inicio do Exame");
        animal.EmitirSom();
         
        Console.WriteLine("Nome: {0}", animal.GetType().Name);
        Console.WriteLine("FIM do Exame");
    }

    public void Examinar1(List<Animal> animais)
    {  
        Console.WriteLine("Lista de Animais:");
        
        foreach (Animal Todosanimal in animais)
        {
            Console.WriteLine("Nome: {0}, Raça: {1}", Todosanimal.Nome, Todosanimal.Raca);
        }
    }
}

public class Clinica
{
    public string RazaoSocial { get; set; }

    public Clinica(string RazaoSocial)
    {
        this.RazaoSocial = RazaoSocial;
    }
}
