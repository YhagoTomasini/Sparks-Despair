using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesoBonus : MonoBehaviour
{
    public GameObject BonusDesodorante;
    // Start is called before the first frame update
    void Start()
    {
        BonusDesodorante.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Desodorante"))
        {
            Debug.Log("hm cheirinho de acetona");
            BonusDesodorante.SetActive(true);

        }
    }
}
