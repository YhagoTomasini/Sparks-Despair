using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomdeInicio : MonoBehaviour
{
    public GameObject Iniciar;
    public AudioSource SomI;

    // Start is called before the first frame update
    void Start()
    {
        Iniciar.SetActive(false);
        StartCoroutine(IniciarJogo());
    }

    IEnumerator IniciarJogo()
    {
        SomI.Play();

        yield return new WaitForSeconds(5.5f);

        Iniciar.SetActive(true);

        yield return new WaitForSeconds(.5f);

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Iniciar.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {

            Iniciar.SetActive(true);

            if (SomI.isPlaying)
            {
                SomI.Stop();
            }
        }
        
        
    }
}
