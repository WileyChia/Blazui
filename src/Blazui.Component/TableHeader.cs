using System;
using System.Reflection;
using Microsoft.AspNetCore.Components;

namespace Blazui.Component
{
    public class TableHeader
    {
        public string Text { get; set; }
        public string Width { get; set; }
        public PropertyInfo Property { get; set; }
        public Func<object, object> Eval { get; set; }
        public bool IsCheckBox { get; set; }
        public RenderFragment<object> Template { get; set; }
        public string Format { get; set; }
    }
}