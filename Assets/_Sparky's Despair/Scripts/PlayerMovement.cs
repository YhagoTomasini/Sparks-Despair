using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    float dirX;
    float dirZ;
    bool flipCharacter = true;
    public bool PodeMoverPersonagem = false;
    public GameObject personagemquevira;

    void Start()
    {
        PodeMoverPersonagem = true;
    }

    void gambiarra()
    {
        PodeMoverPersonagem = true;
    } 

    void MovePersonagem()
    {
        PodeMoverPersonagem = false;

        if (dirX > 0)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x +.25f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x +.25f, gameObject.transform.position.y, gameObject.transform.position.z);
            if (!flipCharacter)
                flip();
        }
        else if (dirX < 0)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x - .5f, gameObject.transform.position.y, gameObject.transform.position.z);
            if (flipCharacter)
                flip();
        }
        else if (dirZ > 0)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + .7f);
        }
        else if (dirZ < 0)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - .7f);
        }

        Invoke("gambiarra", .3f);
    }

    void flip()
    {
        flipCharacter = !flipCharacter;
        personagemquevira.GetComponent<Transform>().Rotate(0, 180, 0);
    }
void Update()
    {

        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");


        if (dirX != 0||dirZ!=0)
        {


            if (PodeMoverPersonagem == true)
            {

                MovePersonagem();

            }
        }

    }
}


