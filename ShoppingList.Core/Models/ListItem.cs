using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace ShoppingList.Core.Models
{
    public class ListItem : MvxViewModel
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}