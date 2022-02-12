using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   public class Distance
    { 
        public int start = 10;
        public int finsh = 100;
        public int result;
        int variable;
        int sum=0;
        public void ShowText()
        {   
            string s = "Начав тренировки, лыжник в первый день пробежал 10 км. " +
                "Через каждый следующий день (между тренировками один день интервала)" +
                " он увеличивал пробeг на 10% от пробега предыдущего дня. Определить в " +
                "какой день суммарный пробег за все дни превысит 100 км.";
            Console.WriteLine(s);
        }
        public void CountSimple (ref int s,  int f)
        {
            
            int count = 0;
            while (sum<=f)
            {
                variable=(int)(s * 0.1) + s; //для просчета результата за каждую послед. тренировку

                s = variable;
                sum += s;
                count++;               

            }
            result = (count * 2) - 1;
            
            Console.WriteLine();
            Console.WriteLine("Ответ.С учетом превышения заданного сумарного показателя дистанции в 100 км");

            Console.WriteLine($"{count} - без учета выходных , {result} - с учетом выходных" ) ;
        }
        
    }
}
