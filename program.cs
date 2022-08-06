using System;

class Program
{
    static void Main(string[] args)
    {
        int valor=0;
        char escolha;
        Random aleatorio = new Random();
        Console.WriteLine("Escolha o dado");
        escolha=char.Parse(Console.ReadLine());
        switch(escolha){
            case '1':
            valor = aleatorio.Next(1, 4);
            break;

            case '2':
             valor = aleatorio.Next(1, 6);
            break;

            case '3':
            valor = aleatorio.Next(1, 8);
            break;

            case '4':
            valor = aleatorio.Next(1, 10);
            break;

            case '5':
            valor = aleatorio.Next(1, 12);
            break;

            case '6':
            valor = aleatorio.Next(1, 16);
            break;

            case '7':
            valor = aleatorio.Next(1, 20);
            break;

            case '8':
            valor = aleatorio.Next(1, 30);
            break;

            case '9':
            valor = aleatorio.Next(1, 100);
            break;

            default:
            valor = -1;
            break;

        }

        if(valor<0){
            Console.WriteLine("Dado indisponivel");
        }else{
            Console.WriteLine($"O valor foi {valor}");
        }
    }   

}
