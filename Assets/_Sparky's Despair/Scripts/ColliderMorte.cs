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
    public GameObject Player;
    public GameObject Splash;

    private float QuedaVelo;

    public MonoBehaviour AnimVida;
    private Vector3 posicaoCamera;

    private void Start()
    {
        posicaoCamera = Camera.main.transform.position;
        QuedaVelo = 4f;
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

    IEnumerator MorteAgua()
    {
        Splash.SetActive(true);
        //AnimFire.enabled = false;
        //Vector3 QuedaDirecao = Vector3.down + Vector3.forward
        while (true)
        {
            Player.transform.Translate((new Vector3 (0, -1, 1)).normalized * QuedaVelo * Time.deltaTime);
            yield return (null);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dano"))
        {
            StartCoroutine(MorteInimigo());

            if (other.gameObject.name == "CoAgua")
            {
                StartCoroutine(MorteAgua());
            }
        }
    }
}