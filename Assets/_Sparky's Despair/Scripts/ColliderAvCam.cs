using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAvCam : MonoBehaviour
{
    public GameObject CamPose;
    public float moveSpeed = -1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(MoveCameraUntilPlayerIsOut(other));
        }
    }

    private IEnumerator MoveCameraUntilPlayerIsOut(Collider playerCollider)
    {
        while (true)
        {
            // Mover a câmera para frente
            CamPose.transform.position = new Vector3(CamPose.transform.position.x, CamPose.transform.position.y, 1-CamPose.transform.position.z);

            // Verificar se o jogador ainda está colidindo com o objeto
            if (!playerCollider.bounds.Intersects(GetComponent<Collider>().bounds))
            {
                break;
            }

            // Esperar até o próximo frame
            yield return null;
        }
    }
}
