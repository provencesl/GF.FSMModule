using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;

public class MoveState : FSMState
{
    private IFSMSystem _fsmSystem;

    private Animator animator;

    public MoveState(IFSMSystem fsmSystem,Animator tempAnimator = null)
    {
        this._fsmSystem = fsmSystem;
        this.animator = tempAnimator;
    }


    public override void OnEnter(params object[] keys)
    {
        animator.SetTrigger("Move");
        Debug.Log("Enter State Move");
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
                _fsmSystem.SetTransition((int)StateEnum.IdleState, "MoveState to IdleState");
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (_fsmSystem != null)
            {
                _fsmSystem.SetTransition((int)StateEnum.RunState,"MoveState to RunState");
            }
        }
    }
  
}
