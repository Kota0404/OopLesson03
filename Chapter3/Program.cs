using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3 {
    class Program {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            //問題3-1.1
            Console.WriteLine("------3.1.1------");
            var query = numbers.Exists(s => s %8 == 0|| s%9 ==0);
            if (query) {
                Console.WriteLine("あります");
            } else {
                Console.WriteLine("ありません");
            }
            //問題3-1.2
            Console.WriteLine("------3.1.2------");
            numbers.ForEach(s => Console.Write(s/2.0+","));
            Console.WriteLine();
            //問題3-1.3
            Console.WriteLine("------3.1.3------");
            numbers.Where(s => s >= 50).ToList().ForEach(s => Console.Write(s+","));
            Console.WriteLine();
            //問題3-1.4
            Console.WriteLine("------3.1.4------");
            List<int> lists = numbers.Select(s => s * 2).ToList();
            foreach (var item in lists) {
                Console.Write(item+",");
            }
            Console.WriteLine();

            var names = new List<string> {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong"
            };
            //問題3-2.1
            Console.WriteLine("------3.2.1------");
            Console.WriteLine("検索都市名を入力してください。空行で終了");
            do {
                string key = Console.ReadLine();
                if (string.IsNullOrEmpty(key)) {
                    break;
                }
                var number = names.FindIndex(s => s == key);
                Console.WriteLine($"{key}はリストの{number}番目にあります");
            } while (true);
            //問題3-2.2
            Console.WriteLine("------3.2.2------");
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
            //問題3-2.3
            Console.WriteLine("------3.2.3------");
            names.Where(s => s.Contains("o")).ToList().ForEach(Console.WriteLine);
            //問題3-2.4
            Console.WriteLine("------3.2.4------");
             names.Where(s => s.Substring(0, 1) == "B").Select(s => s.Length).ToList().ForEach(Console.WriteLine);
            
            #region   
            /* var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };
            // IEnumerable<string> query = names.Where(s => s.Length <= 5);
            var query = names.Where(s => s.Length <= 5).ToList();
            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------");
            names[0] = "Osaka";
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }*/
            //list.ForEach(s => Console.WriteLine(s));

            // names.ConvertAll(s => s.ToUpper()).ForEach(s => Console.WriteLine(s));
            #endregion
        }
    }
}
