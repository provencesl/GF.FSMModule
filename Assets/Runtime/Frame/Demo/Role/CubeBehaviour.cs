using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    private IFSMSystem _fsmSystem;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        _fsmSystem = new FSMSystem();
        animator = GetComponent<Animator>();

        IFSMState idleState = new IdleState(_fsmSystem,animator);
        IFSMState moveState = new MoveState(_fsmSystem,animator);

        idleState[(int)StateEnum.MoveState] = moveState;
        //默认状态 idle
        _fsmSystem.AddState(idleState,true);
        _fsmSystem.AddState(moveState);

    }

    // Update is called once per frame
    void Update()
    {
        if (_fsmSystem != null)
        {
            _fsmSystem.OnUpdate();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_fsmSystem != null)
            {
                _fsmSystem.SetTransition((int)StateEnum.MoveState);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_fsmSystem != null)
            {
                _fsmSystem.TurnDefault();
            }
        }
    }
}
