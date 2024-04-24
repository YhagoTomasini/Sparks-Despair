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

    public bool PodeMoverPersonagemGeral;

    public Animator AnimLegs;
    public int QualLeg;

    void Start()
    {
        PodeMoverPersonagemGeral = true;

        PodeMoverPersonagem = true;
        podeMoverParaEsquerda = true;
        podeMoverParaDireita = true;
        podeMoverParaCima = true;
        podeMoverParaBaixo = true;

        QualLeg = 1;
    }

    void gambiarra()
    {
        PodeMoverPersonagem = true;
        AnimLegs.SetBool("LFD", false);
        AnimLegs.SetBool("LFE", false);


    }

    void MovendoFrente()
    {
        if(QualLeg == )
        {
            AnimLegs.SetBool("LFD", true);
        }
        else if()
        {
            AnimLegs.SetBool("LFE", true);
        }
    }

    void MovePersonagem()
    {
        PodeMoverPersonagem = false;

        //Direita
        if (dirX > 0 && podeMoverParaDireita == true && PodeMoverPersonagemGeral == true)
        {

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x + 1f, gameObject.transform.position.y, gameObject.transform.position.z);
            if (!flipCharacter)
                flip();
        }
        // Esquerda
        if (dirX < 0 && podeMoverParaEsquerda == true && PodeMoverPersonagemGeral == true)
        {

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x - 1f, gameObject.transform.position.y, gameObject.transform.position.z);
            if (flipCharacter)
                flip();
        }
        //cima
        if (dirZ > 0 && podeMoverParaCima == true && PodeMoverPersonagemGeral == true)
        {

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1f);
        }
        //baixo
        if (dirZ < 0 && podeMoverParaBaixo == true && PodeMoverPersonagemGeral == true)
        {

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

