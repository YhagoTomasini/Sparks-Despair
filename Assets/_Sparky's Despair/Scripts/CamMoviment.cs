using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoviment : MonoBehaviour
{
    public bool Cammove;
    public float CameraVelocity;
    // Start is called before the first frame update
    void Start()
    {
        Cammove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cammove == true)
        {
            transform.position -= new Vector3(0f, 0f, CameraVelocity * Time.deltaTime);

            CameraVelocity += 0.05f * Time.deltaTime;
        }
       
    }
}
