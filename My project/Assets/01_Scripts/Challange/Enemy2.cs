using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : ActorBase , IDamageable
{
    [SerializeField] private int EnemyHealth;
    [SerializeField] private int DamageTaken;
    [SerializeField] private int EnemyForceStrenght = 1200;

    private Rigidbody enemyRb;
    private int timer;
    private int counter = 0;


    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
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
        
        if(counter == 5)
        {
            counter = 0;
        }
    }
    public void TakeDamage(int _damage)
    {
        EnemyHealth -= _damage * DamageTaken;
        Debug.Log(transform.name + " heath = " + EnemyHealth);

        if (EnemyHealth <= 0)
        {
            Die();
            Debug.Log("Dead");
        }

    }

    public override void DoDamage(IDamageable _target)
    {
        base.DoDamage(_target);
    }

    private void Die()
    {
        Destroy(gameObject);
    }


}
