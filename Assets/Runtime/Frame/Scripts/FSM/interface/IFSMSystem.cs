using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFSMSystem
{
    /// <summary>
    /// 任意状态
    /// </summary>
    IFSMState AnyState { get; }

    /// <summary>
    /// 添加状态
    /// </summary>
    void AddState(IFSMState state, bool isDefault = false);

    /// <summary>
    /// 设置过渡
    /// </summary>
    void SetTransition(int transition, params object[] keys);

    /// <summary>
    /// 跳转默认状态
    /// </summary>
    void TurnDefault();

    /// <summary>
    /// 刷新
    /// </summary>
    void OnUpdate();


}
