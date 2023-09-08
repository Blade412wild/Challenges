using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : ActorBase
{
    public Enemy2(int _health, float _speed)
    {
        Health = _health;
        Speed = _speed;

        Debug.Log("enemy2 Health " + Health);

    }
    public override void Movement(float _speed)
    {
        base.Movement(_speed);
    }
    public override void TakeDamage(int _damage)
    {
        _damage = _damage * 2;
        base.TakeDamage(_damage);
        Debug.Log("Enemy2 Health " + Health);

    }

    public override void DoDamage()
    {

        base.DoDamage();
    }
}
