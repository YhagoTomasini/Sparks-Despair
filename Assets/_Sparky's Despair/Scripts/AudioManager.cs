using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class AudioManager : MonoBehaviour
{
    // Referência para o AudioSource principal do jogo
    public AudioSource mainAudioSource;
    public AudioSource chuvas;
    public AudioSource fogo;
    public AudioSource passos;
    public AudioSource trova;


    public Toggle musics;
    public Toggle effect;


    private void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("SomLigado"));
        Debug.Log(PlayerPrefs.GetInt("SomChu"));
        Debug.Log(PlayerPrefs.GetInt("SomFo"));
        Debug.Log(PlayerPrefs.GetInt("SomPa"));
        Debug.Log(PlayerPrefs.GetInt("SomTro"));
    }

    private void Start()
    {
        //PlayerPrefs.SetInt("SomTest", 1);
        //   ToggleMute();

        if (PlayerPrefs.GetInt("SomLigado") == 0)
        {
            mainAudioSource.mute = false;
        }
       else if (PlayerPrefs.GetInt("SomLigado") == 1)
        {

            mainAudioSource.mute = true;
            musics.SetIsOnWithoutNotify(false);
            // ToggleMute();
        }

        if (PlayerPrefs.GetInt("SomChu") == 0)
        {
            chuvas.mute = false;
        }
        else if (PlayerPrefs.GetInt("SomChu") == 1)
        {

            chuvas.mute = true;
            effect.SetIsOnWithoutNotify(false);
            // ToggleMute();
        }

        if (PlayerPrefs.GetInt("SomFo") == 0)
        {
            fogo.mute = false;
        }
        else if (PlayerPrefs.GetInt("SomFo") == 1)
        {

            fogo.mute = true;
            effect.SetIsOnWithoutNotify(false);
            // ToggleMute();
        }


        if (PlayerPrefs.GetInt("SomPa") == 0)
        {
            passos.mute = false;
        }
        else if (PlayerPrefs.GetInt("SomPa") == 1)
        {

            passos.mute = true;
            effect.SetIsOnWithoutNotify(false);
            // ToggleMute();
        }


        if (PlayerPrefs.GetInt("SomTro") == 0)
        {
            trova.mute = false;
        }
        else if (PlayerPrefs.GetInt("SomTro") == 1)
        {

            trova.mute = true;
            effect.SetIsOnWithoutNotify(false);
            // ToggleMute();
        }
    }

    // Méto para alternar entre mutar e desmutar o som
    public void ToggleMute()
    {
        if (PlayerPrefs.GetInt("SomLigado") == 0)
        {
            PlayerPrefs.SetInt("SomLigado", 1);
            // Inverte o estado de mudo do AudioSource principal
            mainAudioSource.mute = !mainAudioSource.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }

        else if(PlayerPrefs.GetInt("SomLigado") == 1)
        {
            PlayerPrefs.SetInt("SomLigado", 0);
            // Inverte o estado de mudo do AudioSource principal
            mainAudioSource.mute = !mainAudioSource.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }


    }

    // Méto para definir explicitamente o som ligado ou desligado
    public void SetMute(bool isMuted)
    {
        // Define o estado de mudo do AudioSource principal conforme o argumento
        mainAudioSource.mute = isMuted;
    }

    public void ToggleMuteC()
    {
        if (PlayerPrefs.GetInt("SomChu") == 0)
        {
            PlayerPrefs.SetInt("SomChu", 1);
            // Inverte o estado de mudo do AudioSource principal
            chuvas.mute = !chuvas.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }

        else if (PlayerPrefs.GetInt("SomChu") == 1)
        {
            PlayerPrefs.SetInt("SomChu", 0);
            // Inverte o estado de mudo do AudioSource principal
            chuvas.mute = !chuvas.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }

    }

    // Méto para definir explicitamente o som ligado ou desligado
    public void SetMuteC(bool isMuted)
    {
        // Define o estado de mudo do AudioSource principal conforme o argumento
        chuvas.mute = isMuted;
    }
    public void ToggleMuteF()
    {
        if (PlayerPrefs.GetInt("SomFo") == 0)
        {
            PlayerPrefs.SetInt("SomFo", 1);
            // Inverte o estado de mudo do AudioSource principal
            fogo.mute = !fogo.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }

        else if (PlayerPrefs.GetInt("SomFo") == 1)
        {
            PlayerPrefs.SetInt("SomFo", 0);
            // Inverte o estado de mudo do AudioSource principal
            fogo.mute = !fogo.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }

    }

    // Méto para definir explicitamente o som ligado ou desligado
    public void SetMuteF(bool isMuted)
    {
        // Define o estado de mudo do AudioSource principal conforme o argumento
        fogo.mute = isMuted;
    }
    public void ToggleMuteP()
    {
        if (PlayerPrefs.GetInt("SomPa") == 0)
        {
            PlayerPrefs.SetInt("SomPa", 1);
            // Inverte o estado de mudo do AudioSource principal
            passos.mute = !passos.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }

        else if (PlayerPrefs.GetInt("SomPa") == 1)
        {
            PlayerPrefs.SetInt("SomPa", 0);
            // Inverte o estado de mudo do AudioSource principal
            passos.mute = !passos.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }
        
    }

    // Méto para definir explicitamente o som ligado ou desligado
    public void SetMuteP(bool isMuted)
    {
        // Define o estado de mudo do AudioSource principal conforme o argumento
        passos.mute = isMuted;
    }
    public void ToggleMuteT()
    {
        if (PlayerPrefs.GetInt("SomTro") == 0)
        {
            PlayerPrefs.SetInt("SomTro", 1);
            // Inverte o estado de mudo do AudioSource principal
            trova.mute = !trova.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }

        else if (PlayerPrefs.GetInt("SomTro") == 1)
        {
            PlayerPrefs.SetInt("SomTro", 0);
            // Inverte o estado de mudo do AudioSource principal
            trova.mute = !trova.mute;
            //btnTest.isOn = true;
            //btnTest.isOn = false;
        }
       
    }

    // Méto para definir explicitamente o som ligado ou desligado
    public void SetMuteT(bool isMuted)
    {
        // Define o estado de mudo do AudioSource principal conforme o argumento
        trova.mute = isMuted;
    }
}
