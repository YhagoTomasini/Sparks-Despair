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
    public GameObject FirstSelected1;
    public GameObject FirstSelected2;
    public GameObject Firstselected3;

    private void Start()
    {

        SwitchCanvasToStart1();
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

        // Alterna a visibilidade das Canvas
        // canvas1.gameObject.SetActive(!canvas1.gameObject.activeSelf);
        //   canvas2.gameObject.SetActive(!canvas2.gameObject.activeSelf);
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
        EventSystem.current.SetSelectedGameObject(FirstSelected1);
    }

    public void SwitchCanvasToStart2()
    {
        CanvasSom.SetActive(false);
        CanvasStart.SetActive(true);
        EventSystem.current.SetSelectedGameObject(FirstSelected2);

    }

    public void SwitchCanvasToPause()
    {
        CanvasGamePlay.SetActive(false);
        CanvasPause.SetActive(true);
    }


}  
    


