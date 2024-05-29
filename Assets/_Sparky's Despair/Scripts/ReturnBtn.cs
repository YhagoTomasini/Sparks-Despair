using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       // Invoke("teste", 2f);
        
    }

    // Update is called once per frame
    public void BUta()
    {
        // SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void teste()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
