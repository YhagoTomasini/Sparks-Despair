using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    float dirX;
    float dirZ;
    bool flipCharacter = true;

    public bool PodeMoverPersonagem = false;
    public bool podeMoverParaEsquerda = false;
    public bool podeMoverParaDireita = false;
    public bool podeMoverParaCima = false;
    public bool podeMoverParaBaixo = false;

    public GameObject personagemquevira;
    public GameObject EyesOrdem;
    public GameObject TopFlip;

    public bool PodeMoverPersonagemGeral;

    public Animator AnimLegs;
    public Animator AnimEyes;
    public int QualLeg;

    void Start()
    {
        PodeMoverPersonagemGeral = false;

        PodeMoverPersonagem = true;
        podeMoverParaEsquerda = true;
        podeMoverParaDireita = true;
        podeMoverParaCima = true;
        podeMoverParaBaixo = true;
    }

    void gambiarra()
    {
        PodeMoverPersonagem = true;
        AnimLegs.SetBool("LFD", false);
        AnimLegs.SetBool("LFE", false);
        AnimLegs.SetBool("LTD", false);
        AnimLegs.SetBool("LTE", false);
        AnimEyes.SetBool("movendo", false);
    }

    void MovendoFrente()
    {
        if(QualLeg % 2 == 0)
        {
            AnimLegs.SetBool("LFD", true);
            Debug.Log("par");
        }
        if (QualLeg % 2 != 0)
        {
            AnimLegs.SetBool("LFE", true);
        }
        EyesOrdem.GetComponent<SpriteRenderer>().sortingOrder = 0;
        TopFlip.GetComponent<Transform>().Rotate(0, 180, 0);

    }

    void MovendoTraz()
    {
        if (QualLeg % 2 == 0)
        {
            AnimLegs.SetBool("LTD", true);
        }
        if (QualLeg % 2 != 0)
        {
            AnimLegs.SetBool("LTE", true);
        }
        EyesOrdem.GetComponent<SpriteRenderer>().sortingOrder = -3;
        TopFlip.GetComponent<Transform>().Rotate(0, 180, 0);

    }

    void MovePersonagem()
    {
        PodeMoverPersonagem = false;
        AnimEyes.SetBool("movendo", true);

        //Direita
        if (dirX > 0 && podeMoverParaDireita == true && PodeMoverPersonagemGeral == true)
        {
            MovendoFrente();

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x + 1f, gameObject.transform.position.y, gameObject.transform.position.z);
            if (!flipCharacter)
                flip();
        }
        // Esquerda
        if (dirX < 0 && podeMoverParaEsquerda == true && PodeMoverPersonagemGeral == true)
        {
            MovendoFrente();

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x - 1f, gameObject.transform.position.y, gameObject.transform.position.z);
            if (flipCharacter)
                flip();
        }
        //cima
        if (dirZ > 0 && podeMoverParaCima == true && PodeMoverPersonagemGeral == true)
        {
            MovendoTraz();

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1f);
        }
        //baixo
        if (dirZ < 0 && podeMoverParaBaixo == true && PodeMoverPersonagemGeral == true)
        {
            MovendoFrente();

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1f);
        }

        QualLeg++;

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


        if (dirX != 0 || dirZ != 0)
        {

            if (PodeMoverPersonagem == true)
            {

                MovePersonagem();

            }

        }
    }
}

