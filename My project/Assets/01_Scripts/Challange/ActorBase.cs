using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngineInternal;

public abstract class ActorBase : MonoBehaviour
{
    public int Health { get; protected set; }
    public float Speed { get; protected set; }

    public virtual void Movement()
    {
        
    }

    //public virtual void TakeDamage(int _damage)
    //{
    //    Health -= _damage;

    //    if (Health < 0)
    //    {
    //        Debug.Log("Dead");
    //    }
    //}

    public virtual void DoDamage(IDamageable _target)
    {
        _target.TakeDamage(1);
    }
}
