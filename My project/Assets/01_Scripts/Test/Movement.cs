using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform PlayerTrans;
    [SerializeField] private float normalSpeed;
    [SerializeField] private float speedMulltiplier; 
    private float newspeed;



    // Start is called before the first frame update
    void Start()
    {
        newspeed = normalSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }


    private void MovementPlayer()
    {
        Vector3 oldPlayerPos = PlayerTrans.position;
        Vector3 newPlayerPos; 

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            newspeed = normalSpeed * speedMulltiplier; 
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            newspeed = normalSpeed;

        }


        if (Input.GetKey(KeyCode.W))
        {
            newPlayerPos = new Vector3(oldPlayerPos.x, oldPlayerPos.y, oldPlayerPos.z + newspeed * Time.deltaTime);
            PlayerTrans.position = newPlayerPos;

        }

        if (Input.GetKey(KeyCode.A))
        {
            newPlayerPos = new Vector3(oldPlayerPos.x - newspeed * Time.deltaTime, oldPlayerPos.y, oldPlayerPos.z);
            PlayerTrans.position = newPlayerPos;

        }

        if (Input.GetKey(KeyCode.D))
        {
            newPlayerPos = new Vector3(oldPlayerPos.x + newspeed * Time.deltaTime, oldPlayerPos.y, oldPlayerPos.z );
            PlayerTrans.position = newPlayerPos;

        }

        if (Input.GetKey(KeyCode.S))
        {
            newPlayerPos = new Vector3(oldPlayerPos.x , oldPlayerPos.y, oldPlayerPos.z - newspeed * Time.deltaTime);
            PlayerTrans.position = newPlayerPos;
        }






    }
}
