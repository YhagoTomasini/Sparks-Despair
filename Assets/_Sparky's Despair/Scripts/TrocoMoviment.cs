using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocoMoviment : MonoBehaviour
{
    public float TroncoVelo;
    public float TroncoVida;
    private float Tempo = 0f;
    private float PosicaoI;

    void Start()
    {
        TroncoVelo = 2.5f;
        TroncoVida = 10f;

        PosicaoI = gameObject.transform.position.x;
        if (PosicaoI > 0f)
        {
            transform.Rotate(0, 180, 0);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * TroncoVelo * Time.deltaTime);
        Tempo += Time.deltaTime;

        if (Tempo >= TroncoVida)
        {
            Destroy(gameObject);
        }

    }
}
