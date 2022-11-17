using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class Food_DATA_Item
    {

        public string type { get; set; }    
        public string id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int num_order { get; set; } = 0;
        public string url { get; set; }
        public int total
        {
            get
            {
                return num_order * price;
            }
        }

        public Food_DATA_Item(string id ,string name, int price, int num_order,string type,string Url)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.num_order = num_order;
            this.type = type;
            this.url = Url;

        }
        public Food_DATA_Item()
        {
            url = "";
            id = "";
            name = "";
            num_order = 0;
            price = 0;
            type = "";
        }
    }
}
