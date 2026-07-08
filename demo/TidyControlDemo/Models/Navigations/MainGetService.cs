using CommunityToolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TidyControlDemo.ViewModels;
using YoYo.Toolkit.Interfaces.Navigations;

namespace TidyControlDemo.Models.Navigations
{
    internal class MainGetService : IGetService
    {
        public object GetService(Type? t)
        {
           return Ioc.Default.GetService(t) ?? throw new Exception($"未找到类型为{t?.ToString()}的服务");
        }

        public FrameworkElement? GetView()
        {
            var mainView = Ioc.Default.GetService<MainViewModel>();
            if(mainView!=null)return mainView.WorkView;
            return null;
        }

        public void SetView(FrameworkElement? frameworkElement)
        {
            var mainView = Ioc.Default.GetService<MainViewModel>();
            if (mainView != null) mainView.WorkView = frameworkElement;
        }
    }
}
