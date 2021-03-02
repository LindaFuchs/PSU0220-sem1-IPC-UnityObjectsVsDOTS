using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSpawner : MonoBehaviour
{
    //reference to cubes to spawn
    public GameObject cubePrefab;

    //counter to track cubes spawned
    public static int objectsSpawned = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //spawning GameObjects normally
        Instantiate(cubePrefab, transform.position, Quaternion.identity);

        //increment counter
        objectsSpawned++;
    }
}
