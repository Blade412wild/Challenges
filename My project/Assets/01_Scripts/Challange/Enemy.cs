using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ActorBase
{
    public Enemy(int _health, float _speed)
    {
        Health = _health;
        Speed = _speed;
    }
    public override void Movement(float _speed)
    {
        base.Movement(_speed);
    }
    public override void TakeDamage(int _damage)
    {
        base.TakeDamage(_damage);
    }

    public override void DoDamage()
    {
        base.DoDamage();
    }
}
