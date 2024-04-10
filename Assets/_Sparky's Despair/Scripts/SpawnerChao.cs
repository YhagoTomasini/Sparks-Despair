using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerChao : MonoBehaviour
{
    public GameObject chaoPrefab;
    public float spawnDistancia = .2f;
    public float despawnDistancia = .4f;
    public float camPosicaoI;

    
    void Start()
    {
        camPosicaoI = Camera.main.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.z - camPosicaoI >= spawnDistancia)
        {
            SpawnChao();
            camPosicaoI = Camera.main.transform.position.z;
        }
        foreach (Transform child in transform)
        {
            if (child.position.z < Camera.main.transform.position.z - despawnDistancia)
            {
                Destroy(child.gameObject);
            }
        }
    }
    void SpawnChao()
    {
       GameObject Novochao = Instantiate(chaoPrefab, transform.position, Quaternion.identity);
    }
}
