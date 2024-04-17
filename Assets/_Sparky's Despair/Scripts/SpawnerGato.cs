using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerGato : MonoBehaviour
{
    public GameObject GatoI;
    public float TempoSpawn;
    public float TempoEntre;

    void Start()
    {
        TempoSpawn = 5f;
        TempoEntre = .5f;
        StartCoroutine(SpawnCat());
    }

    IEnumerator SpawnCat()
    {
        Instantiate(GatoI, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoEntre);

        Instantiate(GatoI, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoEntre);

        Instantiate(GatoI, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoEntre);

        Instantiate(GatoI, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(TempoSpawn);

        StartCoroutine(SpawnCat());


    }

    void Update()
    {
        
    }
}
