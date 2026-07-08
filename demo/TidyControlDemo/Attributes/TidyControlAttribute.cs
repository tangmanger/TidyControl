using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidyControlDemo.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class TidyControlAttribute: Attribute
    {
        public TidyControlAttribute() { }
        public TidyControlAttribute(string viewKey, Type viewType, Type viewModelType)
        {
            ViewKey = viewKey;
            ViewType = viewType;
            ViewModelType = viewModelType;
        }
        public string? ViewKey { get; set; }
        public Type? ViewType { get; set; }
        public Type? ViewModelType { get; set; }
    }
}
