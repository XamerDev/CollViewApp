using Android.Widget;
using CollViewApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace CollViewApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<GroupItems> Items { get; private set; }
        private ObservableCollection<Item> _itemColl1;
        public ObservableCollection<Item> ItemColl1
        {
            get => _itemColl1;
            set { _itemColl1 = value; RaisePropertyChanged(()=>ItemColl1); }
        }

        private ObservableCollection<Item> _itemColl2;
        public ObservableCollection<Item> ItemColl2
        {
            get => _itemColl2;
            set { _itemColl2 = value; RaisePropertyChanged(() => ItemColl2); }
        }
        private ObservableCollection<Item> _itemColl3;
        public ObservableCollection<Item> ItemColl3
        {
            get => _itemColl3;
            set { _itemColl3 = value; RaisePropertyChanged(() => ItemColl3); }
        }
        private ObservableCollection<Item> _itemColl4;
        public ObservableCollection<Item> ItemColl4
        {
            get => _itemColl4;
            set { _itemColl4 = value; RaisePropertyChanged(() => ItemColl4); }
        }
        private ObservableCollection<Item> _itemColl5;
        public ObservableCollection<Item> ItemColl5
        {
            get => _itemColl5;
            set { _itemColl5 = value; RaisePropertyChanged(() => ItemColl5); }
        }
        public Command DeleteCommand
          => new Command(async (parameter) => await Delete((Item)parameter));
        public MainPageViewModel()
        {

            
            Items = new ObservableCollection<GroupItems>();
            ItemColl1 = new ObservableCollection<Item>();
            ItemColl2 = new ObservableCollection<Item>();
            ItemColl3 = new ObservableCollection<Item>();
            ItemColl4 = new ObservableCollection<Item>();
            ItemColl5 = new ObservableCollection<Item>();

            //fetch data simulation
            //items are grouped in 5 collections. for each group I need to calculate an summarize values from items and then show it in group footer
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));
            ItemColl1.Add(new Item("testItem"));

            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));
            ItemColl2.Add(new Item("testItem"));

            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));
            ItemColl3.Add(new Item("testItem"));

            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));
            ItemColl4.Add(new Item("testItem"));

            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));
            ItemColl5.Add(new Item("testItem"));


            Items.Add(new GroupItems("Test1", ItemColl1));
            Items.Add(new GroupItems("Test2", ItemColl2));
            Items.Add(new GroupItems("Test3", ItemColl3));
            Items.Add(new GroupItems("Test4", ItemColl4));
            Items.Add(new GroupItems("Test5", ItemColl5));
        }

        //delete simulation
        //in origin app I looking from which collection i should delete item and recalculate values for this group
        private async Task Delete(Item selectedItem)
        {


            Items[0].Remove(selectedItem);
           

        }
    }
}
