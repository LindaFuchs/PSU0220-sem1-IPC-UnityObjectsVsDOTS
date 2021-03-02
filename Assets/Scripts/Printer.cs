using System.Collections;
using System.Collections.Generic;
using Tayx.Graphy;
using UnityEngine;

public class Printer : MonoBehaviour
{
    // Counter to track seconds
    float secondsCounter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Typewriter", 1.0f, 0.5f);
    }

    // Prints seconds past since start, current FPS, total nr of objects spawned
    private void Typewriter()
    {
        secondsCounter += 0.5f;
        Debug.Log(  secondsCounter 
                    + "," 
                    + GraphyManager.Instance.CurrentFPS 
                    + ", " 
                    + CubeSpawner.objectsSpawned);
    }
}
