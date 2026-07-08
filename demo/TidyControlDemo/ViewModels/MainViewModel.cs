using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YoYo.Toolkit.Interfaces.Navigations;

namespace TidyControlDemo.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private FrameworkElement? workView;

        INavigate? Navigate { get; set; }

        public MainViewModel(INavigate? navigate)
        {
            Navigate = navigate;
        }

        #region 属性

        public FrameworkElement? WorkView
        {
            get => workView;
            set
            {
                workView = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region 命令

        public RelayCommand LoadedCommand => new RelayCommand(() =>
        {


        });

        public RelayCommand<string> NavigateCommand => new RelayCommand<string>((s) =>
        {
            Navigate?.GoTo(s);

        });


        #endregion
    }
}
