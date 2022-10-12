namespace CollViewApp.Models
{
    public class Item
    {
        public string Name { get; private set; }
        public Item(string name)
        {
            Name = name;
        }
    }
}
