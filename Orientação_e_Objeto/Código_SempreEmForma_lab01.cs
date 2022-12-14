using System;

namespace SempreEmForma
{ 

 public class Pessoa
 {
   private int peso;
   private double altura;
   private string nome;
   
   //Construtor
   Pessoa(int peso, double altura, string nome)
   {
     this.peso   = peso;
     this.altura = altura;
     this.nome = nome;
   } 

   //Métodos GET
   public int getPeso()
   {
      return(peso);     
   }

   public double getAltura()
   {
      return(altura);     
   }
   
    public string getNome()
    {
        return(nome);     
    }

   //Métodos SET
   public void setPeso(int peso)
   {
     this.peso = peso;    
   }

   public void setAltura(double altura)
   {
     this.altura = altura;    
   }
   
    public void setNome(string nome)
    {
        this.nome = nome;    
    }
     
   //Métodos Geral
   public double resultado()
   {
     double IMC;
     IMC = peso / (altura * altura);
     return IMC; 
   }
   
   public int Pesomaisoumenos()
   {
     double IMC;
     IMC = peso / (altura * altura);
     
     int pesomaisoumenos = 0;
     
     if(IMC < 18.5)
     {
         pesomaisoumenos = peso + 10;
     }
     else if(IMC >= 25)
     {
         pesomaisoumenos = peso - 10;
     }
     else if(IMC >= 18.5 && IMC < 25)
     {
         pesomaisoumenos = peso;
     }
     return pesomaisoumenos;
   }

   public string TabelaIMC(){
        
        double IMC = 0;
        IMC = peso/(altura * altura);
        
        if(IMC < 18.5)
        {
            return "BAIXO";
        }
        else if(IMC >= 18.5 && IMC < 25)
        {
            return "NORMAL";
        }
        else
        {
            return "ALTO";
        }
    }

   //Destrutor
    
    ~Pessoa()
    {
     
    } 
    
    public static void Main(){
        
        int peso;
        double altura;
        string nome;
        try{
            
            Console.Write ("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.Write ("Qual seu peso? ");
            peso =  int.Parse(Console.ReadLine ());

            Console.Write ("Qual sua altura? ");
            altura = float.Parse(Console.ReadLine ());
            
            Pessoa pessoa1 = new Pessoa(peso, altura, nome); //(62, 1.55, Rafa);
       
            Console.WriteLine("O nome da pessoa é {0}", pessoa1.getNome());
            Console.WriteLine("O peso de {0}", pessoa1.getNome() + " é: " + pessoa1.getPeso()); 
            Console.WriteLine("A altura de {0}", pessoa1.getNome() + " é: " + pessoa1.getAltura()); 
           
            Console.WriteLine("O IMC de {0}", pessoa1.getNome() + " é: " + pessoa1.resultado().ToString("F2")); 
            Console.WriteLine("O IMC de {0}", pessoa1.getNome() + " é: " + pessoa1.TabelaIMC());
            
            Console.WriteLine("Engordando ou emagrecendo 10 kilos...");
            Console.WriteLine(pessoa1.getNome() + " pesa " + pessoa1.Pesomaisoumenos(), " Kg agora");

        }   catch(Exception erro){ 
            Console.WriteLine("Formato de entrada errado!\n");
            Console.WriteLine("Erro: " + erro.Message);
        }
}/*Main*/

}/*Classe*/

}/*SempreEmForma*/
