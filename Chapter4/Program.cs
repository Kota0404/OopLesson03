using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            #region null合体演算子
            /*    string code = "12345";

            var message = GetMessage(code) ?? DefaultMessage();
            Console.WriteLine(message);

        }
        private static object DefaultMessage() {
            return "DefaultMessage";
        }

        private static object GetMessage(string code) {
            return 123;
        }*/
            #endregion
            #region null条件式
            /* Console.WriteLine(GetProduct());
         }
         private static string GetProduct() {
             Sale sale = new Sale {
                 ShopName = "pet store",
                 Product = "food"
             };
             return sale?.Product;

         }*/
            #endregion
            #region
            /* class Sale {
                 //店舗名
                 public string ShopName { get; set; }
                 //売上高
                 public int Amount { get; set; } = 1000000;
                 public string Product { get; set; }
             }*/
            #endregion
            //4.2.1
            Console.WriteLine("-----4.2.1-----");
            var numCollecttion = new YearMonth[5];
           
            for(int i =0; i<5; i++) {
                Console.WriteLine("年と月を入力してください");
                Console.WriteLine("年：");
                int year = int.Parse( Console.ReadLine());
                Console.WriteLine("月:");
                int month = int.Parse(Console.ReadLine());
                YearMonth yearmonth = new YearMonth(year,month);
                numCollecttion[i] = yearmonth;
            }


            //4.2.2
            Console.WriteLine("-----4.2.2-----");
            foreach (var key in numCollecttion) {
                Console.WriteLine($"{key.Year}年{key.Month}月");
            }

            //4.2.4
            Console.WriteLine("-----4.2.4-----");
            var yearmoonth = FindFirst21C(numCollecttion);
           var s = FindFirst21C(numCollecttion).ToString()?? "21世紀はありません";
            //var s= yearmoonth == null ? "21世紀はありません" : yearmoonth.ToString() ;
            Console.WriteLine(s);
            
            
            //4.2.5
            Console.WriteLine("-----4.2.5-----");
            Exercise2_5(numCollecttion);
           
            
            //4.2.3  
        }
         static YearMonth FindFirst21C(YearMonth[] year) { 
            foreach (var key in year) {
                if (key.Is21Century) {
                    return key;
                } 
            }
            return null;
        }

        //4.2.5
        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
