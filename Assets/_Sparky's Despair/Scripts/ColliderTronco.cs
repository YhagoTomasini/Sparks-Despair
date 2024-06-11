using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTronco : MonoBehaviour
{
    private PlayerMovement playerMove;


    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerMove = player.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CoAgua")
        {
            other.tag = "Teste";
        }
        else if (other.CompareTag("Player"))
        {
            //Debug.Log("Player entrou no tronco");

            playerMove.noTronco = true;

            Transform playerTransform = other.transform.parent;
            playerTransform.SetParent(gameObject.transform);

            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Teste"))
        {
            other.tag = "Dano";
        }
        else if (other.CompareTag("Player"))
        {
            ///Debug.Log("Player saiu do tronco");

            playerMove.noTronco = false;

            Transform playerTransform = other.transform.parent;
            playerTransform.position = new Vector3(Mathf.Round(playerTransform.position.x), 0.8f, Mathf.Round(playerTransform.position.z));
            playerTransform.SetParent(null);
        }
    }
}