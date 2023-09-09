using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ActorBase
{

    [SerializeField] private int PlayerHealth;
    [SerializeField] private float MaxSpeed = 3.0f;
    [SerializeField] private float ForceStrenght = 800;

    private Rigidbody PlayerRb;

    private void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        PlayerRb.drag = 2.0f;
    }

    public override void Movement()
    {
        float _currentSpeed = PlayerRb.velocity.magnitude;
        if (_currentSpeed <= MaxSpeed)
        {
            float _verticalForceControl = Input.GetAxis("Vertical");
            float _horizontalForceControl = Input.GetAxis("Horizontal");

            PlayerRb.AddForce(Vector3.forward * _verticalForceControl * ForceStrenght);
            PlayerRb.AddForce(Vector3.right * _horizontalForceControl * ForceStrenght);

        }

    }

    public override void TakeDamage(int _damage)
    {
        base.TakeDamage(_damage);
        Debug.Log("Player Health " + Health);
    }

    public override void DoDamage(GameObject _target)
    {
        base.DoDamage(_target);
    }

}
