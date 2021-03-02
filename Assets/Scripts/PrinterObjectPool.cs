using System.Collections;
using System.Collections.Generic;
using Tayx.Graphy;
using UnityEngine;

public class PrinterObjectPool : MonoBehaviour
{
    // counter to track seconds
    float secondsCounter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Typewriter", 1.0f, 0.5f);

    }

    // Update is called once per frame
    private void Typewriter()
    {
        secondsCounter += 0.5f;
        Debug.Log(secondsCounter + "," + GraphyManager.Instance.CurrentFPS + ", " + CubeSpawnerObjectPool.objectsSpawned);
    }
}
