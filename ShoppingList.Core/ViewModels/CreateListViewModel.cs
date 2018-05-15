using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace ShoppingList.Core.ViewModels
{
    public class CreateListViewModel : MvxViewModel
    {
        private string _test = "Georgi";

        public string Test
        {
            get => _test;
            set => SetProperty(ref _test, value);
        }
    }
}