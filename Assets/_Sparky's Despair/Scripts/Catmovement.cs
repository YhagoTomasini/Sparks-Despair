using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Catmovement : MonoBehaviour
{
    public GameObject Spawner;

    public float CatVelocidade;
    public float CatVida;
    private float Tempo = 0f;
    private float PosicaoI;

    void Start()
    {
        CatVelocidade = 5f;
        CatVida = 3f;
        PosicaoI = gameObject.transform.position.x;
        if (PosicaoI > 0f)
        {
            transform.Rotate(-60, 180, 0); 
        }
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
