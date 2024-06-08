using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaRaio : MonoBehaviour
{
    public GameObject raioAativar;

    public Light luzRaio;

    public float IntervaloMin;
    public float IntervaloMax;

    public AudioClip[] Trovao;
    private AudioSource QuemTroveja;

    void Start()
    {

        IntervaloMin = 2f;
        IntervaloMax = 6f;

        QuemTroveja = GetComponent<AudioSource>();

        StartCoroutine(TocarTrovao());
    }

    IEnumerator TocarTrovao()
    {
        while (true)
        {
            float Intervalo = Random.Range(IntervaloMin, IntervaloMax);
            yield return new WaitForSeconds(Intervalo);

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
