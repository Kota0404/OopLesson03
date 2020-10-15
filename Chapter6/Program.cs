using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            #region p177まで
            /* var numbers = new List<int> { 9, 7, -5, 4, 2, 5, -4, 0, 4, -1, 0, 4, };
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
           */




            //600ページを超える書籍があるかどうか
            /*  if (books.Any(s => s.Pages >= 600)) {
                  Console.WriteLine("600ページを超える本はあります");
              } else {
                  Console.WriteLine("600ページを超える本はありません");
              }*/
            //Console.WriteLine(books.Any(s => s.Pages >= 200) ? "600ページを超える本はあります" : "600ページを超える本はありません");
            //すべて200ページ以上の書籍か
            /* if (books.All(s => s.Pages >= 200)) {
                 Console.WriteLine("全て２００ページを超えています");
             } else {
                 Console.WriteLine("全て２００ページを超えていません");
             }*/
            //Console.WriteLine(books.Any(s => s.Pages >= 200) ? "全て２００ページを超えています" : "全て２００ページを超えていません");
            //400ページを超える本は何冊目か
            /*var point = books.FirstOrDefault(x => x.Pages >= 400);
             for(int i = 0;i<books.Count;i++) {
                 if(books[i].Title == point.Title) {
                     Console.WriteLine($"最初に四百ページを超える本は{i+1}冊目にあります");
                     break;
                 }
             }*/
            /*var count = books.FindIndex(x => x.Pages >=400);
            Console.WriteLine(count+1);*/

            //本の値段が400円以上のもの3冊表示
            // books.Where(s => s.Price >= 400).Take(3).ToList().ForEach(s=>Console.Write(s.Title+" "));
            #endregion
            #region P180まで
            //整数の例
            /* var numbers =
                new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };
            var strings = numbers.Distinct().ToArray();
            foreach (var item in strings) {
                Console.WriteLine(item + " ");
            }

            numbers.Select(n => n.ToString("0000")).ToList().ForEach(s=> Console.WriteLine(s+" "));

            //並べ替え
             numbers.Distinct().OrderBy(n => n).ToList().ForEach(Console.WriteLine);
            //文字列の例
            var words = new List<string> {
                "Microsoft","Apple","Google","Oracle","Facebook"
            };
            var lower = words.Select(name => name.ToLower()).ToArray();
            //オブジェクトの例
            var books = Books.GetBooks();
            //タイトルリスト
            var titles = books.Select(b => b.Title);
            foreach (var title in titles) {
                Console.WriteLine(title + " ");
            }
            Console.WriteLine("-----------");
            //ページの多い順に並べ替え
            books.OrderByDescending(b => b.Pages).ToList().ForEach(b => Console.WriteLine(b.Title));
            */
            #endregion
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            // 6-1-1
            Console.WriteLine("----6-1-1----");
            int mnumber = numbers.Max();
            Console.WriteLine(mnumber);

            //6-1-2
            Console.WriteLine("----6-1-2----");
            //numbers.Reverse().Take(2).ToList().ForEach(s=> Console.Write(s+" "));
            int pos = numbers.Length - 2;
            foreach (var item in numbers.Skip(pos)) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //6-1-3
            Console.WriteLine("----6-1-3----");
            numbers.Select(n => n.ToString()).ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();

            //6-1-4
            Console.WriteLine("----6-1-4----");
            numbers.OrderBy(n => n).Select(n => n).Take(3).ToList().ForEach(Console.WriteLine);

            //6-1-5
            Console.WriteLine("----6-1-5----");
            var numberover = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(numberover);

            var books = new List<Book> {
   new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
   new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
   new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
   new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
   new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
   new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
   new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            
            };
            //全ての書籍から[C#]の文字がいくつあるかカウントする
            int count = 0;

            foreach (var book in books.Where(b=> b.Title.Contains("c#"))) {
                for(int i =0; i< book.Title.Length-1; i++) {
                    if((book.Title[i] == 'C')&&(book.Title[i+1] == '#')){
                        count++;
                    }
                }
            }
            Console.WriteLine($"文字列「C#]の個数は{count}です。");

            //6-2-1
            Console.WriteLine("----6-2-1----");
            books.Where(s => s.Title == "ワンダフル・C#ライフ").ToList().ForEach(b => Console.WriteLine($"価格は{b.Price}ページ数は{b.Pages}"));

            //6-2-2
            Console.WriteLine("----6-2-2----");
            var bookc = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(bookc);

            //6-2-3
            Console.WriteLine("----6-2-3----");
            var bookap = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(bookap);

            //6-2-4
            Console.WriteLine("----6-2-4----");
            var bookprice = books.FirstOrDefault(b => b.Price >= 4000);
            if (bookprice != null) {
                Console.WriteLine(bookprice.Title);
            }
            //6-2-5
            Console.WriteLine("----6-2-5----");
            var bookpage = books.Where(b => b.Price < 4000).Max(b => b.Pages);
            Console.WriteLine(bookpage);

            //6-2-6
            Console.WriteLine("----6-2-6----");
            books.Where(b => b.Pages >= 400).OrderBy(b => b.Price).ToList().ForEach(b => Console.WriteLine(b.Title + " " + b.Price));

            //6-2-7
            Console.WriteLine("----6-2-7----");
            books.Where(b => b.Pages <= 500 && b.Title.Contains("C#")).ToList().ForEach(b => Console.WriteLine(b.Title));
        }
    }

}


