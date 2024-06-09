using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaRaio : MonoBehaviour
{
    public GameObject raioAativar;
    public GameObject raioAlerta;

    private Light luzRaio;

    public float IntervaloMin;
    public float IntervaloMax;

    public AudioClip[] Trovao;
    private AudioSource QuemTroveja;

    void Start()
    {
        luzRaio = GameObject.Find("LuzRaio").GetComponent<Light>();

        raioAativar.SetActive(false);
        raioAlerta.SetActive(false);

        IntervaloMin = 4f;
        IntervaloMax = 8f;

        QuemTroveja = GetComponent<AudioSource>();

        StartCoroutine(TocarTrovao());
    }

    IEnumerator TocarTrovao()
    {
        while (true)
        {
            float Intervalo = Random.Range(IntervaloMin, IntervaloMax);
            yield return new WaitForSeconds(Intervalo);

            raioAlerta.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            raioAlerta.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            raioAlerta.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            raioAlerta.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            raioAlerta.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            raioAlerta.SetActive(false);
            yield return new WaitForSeconds(0.1f);


            raioAativar.SetActive(true);
            luzRaio.enabled = true;

            AudioClip TrovaodaVez = Trovao[Random.Range(0, Trovao.Length)];
            QuemTroveja.PlayOneShot(TrovaodaVez);

            yield return new WaitForSeconds(0.75f);

            raioAativar.SetActive(false);
            luzRaio.enabled = false;

            yield return null;
        }
        

    }
}
