using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{


    public GameObject Player;

    //public GameObject PlayerColliderEsquerda;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Esquerda")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaEsquerda = false;
        }

        else
        {
         // podeMoverParaEsquerda = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Esquerda")
        {

            Player.GetComponent<PlayerMovement>().podeMoverParaEsquerda = true;
        }
    }

        // Start is called before the first frame update
        void Start()
    {
        Player = GameObject.Find("Player");

        //PlayerColliderEsquerda = GameObject.Find("Esquerda");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
