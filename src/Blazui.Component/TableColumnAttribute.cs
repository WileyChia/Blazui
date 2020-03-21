﻿using System;

namespace Blazui.Component
{
    public class TableColumnAttribute : Attribute
    {
        /// <summary>
        /// 列头文本
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 宽度（%，px，sp）
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// 格式化参数，仅支持日期格式
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// 渲染是否忽略该属性
        /// </summary>
        public bool Ignore { get; set; }
    }
}
