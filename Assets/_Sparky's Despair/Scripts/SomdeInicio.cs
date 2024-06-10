using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SomdeInicio : MonoBehaviour
{
    public GameObject Iniciar;
    public GameObject CamI;
    public AudioSource SomI;

    public GameObject skipButton;

    // Start is called before the first frame update
    void Start()
    {
        Iniciar.SetActive(false);
        StartCoroutine(IniciarJogo());

        SkipB();
    }

    IEnumerator IniciarJogo()
    {
        SomI.Play();

        yield return new WaitForSeconds(5.5f);

        Iniciar.SetActive(true);
        CamI.SetActive(false);

        yield return new WaitForSeconds(.5f);

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (/*Iniciar.activeSelf &&*/ Input.GetKeyDown(KeyCode.Space))
        {
            SkipAcao();
            
        }
        
        
    }
    public void SkipAcao()
    {
        Iniciar.SetActive(true);
        CamI.SetActive(false);
        gameObject.SetActive(false);


        if (SomI.isPlaying)
        {
            SomI.Stop();
        }
    }
    public void SkipB()
    {

        EventSystem.current.SetSelectedGameObject(skipButton);

    }
}
