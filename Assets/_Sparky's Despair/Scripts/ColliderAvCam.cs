using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAvCam : MonoBehaviour
{
    // Declaração do delegate e do evento
    public delegate void AvancoC();
    public event AvancoC AtivarAvCam;

    // Método chamado quando algo entra no collider
    public void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no collider é o jogador
        if (other.CompareTag("Player"))
        {
            // Se for o jogador, dispara o evento
            Debug.Log("Player entrou no collider");
            OnAtivarAvCam(); // Invoca o método para disparar o evento
        }
    }

    // Método para disparar o evento
    protected virtual void OnAtivarAvCam()
    {
        // Verifica se há assinantes para o evento
        if (AtivarAvCam != null)
        {
            // Se houver assinantes, dispara o evento
            AtivarAvCam();
        }
    }
}