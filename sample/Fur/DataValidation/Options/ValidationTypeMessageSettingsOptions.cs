﻿// -----------------------------------------------------------------------------
// Fur 是 .NET 5 平台下极易入门、极速开发的 Web 应用框架。
// Copyright © 2020 Fur, Baiqian Co.,Ltd.
//
// 框架名称：Fur
// 框架作者：百小僧
// 框架版本：1.0.0
// 源码地址：Gitee：https://gitee.com/monksoul/Fur
// 				   Github：https://github.com/monksoul/Fur
// 开源协议：Apache-2.0（http://www.apache.org/licenses/LICENSE-2.0）
// -----------------------------------------------------------------------------

using Fur.ConfigurableOptions;

namespace Fur.DataValidation
{
    /// <summary>
    /// 验证消息配置选项
    /// </summary>
    [OptionsSettings("AppSettings:ValidationTypeMessageSettings")]
    public sealed class ValidationTypeMessageSettingsOptions : IConfigurableOptions
    {
        /// <summary>
        /// 验证消息配置表
        /// </summary>
        public object[][] Definitions { get; set; }
    }
}