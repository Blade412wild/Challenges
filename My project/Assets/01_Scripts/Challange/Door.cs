using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IDamageable
{
    [SerializeField] private int Health;
    [SerializeField] private int DamageTaken;

    // Start is cal led before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int _damageTaken)
    {
        Health -= _damageTaken * DamageTaken;
        Debug.Log(transform.name + " heath = " + Health);


        if (Health <= 0)
        {
            Die();
            Debug.Log("Dead");
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
