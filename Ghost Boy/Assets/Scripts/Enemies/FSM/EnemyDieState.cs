using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieState : IEnemyState
{
    private EnemyFSM manager;
    private Parameter parameter;

    public EnemyDieState(EnemyFSM _manager)
    {
        this.manager = _manager;
        this.parameter = _manager.parameter;
    }

    public void OnEnter()
    {
        parameter.anim.Play("Feelie_FSM_Die");
    }

    public void OnUpdate()
    {
        parameter.info = parameter.anim.GetCurrentAnimatorStateInfo(0);
        if (parameter.info.normalizedTime >= .95f)
        {
            manager.Death();
        }
    }

    public void OnExit()
    {
        
    }
}
