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
        TempoSpawn = 2f;
        TempoEntre = 2f;

        StartCoroutine(SpawnTronco());
    }

    IEnumerator SpawnTronco()
    {
        TempoSpawn = Random.Range(0.5f, 3f);

        yield return new WaitForSeconds(TempoSpawn);

        Instantiate(Tronco, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(TempoEntre);

        StartCoroutine(SpawnTronco());

    }

}
