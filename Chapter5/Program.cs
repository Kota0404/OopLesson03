using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5 {
    class Program {
        static void Main(string[] args) {
            //5.1.1
            Console.WriteLine("-----5, 1, 1----");
            Console.WriteLine("文字列1");
            string m1 = Console.ReadLine();
            Console.WriteLine("文字列2");
            string m2 = Console.ReadLine();
            if (string.Compare(m1, m2,ignoreCase: true) == 0)
                Console.WriteLine("等しい");
            else {
                Console.WriteLine("等しくない");
            }
            //5.2.1
            Console.WriteLine("-----5, 2, 1----");
            int num;
           if( int.TryParse(Console.ReadLine(),out num)) {
               // var s1 = $"{num:#,0}";
                Console.WriteLine(num.ToString("#,#"));
            } else {
                Console.WriteLine("数値文字列ではありません。");
            }

          //5.3.1
            Console.WriteLine("-----5, 3, 1----");
            var jack = "Jackdaws love my big sphinx of quartz";
           var counts = jack.Count(s => s.ToString() == " ");
            Console.WriteLine(counts);
           
            //5.3.2
            Console.WriteLine("-----5, 3, 2----");
            var minjack = jack.Replace("big", "small");
            Console.WriteLine(minjack);

            //5.3.3
            Console.WriteLine("-----5, 3, 3----");
            var jacks = jack.Split(' ');
            foreach (var item in jacks) {
                Console.WriteLine(item);
            }
            Console.WriteLine(jacks.Length);


            //5.3.4
            Console.WriteLine("-----5, 3, 4----");
            //var jacklon = new List<string>();
            jacks.Where(s=> s.Length >= 4).ToList().ForEach(Console.WriteLine);
            /* foreach (var item in jacks) {
                if(item.Length >= 4) {
                    jacklon.Add(item);
                }
            }
            foreach (var item in jacklon) {
                Console.WriteLine(item);
            }*/

            //5.3.5
            Console.WriteLine("-----5, 3, 5----");
            // var jacks = jack.Split(' ');
            var jacks2 = jack.Split(' ').ToArray();
            var sd = new StringBuilder(jack[0]);
            foreach (var item in jacks2.Skip(1)) {
                sd.Append(" ");
                sd.Append(item);
            }
            Console.WriteLine( sd.ToString());


            //5.4.1
            Console.WriteLine("-----5, 4, 1----");
            string histry="Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            foreach (var item in histry.Split(';')) {
                var word = item.Split('=');
                Console.WriteLine("{0}:{1}", Tojapanese(word[0]), word[1]);
            }
           
        }
        static string Tojapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "    ";
            }
        }
    }
}
