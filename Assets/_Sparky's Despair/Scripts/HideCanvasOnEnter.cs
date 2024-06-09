using UnityEngine;

public class HideCanvasOnEnter : MonoBehaviour
{
    // Referência para a Canvas que será escondida
    public Canvas canvasToHide;
    public GameObject playerGame;
    public GameObject CamGame;
    public GameObject RainGame;

    // Flag para verificar se o enter foi pressionado
    //private bool enterPressed = false;

    void Update()
    {
        // Verifica se a tecla Enter foi pressionada e se ainda não foi processada
        // if (Input.GetKeyDown(KeyCode.Return) && !enterPressed)
        //{


        if (Input.GetButton("Jump")){ 
        // Marca o enter como pressionado para não processar novamente
            //enterPressed = true;

            CamGame.GetComponent<CamMoviment>().Cammove = true;
            RainGame.GetComponent<CamMoviment>().Cammove = true;




            playerGame.GetComponent<PlayerMovement>().PodeMoverPersonagemGeral = true;
            playerGame.GetComponent<PlayerMovement>().PodeMoverPersonagem = true;


            // Esconde a Canvas desativando seu GameObject
            canvasToHide.gameObject.SetActive(false);

            

        }
    }
}
