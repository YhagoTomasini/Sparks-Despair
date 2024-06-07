using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerChao : MonoBehaviour
{
    public GameObject[] chaoOpcao;
    public float spawnDistancia;
    public float despawnDistancia;
    private float camPosicaoI;

    
    void Start()
    {
        camPosicaoI = -3.5f;
        spawnDistancia = 11.9f;
        despawnDistancia = 60f;
    }

    void FixedUpdate()
    {
        GameObject[] Deletechao = GameObject.FindGameObjectsWithTag("tagchao");

        if (Camera.main.transform.position.z - camPosicaoI <= -spawnDistancia)
        {
            SpawnChao();
            camPosicaoI = Camera.main.transform.position.z;
        }

        foreach (GameObject Delete in Deletechao)
        {

            if (+Delete.transform.position.z > Camera.main.transform.position.z + despawnDistancia)
            {
                Destroy(Delete);
            }
        }
    }
    void SpawnChao()
    {
        int randomIndex = Random.Range(0, chaoOpcao.Length);
        GameObject chaoPrefab = chaoOpcao[randomIndex];

        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, Mathf.Round(camPosicaoI + spawnDistancia));
        Quaternion rotation = Quaternion.Euler(90, 0, 0);
        GameObject Novochao = Instantiate(chaoPrefab, transform.position, rotation);

        Novochao.tag = "tagchao";
    }
}
