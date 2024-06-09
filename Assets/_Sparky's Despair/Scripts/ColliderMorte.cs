using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderMorte: MonoBehaviour

{
    public Animator AnimFire;
    public Animator AnimLegs;
    public Animator Queda;

    public GameObject Olhos;
    public GameObject Luz;
    public GameObject Sombra;
    public GameObject Player;
    public GameObject Splash;

    //private float QuedaVelo;

    public MonoBehaviour AnimVida;
    private Vector3 posicaoCamera;

    public AudioSource SoprodaMorte;
    public AudioClip SomSopro;

    private bool morto;

    private void Start()
    {
        morto = false;
        posicaoCamera = Camera.main.transform.position;
        //QuedaVelo = 2f;
    }

    IEnumerator MorteInimigo()
    {
        if (morto == false)
        {
            gameObject.transform.parent.GetComponent<PlayerMovement>().PodeMoverPersonagemGeral = false;

            Luz.SetActive(false);

            Olhos.SetActive(false);
            AnimFire.SetBool("Apagou", true);
            AnimVida.enabled = false;

            Sombra.GetComponent<SpriteRenderer>().enabled = false;

            AnimLegs.SetBool("Morto", true);

            SoprodaMorte.PlayOneShot(SomSopro);

            morto = true;

            Camera.main.GetComponent<CamMoviment>().enabled = false;
            Vector3 novaPosicaoCam = new Vector3(posicaoCamera.x, posicaoCamera.y, gameObject.transform.position.z - 12);
            Camera.main.transform.position = novaPosicaoCam;


            yield return new WaitForSeconds(5);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            morto = false;
        }
        
    }

    IEnumerator MorteAgua()
    {
        if (morto == true)
        {
            Splash.SetActive(true);

            Queda.SetBool("caindo", true);
            yield return null;

            //Vector3 QuedaDirecao = new Vector3(0, -1, 1);

            /*while (true)
            {
               Player.transform.Translate(QuedaDirecao * QuedaVelo * Time.deltaTime);
                yield return null;
            }*/
        }
            
        
    }

    IEnumerator MorteBuraco()
    {
        if (morto == true)
        {
            Queda.SetBool("caindo", true);
            yield return null;



            //Vector3 QuedaDirecao = new Vector3(0, -1 / 2, 1);

            /*while (true)
            {
                Player.transform.Translate(QuedaDirecao * QuedaVelo * Time.deltaTime);

                yield return null;
            }*/
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
            if (other.gameObject.name == "CoBuraco")
            {
                StartCoroutine(MorteBuraco());
            }
        }
    }
}