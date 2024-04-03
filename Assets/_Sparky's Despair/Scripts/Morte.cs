using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morte : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se a colisão envolve o personagem
        if (other.CompareTag("Dano"))
        {
            // Reinicia o jogo carregando a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        {
            Debug.LogWarning("Transformação da câmera não encontrada!");
        }
    }
}