using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerObjectPool : MonoBehaviour
{
    // counter to track cubes spawned
    public static int objectsSpawned = 0;

    // reference to the object pool
    ObjectPooler objectPooler;

    // Start is called before the first frame update
    void Start()
    {
        //creating the opbject pool
        objectPooler = ObjectPooler.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // spawning GameObjects from pool
        objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
        
        // increment counter
        objectsSpawned++;

    }
}
