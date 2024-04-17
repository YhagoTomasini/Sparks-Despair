using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catmovement : MonoBehaviour
{
    public float CatVelocidade;
    public float CatVida;
    private float Tempo = 0f;

    void Start()
    {
        CatVelocidade = 5f;
        CatVida = 3f;
    }

    void Update()
    {
        transform.Translate(Vector3.right * CatVelocidade * Time.deltaTime);
        Tempo += Time.deltaTime;

        if (Tempo >= CatVida)
        {
            Destroy(gameObject);
        }
    }
}
