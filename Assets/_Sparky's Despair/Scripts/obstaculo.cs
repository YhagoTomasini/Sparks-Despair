using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{


    public GameObject Player;

    //public GameObject PlayerColliderEsquerda;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Direita")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaDireita = false;
        }
        if (other.gameObject.name == "Esquerda")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaEsquerda = false;
        }
        if (other.gameObject.name == "Cima")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaCima = false;
        }
        if (other.gameObject.name == "Baixo")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaBaixo = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Direita")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaDireita = true;
        }
        if (other.gameObject.name == "Esquerda")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaEsquerda = true;
        }
        if (other.gameObject.name == "Cima")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaCima = true;
        }
        if (other.gameObject.name == "Baixo")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaBaixo = true;
        }
    }

        void Start()
    {
        Player = GameObject.Find("Player");

    }

    void Update()
    {
        
    }
}
