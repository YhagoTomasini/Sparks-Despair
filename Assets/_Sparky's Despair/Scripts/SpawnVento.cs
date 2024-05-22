using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVento : MonoBehaviour
{
    public float TempoSpawn;
    public GameObject VentoPrefab;
    public animation Animvento;

    void Start()
    {
        StartCoroutine (SpawnV());
    }


    IEnumerator SpawnV()
    {
        TempoSpawn = Random.Range (4, 6);
        yield return new WaitForSeconds(TempoSpawn);

        GameObject VentoInstance = Instantiate(VentoPrefab, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(2f);
        

        Destroy(VentoInstance);


        StartCoroutine(SpawnV());
    }
}
