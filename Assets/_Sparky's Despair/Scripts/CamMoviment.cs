 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamMoviment : MonoBehaviour
{
    public bool Cammove;
    public float CameraVelocity;
    public Score ScoreValue;
    public GameObject PoseAvCam;

    // Start is called before the first frame update
    void Start()
    {
        Cammove = false;
        CameraVelocity = 1;
    }

    void FixedUpdate()
    {
        if (Cammove)
        {
            // Verifique se PoseAvCam não é nulo antes de acessá-lo
            if (PoseAvCam != null)
            {
                transform.position -= new Vector3(0f, 0f, CameraVelocity * Time.deltaTime);

                if (ScoreValue.scoreValue >= 10)
                {
                    CameraVelocity = 1.2f;
                }
                if (ScoreValue.scoreValue >= 20)
                {
                    CameraVelocity = 1.4f;
                }
                if (ScoreValue.scoreValue >= 30)
                {
                    CameraVelocity = 1.6f;
                }
                if (ScoreValue.scoreValue >= 40)
                {
                    CameraVelocity = 1.8f;
                }
                if (ScoreValue.scoreValue >= 50)
                {
                    CameraVelocity = 2f;
                }
                if (ScoreValue.scoreValue >= 60)
                {
                    CameraVelocity = 2.2f;
                }
            }
        }
    }

    public void AvancoC()
    {
        Debug.Log("Camera movida para a posição Z do objeto PoseAvCam");
        transform.position = new Vector3(transform.position.x, transform.position.y, PoseAvCam.transform.position.z);
    }
}
