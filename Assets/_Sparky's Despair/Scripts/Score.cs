using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int scoreValue;
    public GameObject ScoreText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        // Verifica se a colisão envolve o personagem
        if (other.gameObject.name == "ColliderPlayer")
        {
            scoreValue++;

            gameObject.transform.position = new Vector3(0, 1, gameObject.transform.position.z - 1);
            ScoreText.GetComponent<TextMeshProUGUI>().text = scoreValue.ToString();

          //  Debug.Log(scoreValue);
        }





    }
}
