using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class PauseController : MonoBehaviour
{
    // Referência para a Canvas de pausa
    public Canvas Menujogoparado;

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

    public  void Pause()
     {

        
            // Alterna o estado de pausa
            isPaused = !isPaused;

            // Se o jogo estiver em pausa, ativa a Canvas de pausa
            if (isPaused)
            {
                // Ativa a Canvas de pausa
                Menujogoparado.gameObject.GetComponent<Canvas>().enabled = true;

                // Pausa o jogo
                Time.timeScale = 0f;
            }
            else
            {
                // Desativa a Canvas de pausa
                Menujogoparado.gameObject.GetComponent<Canvas>().enabled = false;

                // Retoma o jogo
                Time.timeScale = 1f;
            }
        
     }
}
