using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocoMoviment : MonoBehaviour
{
    public float TroncoVelo;
    public float TroncoVida;
    private float Tempo = 0f;

    void Start()
    {
        TroncoVelo = 1.5f;
        TroncoVida = 12f;
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
