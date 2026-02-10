using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ViewModel基类
/// </summary>
public class BaseViewModel : IViewModel
{
    protected IModel _model;
    protected IView _view;

    public virtual void BindModel(IModel model)
    {
        _model = model;
    }

    public virtual void BindView(IView view)
    {
        _view = view;
    }

    /// <summary>
    /// 处理View发送的事件
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="param"></param>
    public virtual void OnViewEvent(string eventName, object param)
    {
        // 子类重写：处理具体业务逻辑
        switch (eventName)
        {
            case "Button_Confirm_Click":
                // 示例：处理确认按钮点击
                break;
        }
    }

    /// <summary>
    /// 更新Model数据
    /// </summary>
    /// <param name="data"></param>
    public virtual void UpdateModel(object data)
    {
        _model?.SaveData(data);
    }

    /// <summary>
    /// 通知View更新UI
    /// </summary>
    /// <param name="data"></param>
    protected void NotifyViewUpdate(object data)
    {
        _view?.UpdateView(data);
    }
}
