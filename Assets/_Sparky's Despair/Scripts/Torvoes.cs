using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Torvoes : MonoBehaviour
{
    public Light EfeitoTrovao;
    public float IntervaloMin;
    public float IntervaloMax;
    public AudioClip[] Trovao;

    private AudioSource QuemTroveja;

    void Start()
    {

        IntervaloMin = 5f;
        IntervaloMax = 10f;

        QuemTroveja = GetComponent<AudioSource>();

        StartCoroutine(TocarTrovao());
    }

    IEnumerator TocarTrovao()
    {
        while (true)
        {
            float Intervalo = Random.Range(IntervaloMin, IntervaloMax);
            yield return new WaitForSeconds(Intervalo);

            EfeitoTrovao.enabled = true;
            yield return new WaitForSeconds(0.1f);
            EfeitoTrovao.enabled = false;
            yield return new WaitForSeconds(0.1f);
            EfeitoTrovao.enabled = true;
            yield return new WaitForSeconds(0.1f);
            EfeitoTrovao.enabled = false;

            yield return new WaitForSeconds(0.6f);

            AudioClip TrovaodaVez = Trovao[Random.Range(0, Trovao.Length)];
            QuemTroveja.PlayOneShot(TrovaodaVez);


        }

    }
}
