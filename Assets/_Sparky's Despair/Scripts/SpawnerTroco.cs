using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTroco : MonoBehaviour
{
    public GameObject Tronco;
    public float TempoSpawn;
    public float TempoEntre;



    void Start()
    {
        TempoSpawn = 1f;
        TempoEntre = 1f;

        StartCoroutine(SpawnTronco());
    }

    IEnumerator SpawnTronco()
    {
        TempoSpawn = Random.Range(0.25f, 1f);

        yield return new WaitForSeconds(TempoSpawn);

        Instantiate(Tronco, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(TempoEntre);

        StartCoroutine(SpawnTronco());

    }

}
