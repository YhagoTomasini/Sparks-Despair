using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerChao : MonoBehaviour
{
    public GameObject chaoPrefab;
    public float spawnDistancia;
    public float despawnDistancia;
    public float camPosicaoI;

    
    void Start()
    {
        camPosicaoI = 0f;
        spawnDistancia = 10f;
        despawnDistancia = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.z - camPosicaoI <= -spawnDistancia)
        {
            SpawnChao();
            camPosicaoI = Camera.main.transform.position.z;
        }
        foreach (Transform child in transform)
        {
            if (child.position.z > Camera.main.transform.position.z + despawnDistancia)
            {
                Destroy(child.gameObject);
            }
        }
    }
    void SpawnChao()
    {
        Quaternion rotation = Quaternion.Euler(90, 0, 0);
        GameObject Novochao = Instantiate(chaoPrefab, transform.position, rotation);

    }
}
