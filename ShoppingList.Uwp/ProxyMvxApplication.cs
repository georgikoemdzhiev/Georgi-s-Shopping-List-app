using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace ShoppingList.Uwp
{
    public class ProxyMvxApplication : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}