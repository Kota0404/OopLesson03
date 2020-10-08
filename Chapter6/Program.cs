using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, -4, 0, 4, -1, 0, 4, };
            Console.WriteLine($"平均値：{numbers.Average()}");
            Console.WriteLine($"合計値：{numbers.Sum()}");
            Console.WriteLine($"最小値：{numbers.Where(s => s > 0).Min()}");
            Console.WriteLine($"最大値：{numbers.Max()}");
            bool exists = numbers.Any(n => n % 7 == 0);

            var books = Books.GetBooks();

            var results = numbers.Where(s => s > 0).Take(3);
            foreach (var item in results) {
                Console.WriteLine(results + " ");
            }


            Console.WriteLine($"本の平均価格：{books.Average(s => s.Price)}");
            Console.WriteLine($"本の合計価格:{books.Sum(s => s.Pages)}");
            Console.WriteLine($"本のページが最大:{books.Max(s => s.Pages)}");
            Console.WriteLine($"高価な本:{books.Max(s => s.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数:{books.Count(s => s.Title.Contains("物語"))}");
            //600ページを超える書籍があるかどうか
            /*  if (books.Any(s => s.Pages >= 600)) {
                  Console.WriteLine("600ページを超える本はあります");
              } else {
                  Console.WriteLine("600ページを超える本はありません");
              }*/
            Console.WriteLine(books.Any(s => s.Pages >= 200) ? "600ページを超える本はあります" : "600ページを超える本はありません");
            //すべて200ページ以上の書籍か
           /* if (books.All(s => s.Pages >= 200)) {
                Console.WriteLine("全て２００ページを超えています");
            } else {
                Console.WriteLine("全て２００ページを超えていません");
            }*/
            Console.WriteLine(books.Any(s => s.Pages >= 200) ? "全て２００ページを超えています" : "全て２００ページを超えていません");
            //400ページを超える本は何冊目か
            /*var point = books.FirstOrDefault(x => x.Pages >= 400);
             for(int i = 0;i<books.Count;i++) {
                 if(books[i].Title == point.Title) {
                     Console.WriteLine($"最初に四百ページを超える本は{i+1}冊目にあります");
                     break;
                 }
             }*/
            var count = books.FindIndex(x => x.Pages >=400);
            Console.WriteLine(count+1);

            //本の値段が400円以上のもの3冊表示
             books.Where(s => s.Price >= 400).Take(3).ToList().ForEach(s=>Console.Write(s.Title+" "));
        }

    }
}
