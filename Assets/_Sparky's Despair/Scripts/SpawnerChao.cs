using JetBrains.Annotations;
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
        despawnDistancia = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Deletechao = GameObject.FindGameObjectsWithTag("tagchao");

        if (Camera.main.transform.position.z - camPosicaoI <= -spawnDistancia)
        {
            SpawnChao();
            camPosicaoI = Camera.main.transform.position.z;
        }

        foreach (GameObject Delete in Deletechao)
        {
           // Debug.Log("Posição do filho: " + Deletechao.transform.position.z);

            if (+Delete.transform.position.z > Camera.main.transform.position.z + despawnDistancia)
            {
                Destroy(Delete);
            }
        }
    }
    void SpawnChao()
    {
        Quaternion rotation = Quaternion.Euler(90, 0, 0);
        GameObject Novochao = Instantiate(chaoPrefab, transform.position, rotation);
        Novochao.tag = "tagchao";
    }
}
