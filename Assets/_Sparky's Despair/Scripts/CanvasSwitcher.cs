using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class CanvasSwitcher : MonoBehaviour
{
    // Referências para as duas Canvas
    //public Canvas canvas1;
    //public Canvas canvas2;

    public GameObject CanvasStart;
    public GameObject CanvasGamePlay;
    public GameObject CanvasSom;
    public GameObject CanvasPause;
    public GameObject CanvasCredit;
    public GameObject CanvasDeath;

    public GameObject FirstSelected1;
    public GameObject FirstSelected2;
    public GameObject Firstselected3;
    public GameObject Firstselected4;
    public GameObject Firstselected5;

    public AudioManager audioM;

    private void Start()
    {
        audioM = FindObjectOfType<AudioManager>();
        //SwitchCanvasToStart1();
    }


    // Metod para alternar entre as Canvas
    public void SwitchCanvasToGame()
    {

        CanvasStart.SetActive(false);
        CanvasGamePlay.SetActive(true);
        gameObject.GetComponent<GameStart>().StartGame();

        // Alterna a visibilidade das Canvas
        // canvas1.gameObject.SetActive(!canvas1.gameObject.activeSelf);
        //   canvas2.gameObject.SetActive(!canvas2.gameObject.activeSelf);
    }

    // Metod para alternar entre as Canvas
    public void SwitchCanvasToStart1()
    {

        CanvasStart.SetActive(true);
        CanvasGamePlay.SetActive(false);

        Debug.Log("Deveriaestarfuncionado");
        EventSystem.current.SetSelectedGameObject(FirstSelected2);
    }


    public void QuitGame()
    {
        Debug.Log("Saiu");
        Application.Quit();

    }

    public void SwitchCanvasToConfig()
    {
        CanvasStart.SetActive(false);
        CanvasSom.SetActive(true);
        audioM.SoundPrefs();

        EventSystem.current.SetSelectedGameObject(FirstSelected1);
    }

    public void SwitchCanvasToStart2()
    {
        CanvasCredit.SetActive(false);
        CanvasSom.SetActive(false);
        CanvasStart.SetActive(true);
        EventSystem.current.SetSelectedGameObject(FirstSelected2);

    }

    public void SwitchCanvasToPause()
    {
        CanvasGamePlay.SetActive(false);
        CanvasPause.SetActive(true);
        audioM.SoundPrefs(); 
    }

    public void SwitchCanvasToPause2()
    {
        CanvasPause.SetActive(false);
        CanvasGamePlay.SetActive(true);
        Time.timeScale = 1f;

    }

    public void SwitchCanvasToCredits()
    {
        CanvasStart.SetActive(false);
        CanvasCredit.SetActive(true);
        EventSystem.current.SetSelectedGameObject(Firstselected4);
    }

    public void SwitchCanvasDeath()
    {
        CanvasGamePlay.SetActive(false);
        CanvasDeath.SetActive(true);
        EventSystem.current.SetSelectedGameObject (Firstselected5);
    }
}



