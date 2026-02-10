using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Model基类
/// </summary>
public class BaseModel : IModel
{

    // 配置管理器实例（所有Model可直接用）
    protected ConfigManager _configMgr => ConfigManager.Instance;

    /// <summary>
    /// 加载数据（子类重写：本地读取/网络请求）
    /// </summary>
    /// <param name="callback"></param>
    public virtual void LoadData(Action<object> callback)
    {
        callback?.Invoke(null);
    }

    /// <summary>
    /// 保存数据（子类重写）
    /// </summary>
    /// <param name="data"></param>
    public virtual void SaveData(object data)
    {
        // 子类实现：保存到本地/上传到服务器
    }

    #region 快捷获取配置（Model层专用）
    protected string GetText(string key) => _configMgr.GetTextConfig(key);
    protected string GetAudioPath(string key) => _configMgr.GetAudioConfig(key);
    protected string GetResourcePath(string key) => _configMgr.GetResourceConfig(key);
    protected DialogConfig GetDialogCfg() => _configMgr.GetDialogConfig();
    #endregion
}
