using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerGato : MonoBehaviour
{
    public GameObject[] gatoOpcao;
    public AudioClip[] Miar;
    public float TempoSpawn;
    public float TempoEntre;
    public GameObject gatoPrefab;
    public int SpawnI;
    public int SpawnF;

    private AudioSource QuemMia;



    void Start()
    {
        SpawnI = 0;
        TempoSpawn = 2f;
        TempoEntre = .4f;

        QuemMia = GetComponent<AudioSource>();

        StartCoroutine(SpawnCat());
    }

    IEnumerator SpawnCat()
    {
        SpawnF = Random.Range(1, 4);
        while (SpawnI<SpawnF)
        {
            DefinirGato();
            Instantiate(gatoPrefab, transform.position, Quaternion.identity);

            AudioClip MiardaVez = Miar[Random.Range(0, Miar.Length)];
            QuemMia.PlayOneShot(MiardaVez);

            SpawnI++;

            yield return new WaitForSeconds(TempoEntre);

        }

        
        yield return new WaitForSeconds(TempoSpawn);
        SpawnI = 0;
        StartCoroutine(SpawnCat());

    }

    void DefinirGato()
    {
        int randomIndex = Random.Range(0, gatoOpcao.Length);
        gatoPrefab = gatoOpcao[randomIndex];
    }
}
