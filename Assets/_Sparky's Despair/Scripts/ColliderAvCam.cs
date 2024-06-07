using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAvCam : MonoBehaviour
{
    public GameObject CamPose;
    public GameObject ChuPose;
    public float moveSpeed = -3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(MoveCam(other));
        }
    }

    private IEnumerator MoveCam(Collider playerCollider)
    {
        while (true)
        {
            //CamPose.transform.position = new Vector3(CamPose.transform.position.x, CamPose.transform.position.y, 1-CamPose.transform.position.z);
            CamPose.transform.position -= new Vector3(0, 0, moveSpeed * Time.deltaTime);
            ChuPose.transform.position -= new Vector3(0, 0, moveSpeed * Time.deltaTime);


            if (!playerCollider.bounds.Intersects(GetComponent<Collider>().bounds))
            {
                break;
            }

            yield return null;
        }
    }
}
