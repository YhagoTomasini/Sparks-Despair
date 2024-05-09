using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderMorte: MonoBehaviour

{
    public Animator AnimFire;
    public Animator AnimLegs;
    public GameObject Olhos;
    public GameObject Luz;
    public GameObject Sombra;
    public MonoBehaviour AnimVida;
    private Vector3 posicaoCamera;

    private void Start()
    {
        posicaoCamera = Camera.main.transform.position;
    }

    IEnumerator MorteInimigo()
    {

        gameObject.transform.parent.GetComponent<PlayerMovement>().PodeMoverPersonagemGeral = false;

        Luz.SetActive(false);

        Olhos.SetActive(false);
        AnimFire.SetBool("Apagou", true);
        AnimVida.enabled = false;

        Sombra.GetComponent<SpriteRenderer>().enabled = false;

        AnimLegs.SetBool("Morto", true);

        Camera.main.GetComponent<CamMoviment>().enabled = false;
        Vector3 novaPosicaoCam = new Vector3(posicaoCamera.x, posicaoCamera.y, gameObject.transform.position.z - 12);
        Camera.main.transform.position = novaPosicaoCam;

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