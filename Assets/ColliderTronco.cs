using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTronco : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
    
        if (other.CompareTag("Dano"))
        {
            other.tag = "Teste";

          // other.enabled = false;
        //   other.gameObject.SetActive(false);
        }

      else  if (other.CompareTag("Player"))
        {
            other.transform.parent.SetParent(gameObject.transform);
        }
    }


    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Teste"))
        {
            other.tag = "Dano";
          // other.enabled = true;
          //  other.gameObject.SetActive(true);
        }
        if (other.CompareTag("Player"))
        {
            other.transform.parent.transform.position = new Vector3(Mathf.Round(other.transform.parent.transform.position.x),0.8f, Mathf.Round(other.transform.parent.transform.position.z));
            other.transform.parent.SetParent(null);


            
        }
    }
}