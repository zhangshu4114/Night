using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch {

    public class Program {

        public static void Main(string[] args) {
            Dictionary<string, object> m = new Dictionary<string, object>();
            m.Add("name","liusu");
            m.Add("test", "123456");
            Dictionary<string, object> map = new Dictionary<string, object>(){
                {"name","liuisu"}
            };
            foreach (KeyValuePair<string,object> kv in map) {
                Console.WriteLine(kv.Key+"== "+kv.Value);
            }
        }
        public void SendMessage(ref string content) {
            content = "音无结弦之时,悦动天使之心,立于浮华之世,奏响天籁之音!";
        }
        public void SellHouse(int area, int price) {
            int total = price * area;
            Console.WriteLine("张三想买的这套房价格为: " + total);
        }

    }
}
