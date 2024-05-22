using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[]args){
        ControlePonto controle = new ControlePonto();

        Gato G1 = new Gato("Julios","Preto");
        Console.WriteLine("Nome: {0}\nCor: {1}",G1.Nome,G1.Cor);
        G1.EmitirSom();
        controle.RegistrarEntrada(G1);
        Roupa R1 = new Roupa("Modelo 1 ");
        Roupa R2 = new Roupa("Modelo 2 ");
        Roupa R3 = new Roupa("Modelo 3 ");

        G1.roupa.Add(R1);
        G1.roupa.Add(R2);
        G1.roupa.Add(R3);
        Console.WriteLine("Minhas roupas: ");
        foreach(Roupa roupas in G1.roupa){
            Console.WriteLine("{0}",roupas.Modelo);
        }

        G1.EmitirSom();
        controle.RegistrarSaida(G1);
        
    }
}

public abstract class Animal{
    public string Nome{get;set;}
    public List<Roupa> roupa{get;set;}

    public Animal(string Nome){
        this.Nome = Nome;
        roupa = new List<Roupa>();
    }

    public abstract void EmitirSom();
}

public class Gato:Animal{
    public string Cor{get;set;}

    public Gato(string Nome, string Cor):base(Nome){
        this.Nome = Nome;
        this.Cor = Cor;
        roupa = new List<Roupa>();
    }

    public override void EmitirSom(){
        Console.WriteLine("MIAUUU");
    }
}

public class Roupa{
    public string Modelo{get;set;}

    public Roupa(string Modelo){
        this.Modelo = Modelo;
    }
}

public class ControlePonto{
    public void RegistrarEntrada(Animal animal){
        GerarComprovante(animal, true);
    }

    public void RegistrarSaida(Animal animal){
        GerarComprovante(animal, false);
    }

    public void GerarComprovante(Animal animal, bool entrada){
        string TipoEntrada = entrada? "Entrando" : "Saindo";
        Console.WriteLine("\n {0} esta {1} na data {2}",animal.Nome,TipoEntrada,DateTime.Now);
        Console.WriteLine("Nome da classe: {0}",animal.GetType().Name);
    }
}