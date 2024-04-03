
using System;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Transform _cameraTransform;


    void Start()
    {
       transform.Rotate(30f, 0f, 0f);
    }

    void Update()
    {
   
    }
}