using System.Runtime.InteropServices;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Stojis u lesa, kam pujdes? " +
                          "1: Do lesa,   2: Na pole,    3: Do vesnice");
        int a = int.Parse(Console.ReadLine());
        if (a == 1)
        {
            Console.WriteLine("V lese je tma " +
                              "1: Otocis to,    2: Jdes na palouk,   3:Jdes do nejtemnejsiho lesa");
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                Console.WriteLine("Tak zpet domu...*");
            }else if (b == 2){
                Console.WriteLine("Rostou tu houby, a je tu mraveniste 1: Nakoupnes houby,   2: Nakoupnes mraveniste,   3: Sednes si");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("Nebyla to houba, byl to teleport k drakovi 1: Zacnu s drakem bojovat,    2: Utecu,   3:Polibim draka");
                    int d = int.Parse(Console.ReadLine());
                    if(d==1){
                        Console.WriteLine("Byl silnejsi a sezral te *");
                    }else if(d==2){
                        Console.WriteLine("Upekl te dechem na uteku *");
                    }else if (d==3){
                        Console.WriteLine("Promenil se v krasnou princeznu HURA");
                    }else{Console.WriteLine("Nemame takovou odpoved");}
                }else if (c==2){
                    Console.WriteLine("To jsi nemel delat, mravenci se nastvali a ohlodali te az na kost *");
                }else if (c==3){
                    Console.WriteLine("Nastydyl jsi, dostal zapach plic a umrel *");
                }else{Console.WriteLine("Nemame takovou odpoved");}
            }else if (b == 3)
            {
                Console.WriteLine("Neco te potme sezralo, kdo vi, co to bylo *");
            }else{Console.WriteLine("Nemame takovou odpoved");}
        }else if (a == 2)
        {
            Console.WriteLine("Strniste picha, balis to a jdes domu");
        }else if (a==3){
            Console.WriteLine("Ze mas jinou barvu kuze, vesnicani se na tebe vrhli a zbili te");
        }else{
            Console.WriteLine("Nemame takovou odpoved");
        }
    }
}