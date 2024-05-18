using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[]args){

        //chamando a classe Gato com os atributos
        Gato G1 = new Gato("XAULIN","Viralata","5 anos");
        Console.WriteLine("Nome: {0}\nRaça: {1}\nIdade: {2}",G1.Nome,G1.Raca,G1.idade);
        //Chamando a classe roupa
        Roupa R1 = new Roupa("M", "Preta");
        Roupa R2 = new Roupa("G", "Vermelha");
        Roupa R3 = new Roupa("P", "Verde");
        //adicionando a list
        G1.roupa.Add(R1);
        G1.roupa.Add(R2);
        G1.roupa.Add(R3);
        //exibindo todas as roupas da list
        foreach(Roupa roupas in G1.roupa){
            Console.WriteLine("Tamanho: {0}\nCor: {1}", roupas.Tamanho,roupas.Cor);
        }
        //chamar metodo
        G1.EmitirSom();

    }
}
//Superclasse Animal
public abstract class Animal{
    public string Nome{get;set;}
    public string Raca{get;set;}
    public List<Roupa> roupa{get;set;}
    //construtor 
    public Animal(string Nome,string Raca){
        this.Nome = Nome;
        this.Raca = Raca;
        roupa = new List<Roupa>();
    }

    public abstract void EmitirSom();
}
// Gato herda os atributos de Animal
//Subclasse
public class Gato:Animal{
    public string idade{get;set;}
    //construtor com os atributos de animal
    public Gato(string Nome, string Raca, string idade) : base (Nome,Raca){
        this.Nome = Nome;
        this.Raca = Raca;
        this.idade = idade;
        roupa = new List<Roupa>();
    }
    
    public override void EmitirSom(){
        Console.WriteLine("MIAU");
    }
    
}

public class Roupa{
    public string Tamanho{get;set;}
    public string Cor{get;set;}

    public Roupa(string Tamanho, string Cor){
        this.Tamanho = Tamanho;
        this.Cor = Cor;
    }
}