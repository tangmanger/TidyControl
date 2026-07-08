using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TidyControlDemo.Attributes;
using YoYo.Toolkit.Interfaces.Navigations;
using YoYo.Toolkit.Models.Navigations;
using YoYo.Toolkit.Navigations;

namespace TidyControlDemo.Models.Navigations
{
    internal class MainNavigation : BaseNavigation
    {
        private List<NavigateModel> _navigates = new List<NavigateModel>();

        public MainNavigation(IGetService getService) : base(getService)
        {
        }

        public override string NavigationName => "主页面导航";

        public override List<NavigateModel> Navigates => _navigates;

        public override void InitView()
        {
            _navigates = GetNavigates();
        }
        /// <summary>
        /// 获取所有的导航信息
        /// </summary>
        /// <returns></returns>
        public List<NavigateModel> GetNavigates()
        {

            var _navigates = new List<NavigateModel>();
            var types = GetAlTypes();
            foreach (var item in types)
            {
                var toolAttribute =
               Attribute.GetCustomAttribute(item, typeof(TidyControlAttribute)) as TidyControlAttribute;
                if (toolAttribute != null)
                {
                    _navigates.Add(new NavigateModel()
                    {
                        Type = toolAttribute.ViewType,
                        ViewType = toolAttribute.ViewKey,
                        VMType= toolAttribute.ViewModelType
                    });
                }
            }
            return _navigates;
        }
        /// <summary>
        /// 获取所有的类型
        /// </summary>
        /// <returns></returns>
        private static Type[] GetAlTypes()
        {
            var allTypes = AppDomain.CurrentDomain.GetAssemblies()
              .SelectMany(a => a.GetTypes().Where(t => t.GetCustomAttributes(false).ToList().Exists(m => m is TidyControlAttribute)))
              .ToArray();
            return allTypes;
        }

        public override void LogWrite(string? msg)
        {
            Console.WriteLine(msg);
        }

        public override void LogWrite(string? msg, Exception? exception)
        {
            Console.WriteLine($"{msg}，异常信息：{exception?.Message}");
        }
    }
}
