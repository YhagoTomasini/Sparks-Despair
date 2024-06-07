using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    // Referência para a Canvas que será escondida

    public GameObject playerGame;
    public GameObject CamGame;
    public GameObject RainGame;



    public void StartGame()
    {



        CamGame.GetComponent<CamMoviment>().Cammove = true;
        RainGame.GetComponent<CamMoviment>().Cammove = true;

        playerGame.GetComponent<PlayerMovement>().PodeMoverPersonagemGeral = true;
        playerGame.GetComponent<PlayerMovement>().PodeMoverPersonagem = true;







    }
}