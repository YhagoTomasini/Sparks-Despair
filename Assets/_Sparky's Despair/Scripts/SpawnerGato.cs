using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerGato : MonoBehaviour
{
    public GameObject[] gatoOpcao;
    public float TempoSpawn;
    public float TempoEntre;
    public GameObject gatoPrefab;

    void Start()
    {
        TempoSpawn = 5f;
        TempoEntre = .6f;
        StartCoroutine(SpawnCat());
    }

    IEnumerator SpawnCat()
    {
        DefinirGato();
        Instantiate(gatoPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoEntre);

        DefinirGato();
        Instantiate(gatoPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoEntre);

        DefinirGato();
        Instantiate(gatoPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoEntre);

        DefinirGato();
        Instantiate(gatoPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoSpawn);

        DefinirGato();
        StartCoroutine(SpawnCat());


    }

    void DefinirGato()
    {
        int randomIndex = Random.Range(0, gatoOpcao.Length);
        gatoPrefab = gatoOpcao[randomIndex];
    }
}
