using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerOrdem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MenosL"))
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder= -10;
            
            Debug.Log("gatito");
        }
    }
}
