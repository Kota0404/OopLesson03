using Section01;
using Section02;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
    class Program {
        //static  Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>() { };
        static Dictionary<char, int> dict = new Dictionary<char, int>() { };
        static void Main(string[] args) {
            #region ディクショナリー
            /*  var employeeDict = new Dictionary<int, Employee>() {
            /* ["sunflower"] = 400,
             ["pansy"] = 300,
             ["tulip"] = 350,
             ["rose"] = 500,
             ["dahlia"] = 450
            {100,new Employee(100,"清水遼久") },
            {112,new Employee(112,"芹沢洋和") },
            {125,new Employee(125,"岩瀬奈央子") },

        };
        employeeDict.Where(emp => emp.Value.Id % 2 == 0).ToList().ForEach(emp => Console.WriteLine(emp.Value.Name));
    */
            //リスト
            /*    var employee = new List<Employee>() {
                    new Employee(100,"清水遼久"),
                    new Employee(112,"芹沢洋和"),
                    new Employee(125,"岩瀬奈央子"),
                    new Employee(143,"山田太郎"),
                    new Employee(148,"池田次郎"),
                    new Employee(152,"高田三郎"),
                    new Employee(155,"石川幸也"),
                    new Employee(161,"中沢信也"),
                };

                var emploDict = employee.Where(emp => emp.Id % 2 == 0).ToDictionary(emp => emp.Id);
                foreach (var item in emploDict) {
                    Console.WriteLine($"{item.Value.Id}{item.Value.Name}");
                }
                //foreach (KeyValuePair<int,Employee> item in employeeDict) {
                    //Console.WriteLine($"{item.Value.Id}={item.Value.Name}");
               // }
                */
            #endregion
            #region p190
            /*  var dict = new Dictionary<MonthDay, string> {
                {new MonthDay(3,5),"珊瑚の日" },
                {new MonthDay(8,4),"箸の日" },
                {new MonthDay(10,3),"登山の日" }

            };

            var md = new MonthDay(8,4);
            var s = dict[md];
            Console.WriteLine(s);*/
            #endregion
            #region ディクショナリー登録、表示
            //Console.WriteLine("**********************");
            //Console.WriteLine("* 辞書登録プログラム *");
            //Console.WriteLine("**********************");
            //bool roop = true;
            //while (roop) {
            //    Console.WriteLine("1．登録　2．内容を表示 3.終了");
            //    int hantei = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"<{hantei}");
            //    switch (hantei) {
            //        case 1:
            //            AddD();
            //            break;
            //        case 2:
            //            saidD();
            //            break;
            //        case 3:
            //            roop = false;
            //            break;
            //    }

            //} 
            #endregion
            Console.WriteLine("----7-1----");
            string code = "Cozy Lummox gives smart squid who asks for job pen";
            foreach (var item in code.ToUpper()) {
                if ('A' <= item && item <= 'Z') {
                    if (dict.ContainsKey(item)) {
                        int value = dict[item] + 1;
                        dict[item] = value;
                    } else {
                        dict.Add(item, 1);
                    }
                }
            }
           
            foreach (var item in dict) {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
        #region  ディクショナリ－に追加、初期化、列挙
        /*  var lines = File.ReadAllLines("sample.txt");
          var we = new WordsExtractor(lines);

          foreach (var item in we.Extract()) {
              Console.WriteLine(item);
          }
          DuplicateKeySample();

      }
   static  public void DuplicateKeySample() {
          // ディクショナリの初期化
          var dict = new Dictionary<string, List<string>>() {
             { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
             { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
          };

          // ディクショナリに追加
          var key = "EC";
          var value = "電子商取引";
          if (dict.ContainsKey(key)) {
              dict[key].Add(value);
          } else {
              dict[key] = new List<string> { value };
          }

          // ディクショナリの内容を列挙
          foreach (var item in dict) {
              foreach (var term in item.Value) {
                  Console.WriteLine("{0} : {1}", item.Key, term);
              }
          }
      }*/
        #endregion

        #region ディクショナリー　登録　表示メソッド
        //登録メソッド
        // static public  void AddD() {
        //     Console.Write("KEYを入力：");
        //     string key = Console.ReadLine();
        //     Console.Write("VALUEを入力：");
        //     string value = Console.ReadLine();
        //     if (dict.ContainsKey(key)) {
        //         dict[key].Add(value);
        //     } else {
        //         dict[key] = new List<string> { value };
        //         Console.WriteLine("登録しました");
        //     }
        // }
        //表示メソッド
        //static private void saidD() {
        //     foreach (var item in dict) {
        //         foreach (var item2 in item.Value) {
        //             Console.WriteLine($"{item.Key} : {item2}");
        //         }
        //     }
        // }
        #endregion

        
    }
}
