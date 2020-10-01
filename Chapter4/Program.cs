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
            Console.WriteLine(GetProduct());
        }
        private static string GetProduct() {
            Sale sale = new Sale {
                ShopName = "pet store",
                Amount = 100000,
                Product = "food"
            };
            sale = null;
            return sale?.Product;
            
        }
        #endregion

        class Sale {
            //店舗名
            public string ShopName { get; set; }
            //売上高
            public int Amount { get; set; }
            public string Product { get; set; }
        }
    }
}
