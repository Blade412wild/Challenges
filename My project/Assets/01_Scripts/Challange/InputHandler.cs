using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Player PlayerScript;


    // private float verticalForceControl;
    private float horizontalForceControl;
    private float verticalForceControl;

    // Start is called before the first frame update


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

    }

    private void FixedUpdate()
    {
        if (verticalForceControl < 0.0f || verticalForceControl > 0.0f || horizontalForceControl < 0.0 || horizontalForceControl > 0.0)
        {
            PlayerScript.Movement();
        }

    }


}
