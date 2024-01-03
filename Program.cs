
namespace Tydzien4PracaDomowa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę, sprawdzę czy jest ona parzysta czy nieparzysta: ");
            var number = GetNumber();
            if(number%2==0)
            {
                Console.WriteLine("Podana przez Ciebie liczba jest parzytsa");
            }
            else
            {
                Console.WriteLine("Podana przez Ciebie liczba jest nieparzysta");
            }
            
            
        }

        private static int GetNumber()
        {
            while(true) 
            {
                if(!int.TryParse(Console.ReadLine(), out int number))   //jezeli wprowadzona wartośc jest inna niz liczba -> wykonaj kod w klamrach
                {
                    Console.WriteLine("Wprowadziłeś wartośc inną niż liczbę. Podaj liczbę: ");
                    continue;   //dzięki continue, iteracja jest przerywana i dalszy kod po tej linijce nie jest wykonywany -> przechodzi do linijki 18
                    
                }
                return number;
            }
        }
    }
}
