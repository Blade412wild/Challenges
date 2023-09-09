using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Enemy : ActorBase
{
    [SerializeField] private int EnemyHealth;
    [SerializeField] private int EnemyForceStrenght = 1200;
    
    private Rigidbody enemyRb;
    private int timer;
    private int counter = 0;


    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }
    public override void Movement()
    {
        Timer();

        if (counter == 1)
        {
            enemyRb.AddForce(Vector3.forward * EnemyForceStrenght);
        }
        if (counter == 2)
        {
            enemyRb.AddForce(Vector3.right * EnemyForceStrenght);
        }
        if (counter == 3)
        {
            enemyRb.AddForce(Vector3.back * EnemyForceStrenght);
        }
        if (counter == 4)
        {
            enemyRb.AddForce(Vector3.left * EnemyForceStrenght);
        }


    }

    private void Timer()
    {

        timer = timer + 1;
        if (timer == 50)
        {
            counter++;
            timer = 0;
        }

        if (counter == 5)
        {
            counter = 0;
        }
    }
    public override void TakeDamage(int _damage)
    {
        base.TakeDamage(_damage);
    }

    public override void DoDamage(GameObject _target)
    {
        base.DoDamage(_target);
    }

}
