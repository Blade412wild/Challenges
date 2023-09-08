using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ActorBase
{

    [SerializeField] private int PlayerHealth;
    [SerializeField] private int PlayerSpeed;

    private GameObject playerBody;

    public Player(int _health, float _speed, GameObject _Body)
    {
        PlayerHealth = _health;
        Speed = _speed;
        playerBody = _Body;

        Debug.Log("Player Health " + Health);


    }

    public override void Movement(float _speed)
    {
        
        base.Movement(_speed);
    }
    public override void TakeDamage(int _damage)
    {
        base.TakeDamage(_damage);
        Debug.Log("Player Health " + Health);
    }

    public override void DoDamage()
    {
        base.DoDamage();
    }

}
