using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using ShoppingList.Core.Models;

namespace ShoppingList.Core.ViewModels
{
    public class CreateListViewModel : MvxViewModel
    {
        public override Task Initialize()
        {
            ShoppingLists.Add(new ListItem
            {
                Title = "Test"
            });

            AddCmd = new MvxCommand(() =>
            {
                Debug.WriteLine("Click");
            });
            return base.Initialize();
        }


        private MvxObservableCollection<ListItem> _shoppingLists = new MvxObservableCollection<ListItem>();

        public MvxObservableCollection<ListItem> ShoppingLists
        {
            get => _shoppingLists;
            set => SetProperty(ref _shoppingLists, value);
        }

        public ICommand AddCmd { get; set; }
    }
}