using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderMorte: MonoBehaviour

{
    public Animator AnimFire;
    public GameObject Olhos;
    public GameObject Fogo;
    private Vector3 posicaoCamera;

    private void Start()
    {
        posicaoCamera = Camera.main.transform.position;
    }

    IEnumerator MorteInimigo()
    {

        gameObject.transform.parent.GetComponent<PlayerMovement>().PodeMoverPersonagemGeral = false;
        Olhos.SetActive(false);

        Camera.main.GetComponent<CamMoviment>().enabled = false;

        Vector3 novaPosicaoCam = new Vector3(posicaoCamera.x, posicaoCamera.y, gameObject.transform.position.z - 15);
        Camera.main.transform.position = novaPosicaoCam;

        AnimFire.SetBool("Apagou", true);

        Fogo.transform.position = new Vector3 (Fogo.transform.position.x, Fogo.transform.position.y + 1, Fogo.transform.position.z);
        

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se a colisão envolve o personagem
        //if (other.CompareTag("Dano"))
        //{
        //    // Reinicia o jogo carregando a cena atual
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //}
        if (other.CompareTag("Dano"))
        {
            StartCoroutine(MorteInimigo());
        }
    }
}