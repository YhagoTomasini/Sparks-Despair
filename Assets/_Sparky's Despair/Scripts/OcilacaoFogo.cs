using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcilacaoFogo : MonoBehaviour
{
    public float IntensidadeMin;
    public float IntensidadeMax;
    public float IntensidadeVelo;
    public float IntensidadeBase;
    void Start()
    {
        IntensidadeMin = 2f;
        IntensidadeMax = 3f;
        IntensidadeVelo = 1.5f;
        IntensidadeBase = gameObject.GetComponent<Light>().intensity;
    }

    // Update is called once per frame
    void Update()
    {
        float IntensidadeGradual = Mathf.PingPong(Time.time * IntensidadeVelo, 1);
        float IntensidadeAlvo = Mathf.Lerp(IntensidadeMin, IntensidadeMax, IntensidadeGradual);

        gameObject.GetComponent<Light>().intensity = IntensidadeBase * IntensidadeAlvo;
    }
}
