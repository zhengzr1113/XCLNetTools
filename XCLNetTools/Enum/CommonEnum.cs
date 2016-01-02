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



using System;

namespace XCLNetTools.Enum
{
    /// <summary>
    /// 常用枚举常量
    /// </summary>
    [Serializable]
    public class CommonEnum
    {
        /// <summary>
        /// 是否
        /// </summary>
        public enum 是否
        {
            /// <summary>
            /// 是
            /// </summary>
            是 = 1,

            /// <summary>
            /// 否
            /// </summary>
            否 = 0
        }

        /// <summary>
        /// 静态资源类型
        /// </summary>
        public enum StaticResourceTypeEnum
        {
            /// <summary>
            /// js文件
            /// </summary>
            JS,

            /// <summary>
            /// css文件
            /// </summary>
            CSS,

            /// <summary>
            /// icon
            /// </summary>
            ICON
        }
    }
}