using System.Collections.Immutable;

namespace massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("massivin ölçüsünü daxil edin--");
            //int a=int.Parse(Console.ReadLine());
            //int[] ededler =new int[a];
 
            //int s = 0;

            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    ededler[i] = int.Parse(Console.ReadLine());
            //    s=s+ededler[i];
            //}

            //Console.WriteLine(s);







            






            //massivin en böyük elementini tapır
            Console.Write("massivin ölçüsünü daxil edin--");
            int a=int.Parse(Console.ReadLine());

            int [] ededler =new int[a];
            
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = int.Parse(Console.ReadLine());
               
            }
 
            int b = ededler[0];
 
            
            for (int i = 0; i < ededler.Length; i++)
            {
                
                if (b <= ededler[i])
                {
                    b = ededler[i];
                }
            }
            Console.WriteLine(b);
            

        }
    }
}