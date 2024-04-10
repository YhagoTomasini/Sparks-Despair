using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderMorte: MonoBehaviour

{


    IEnumerator MorteInimigo()
    {

        gameObject.transform.parent.GetComponent<PlayerMovement>().PodeMoverPersonagemGeral = false;
        Debug.Log("Inimigo");
        yield return new WaitForSeconds(5);
        Debug.Log("GAME OVER");



    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se a colisão envolve o personagem
        if (other.CompareTag("Dano"))
        {
            // Reinicia o jogo carregando a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.tag == "Inimigo")
        {
            StartCoroutine(MorteInimigo());
        }
    }
}