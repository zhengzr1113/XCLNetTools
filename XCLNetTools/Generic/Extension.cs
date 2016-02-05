﻿/*
一：基本信息：
开源协议：https://github.com/xucongli1989/XCLNetTools/blob/master/LICENSE
项目地址：https://github.com/xucongli1989/XCLNetTools
Create By: XCL @ 2012

二：贡献者：
1：xucongli1989（https://github.com/xucongli1989）电子邮件：80213876@qq.com

三：更新：
当前版本：v2.1
更新时间：2016-01-01

四：更新内容：
1：将原先基础数据转换方法转移到Common/DataTypeConvert下面
2：其它逻辑优化，如表单参数获取等
3：首次开放所有源代码
 */

using System.Collections.Generic;
using System.Linq;

namespace XCLNetTools.Generic
{
    /// <summary>
    /// 泛型扩展方法
    /// </summary>
    public static class Extension
    {
        #region IEnumerable

        /// <summary>
        /// 判断IEnumerable是否为空
        /// </summary>
        /// <param name="source">要判断的值</param>
        /// <returns>是否为null或empty</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return null == source || source.Count() == 0;
        }

        /// <summary>
        /// 判断IEnumerable是否有值
        /// </summary>
        /// <param name="source">要判断的值</param>
        /// <returns>是否不为（null或empty）</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return null != source && source.Count() > 0;
        }

        #endregion IEnumerable

        #region 通用

        /// <summary>
        /// 将T转为json字符串
        /// </summary>
        /// <param name="source">要转换的值</param>
        /// <returns>json字符串</returns>
        public static string ToJson<T>(this T source)
        {
            if (null == source)
            {
                return null;
            }
            return XCLNetTools.Serialize.JSON.Serialize(source);
        }

        /// <summary>
        /// 判断T是否为null
        /// </summary>
        /// <param name="source">要判断的值</param>
        /// <returns>是否为null</returns>
        public static bool IsNull<T>(this T source)
        {
            return null == source;
        }

        /// <summary>
        /// 判断T不为null
        /// </summary>
        /// <param name="source">要判断的值</param>
        /// <returns>是否不为null</returns>
        public static bool IsNotNull<T>(this T source)
        {
            return null != source;
        }

        #endregion 通用
    }
}