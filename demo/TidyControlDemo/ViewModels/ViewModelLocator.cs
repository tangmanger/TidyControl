using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidyControlDemo.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                    .AddSingleton<MainViewModel>()
                    .BuildServiceProvider());
        }
        public MainViewModel Main => Ioc.Default.GetService<MainViewModel>();
    }
}
