﻿using System;

namespace Well.Core.Config.Models
{
    /// <summary>
    /// 数据库配置
    /// </summary>
    [Serializable]
    public class SystemConfig : ConfigFileBase
    {
        public SystemConfig()
        {
        }

        #region 序列化属性
        public int UserLoginTimeoutMinutes { get; set; }
        #endregion
    }
}