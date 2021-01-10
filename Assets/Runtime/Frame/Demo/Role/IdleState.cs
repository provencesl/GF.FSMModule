using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : FSMState
{
    private IFSMSystem _fsmSystem;
    private Animator animator;

    public IdleState(IFSMSystem fsmSystem,Animator tempAnimator = null)
    {
        this._fsmSystem = fsmSystem;
        this.animator = tempAnimator;
    }


    public override void OnEnter(params object[] keys)
    {
        Debug.Log("Enter State Idle");
    }

    public override void OnExit()
    {
        Debug.Log("Exit");
    }

    public override void OnStay()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (_fsmSystem != null)
            {
                //_fsmSystem.SetTransition((int)StateEnum.RunState, "MoveState to IdleState");
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (_fsmSystem != null)
            {
                //_fsmSystem.SetTransition((int)StateEnum.RunState, "MoveState to RunState");
            }
        }
    }





}
