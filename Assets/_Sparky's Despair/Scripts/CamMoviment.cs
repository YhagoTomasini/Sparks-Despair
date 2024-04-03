using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoviment : MonoBehaviour
{
    public float CameraVelocity;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, 0f, CameraVelocity * Time.deltaTime);

        CameraVelocity += 0.05f * Time.deltaTime;
    }
}
