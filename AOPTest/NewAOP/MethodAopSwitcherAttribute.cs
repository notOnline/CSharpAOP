﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAOP
{
    /// <summary>
    /// MethodAopSwitcherAttribute 用于决定一个被AopProxyAttribute修饰的class的某个特定方法是否启用截获 。
    /// 创建原因：绝大多数时候我们只希望对某个类的一部分Method而不是所有Method使用截获。
    /// 使用方法：如果一个方法没有使用MethodAopSwitcherAttribute特性或使用MethodAopSwitcherAttribute(false)修饰，
    ///       都不会对其进行截获。只对使用了MethodAopSwitcherAttribute(true)启用截获。 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class MethodAopSwitcherAttribute : Attribute
    {
        private int useAspect = 0; //记录类型
        private string userlog = "";    //记录详细信息
        public MethodAopSwitcherAttribute(int useAop, string log)
        {
            this.useAspect = useAop;
            this.userlog = log;
        }

        public int UseAspect
        {
            get
            {
                return this.useAspect;
            }
        }
        public string Userlog
        {
            get
            {
                return this.userlog;
            }
        }
    }
}
