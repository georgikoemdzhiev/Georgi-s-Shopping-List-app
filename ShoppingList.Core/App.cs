using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using ShoppingList.Core.ViewModels;

namespace ShoppingList.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<CreateListViewModel>();
        }
    }
}