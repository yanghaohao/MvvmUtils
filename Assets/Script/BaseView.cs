using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// View基类，所有UI页面继承此类
/// </summary>
public class BaseView : BaseComponent, IView
{
    protected IViewModel _viewModel;

    /// <summary>
    /// 绑定ViewModel
    /// </summary>
    /// <param name="viewModel"></param>
    public virtual void BindViewModel(IViewModel viewModel)
    {
        _viewModel = viewModel;
        _viewModel.BindView(this);
    }

    /// <summary>
    /// 更新UI显示
    /// </summary>
    /// <param name="data"></param>
    public virtual void UpdateView(object data)
    {
        // 子类重写：根据数据更新UI
    }

    /// <summary>
    /// 向ViewModel发送事件（如按钮点击）
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="param"></param>
    protected void SendEventToVM(string eventName, object param = null)
    {
        _viewModel?.OnViewEvent(eventName, param);
    }
}
