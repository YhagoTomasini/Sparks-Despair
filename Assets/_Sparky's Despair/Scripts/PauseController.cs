using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;


public class PauseController : MonoBehaviour
{
    // Referência para a Canvas de pausa
    // public Canvas Menujogoparado;

    public GameObject Menujogoparado;
    public GameObject CanvasGamePlay;
    public GameObject CanvasPause;
    public GameObject FirstSelected3;

    // Variável para controlar se o jogo está em pausa ou não
    private bool isPaused = false;

    void Update()
    {
        // Verifica se a tecla 'Esc' foi pressionada para pausar o jogo
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    public void SwitchCanvasToPause()
    {
        CanvasGamePlay.SetActive(false);
        CanvasPause.SetActive(true);
        EventSystem.current.SetSelectedGameObject(FirstSelected3);
    }


public void Pause()
     {

        
            // Alterna o estado de pausa
            isPaused = !isPaused;

            // Se o jogo estiver em pausa, ativa a Canvas de pausa
            if (isPaused)
            {
            // Ativa a Canvas de pausa
            //     Menujogoparado.gameObject.GetComponent<Canvas>().enabled = true;

            Menujogoparado.SetActive(true);
                // Pausa o jogo
                Time.timeScale = 0f;
            EventSystem.current.SetSelectedGameObject(FirstSelected3);

            }

        else 
            {
            // Desativa a Canvas de pausa
            //     Menujogoparado.gameObject.GetComponent<Canvas>().enabled = false;
            Menujogoparado.SetActive(false);
            // Retoma o jogo
            Time.timeScale = 1f;
            }
        
     }
}
