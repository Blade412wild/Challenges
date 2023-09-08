using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform PlayerTransform;
    public GameObject PlayerAsset;

    private Player player;
    private Enemy enemy1;
    private Enemy2 enemy2;




    // Start is called before the first frame update
    void Start()
    {
        //player = new Player(100, 5.0f, PlayerAsset);
        //enemy1 = new Enemy(100, 2.0f);
        //enemy2 = new Enemy2(200, 4.0f);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
