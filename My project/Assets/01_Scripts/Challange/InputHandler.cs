using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody Player;
    [SerializeField] private float ForceStrenght;

    // private float verticalForceControl;
    private float horizontalForceControl;
    private float verticalForceControl;
    private float MaxSpeed;
    private float currentSpeed;
    float forceControl;
    // Start is called before the first frame update
    void Start()
    {
        MaxSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.name);
                Debug.Log("hit");
            }
        }
        verticalForceControl = Input.GetAxis("Vertical");
        horizontalForceControl = Input.GetAxis("Horizontal");

        currentSpeed = Player.velocity.magnitude;
        Debug.Log(currentSpeed);

    }

    private void FixedUpdate()
    {
        if (currentSpeed <= MaxSpeed)
        {
            Player.AddForce(Vector3.forward * verticalForceControl * ForceStrenght);
            Player.AddForce(Vector3.right * horizontalForceControl * ForceStrenght);

        }

    }


}
