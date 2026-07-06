using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidyControlDemo.ViewModels
{
    public class MainViewModel : ObservableObject
    {

        #region 命令

        public RelayCommand LoadedCommand => new RelayCommand(() =>
        {


        });

        #endregion
    }
}
