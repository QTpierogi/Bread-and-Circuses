using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veles : UnitInfo
{
    private TurnManager turnManager;

    protected override void Start()
    {
        damage = 0;

        health = 14;
        defence = 0;
        attackReachDistance = 1;
        moveDistance = 2;
        withShield = true;

        turnManager = FindObjectOfType<TurnManager>();
        base.Start();
    }

    public override void OnAttackEnd(UnitInfo target)
    {
        base.OnAttackEnd(target);
    }

    public override void OnAttackStart(UnitInfo target)
    {
        ChangeAnimation("Veles", animation: Animation.Attack);
        //ChangeAnimationAttack(gameObject.name);
    }

    public override void OnDefenceStart()
    {
    }

    public override void OnDefenceEnd(float blockDamage)
    {
        if (blockDamage == 0)
        {
            ChangeAnimation("Veles", animation: Animation.Block);
            //ChangeAnimationBlock(gameObject.name);
        }
        else
        {
            ChangeAnimation("Veles", animation: Animation.Hit);
            //ChangeAnimationHit(gameObject.name);
        }

        base.OnDefenceEnd(blockDamage);
    }

    public override bool OnMoveStart()
    {
        if (motionType == MotionType.StraightType)
            return true;
        else return false;
    }

    public override void OnMoveEnd()
    {
    }
}