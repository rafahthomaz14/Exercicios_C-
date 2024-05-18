using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[]args){
        //Definindo o nome e os atributos da classe Gerente
        Gerente G1 = new Gerente("Rafael","123.456.789-12",1000);
        //Exibindo os dados e no final exibindo o valor do metodo
        Console.WriteLine("Nome: {0}\nCPF: {1}\nSalario: {2}\n",G1.Nome,G1.CPF,G1.CalcularSalario());
        // Definindo os emails
        Email E1 = new Email("RafaelThomaz@gmail.com");
        Email E2 = new Email("Thomaz@gmail.com");
        // adicionando os emails na list
        G1.email.Add(E1);
        G1.email.Add(E2);

        Console.WriteLine("Meus Emails:");

        //Exibindo todos os emails adicionado 
        foreach(Email emails in G1.email){
            Console.WriteLine("Email: {0}",emails.conta);
        }
    }
}

// SuperClasse Funcionario
public abstract class Funcionario{
    public string Nome{get;set;}
    public string CPF{get;set;}
    // A list<Email> só vai ser adicionada como public na SuperClasse
    public List<Email> email{get;set;}
    //Construtor padrao 
    public Funcionario(string Nome,string CPF){
        this.Nome= Nome;
        this.CPF = CPF;
        email = new List<Email>();
    }

    //usamos o protected const para deixar um valor fixo nessa classe
    protected const double SalarioMinimo = 1500;
    //criar o metodo
    public abstract double CalcularSalario();
}
//Criando a classe Gerente herdando os atributos da SuperClasse Funcionario
public class Gerente:Funcionario{
    public double Bonificacao{get;set;}
    // definindo os atributos de funcionario e usando  o : base para chamar o construtor
    public Gerente(string Nome,string CPF, double Bonificacao): base (Nome,CPF){
        this.Nome = Nome;
        this.CPF = CPF;
        this.Bonificacao = Bonificacao;
        email = new List<Email>();
    }
    
    public override double CalcularSalario(){
        return Bonificacao+(6*SalarioMinimo);
    }
}

public class Email{
    public string conta{get;set;}

    public Email(string conta){
        this.conta = conta;
    }
}