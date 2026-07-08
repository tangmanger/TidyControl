using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TidyControlDemo.Models.Navigations;
using TidyControlDemo.Views;
using YoYo.Toolkit.Interfaces.Navigations;

namespace TidyControlDemo.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                .AddSingleton<IGetService, MainGetService>()
                .AddSingleton<INavigate, MainNavigation>()
                .AddSingleton<MainViewModel>()
                .AddSingleton<ButtonView>()
                .AddSingleton<ButtonViewModel>()
                .BuildServiceProvider());
        }
        public MainViewModel Main => Ioc.Default.GetService<MainViewModel>();
    }
}
