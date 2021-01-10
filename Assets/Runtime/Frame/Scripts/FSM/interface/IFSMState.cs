using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 负责对状态的抽象
/// </summary>
public interface IFSMState 
{
    /// <summary>
    /// 获取目标状态
    /// </summary>
    IFSMState this[int transition] { get; set; }

    /// <summary>
    /// 进入
    /// </summary>
    void OnEnter(params object[] keys);

    /// <summary>
    /// 退出
    /// </summary>
    void OnExit();

    /// <summary>
    /// 驻留
    /// </summary>
    void OnStay();
}
