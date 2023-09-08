using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public abstract class ActorBase : MonoBehaviour
{
    public int Health { get; protected set; }
    public float Speed { get; protected set; }

    public virtual void Movement(float _speed)
    {
        Speed = _speed;
    }

    public virtual void TakeDamage(int _damage)
    {
        Health -= _damage;

        if (Health < 0)
        {
            Debug.Log("Dead");
        }
    }

    public virtual void DoDamage()
    {

    }
}
