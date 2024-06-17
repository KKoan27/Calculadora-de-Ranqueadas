using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class main{

    static public string nome;
    public int QuantV;
    public int QuantD;
    public int resultado;

    Random random= new Random();


    public static void Main(){
        do{
        Console.WriteLine("escreva o nome do usuario:");
        nome= Console.ReadLine();

        main mein=new main();
        mein.Rank(nome);  

        Console.WriteLine("Fazer outra analise?(N para não)");
        string x =Console.ReadLine();
        if(x=="N"){
            break;
        } else{
            Console.Clear();
        }

        }while (true);        
    }
    public void  Rank(string nome){
        QuantV=random.Next(300);
        QuantD=random.Next (QuantV-1);
        int Media = QuantV-QuantD;
        string Elo ="";
        if (Media<=10){
            Elo="Ferro";
        } else if(Media>= 11 && Media <=20){
            Elo="Bronze";
        } else if(Media>= 21 && Media <= 50){
            Elo="Prata";
        }else if (Media>= 51 && Media <= 80){
            Elo= "Ouro";
        }else if(Media>= 81 && Media <= 90){
            Elo="Diamante";
        }else if(Media>= 91 && Media <= 100){
            Elo="Lendario";
        }else if(Media>= 101){
            Elo="Imortal";
        }

        Console.WriteLine($"Jogador: {nome} \n Vitorias: {QuantV}  \t Derrotas {QuantD} \n  Classificação{Elo}");
    }
}





