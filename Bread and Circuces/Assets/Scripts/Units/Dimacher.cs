using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimacher : UnitInfo
{
    private TurnManager turnManager;

    protected override void Start()
    {
        damage = 0;

        health = 16;
        defence = 0;
        attackReachDistance = 1;
        moveDistance = 4;
        withShield = false;

        turnManager = FindObjectOfType<TurnManager>();
        base.Start();
    }

    public override void OnAttackEnd(UnitInfo target)
    {
        if(currentStance == Stance.Attacking)
            turnManager.AddAction(new Action(ActionType.Draw, teamSide, 1));
        base.OnAttackEnd(target);
    }

    public override void OnAttackStart(UnitInfo target)
    {
        ChangeAnimationAttack(gameObject.name);
    }

    public override void OnDefenceStart()
    {
    }

    public override void OnDefenceEnd(float blockDamage)
    {
        if (blockDamage == 0)
        {
            ChangeAnimationBlock(gameObject.name);
        }
        else
        {
            ChangeAnimationHit(gameObject.name);
        }

        base.OnDefenceEnd(blockDamage);
    }

    public override void OnMoveEnd()
    {
    }
}
