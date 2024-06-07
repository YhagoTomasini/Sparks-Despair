using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public GameObject[] layers; 
    public float[] movementRange; 
    public float[] movementSpeed; 

    private Vector3[] originalPositions; 

    private void Start()
    {
        
        originalPositions = new Vector3[layers.Length];
        for (int i = 0; i < layers.Length; i++)
        {
            originalPositions[i] = layers[i].transform.localPosition;
        }
    }

    private void Update()
    {
        

        for (int i = 0; i < layers.Length; i++)
        {
            float offsetY = Mathf.Sin(Time.time * movementSpeed[i]) * movementRange[i];
            Vector3 newPosition = originalPositions[i] + Vector3.up * offsetY;
            layers[i].transform.localPosition = newPosition;
        }
    }
}
