using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private GameObject OrcBody;
    [SerializeField] private GameObject ElvesBody;

    [SerializeField] private Transform ElvesSpawnPos;
    [SerializeField] private Transform OrcSpawnPos;


    public delegate void MyDelegate();
    public MyDelegate wave;
    // Start is called before the first frame update
    void Start()
    {
        wave += SpawnOrc;
        wave += SpawnElves;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            waveCaller();
        }
    }


    public void SpawnOrc()
    {
        Instantiate(OrcBody, OrcSpawnPos);
    }

    public void SpawnElves()
    {
        Instantiate(ElvesBody, ElvesSpawnPos);
    }

    public void waveCaller()
    {
        wave?.Invoke();
    }
}
