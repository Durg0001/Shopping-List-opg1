using System.Xml.Linq;

namespace Shopping_List
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return Id + Name + Price + Quantity;

        }
    }
}
