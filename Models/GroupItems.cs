using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollViewApp.Models
{
    public class GroupItems : ObservableCollection<Item>
    {
        public string Name { get; private set; }
        //here I need to have this collection for calculations and summarizing items per particular group
        public ObservableCollection<Item> Items { get; private set; }
        public GroupItems(string name, ObservableCollection<Item> items) : base(items)
        {
            Name = name;
            Items = items;
        }
    }
}
