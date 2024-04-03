using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesoRotation : MonoBehaviour
{
    public Transform FaguiaPosition;
    public float RotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(FaguiaPosition.position, Vector3.up, RotationSpeed * Time.deltaTime);
    }
}
