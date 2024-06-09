using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class AudioManager : MonoBehaviour
{
    public AudioSource mainAudioSource;
    public AudioSource chuvas;
    public AudioSource fogo;
    public AudioSource passos;
    public AudioSource trova;

    public Toggle musics;
    public Toggle effect;
    public Toggle musicsP;
    public Toggle effectP;

    private void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("SomLigado"));
        //Debug.Log(PlayerPrefs.GetInt("SomChu"));
        //Debug.Log(PlayerPrefs.GetInt("SomFo"));
        //Debug.Log(PlayerPrefs.GetInt("SomPa"));
        //Debug.Log(PlayerPrefs.GetInt("SomTro"));

        if (Input.GetKeyDown(KeyCode.M))
        {
            ResetAllSounds();
        }
    }

    private void Start()
    {
        MuteAudioSource(mainAudioSource, "SomLigado", musics);
        MuteAudioSource(chuvas, "SomChu", effect);
        MuteAudioSource(fogo, "SomFo", effect);
        MuteAudioSource(passos, "SomPa", effect);
        MuteAudioSource(trova, "SomTro", effect);

        MuteAudioSource(mainAudioSource, "SomLigado", musicsP);
        MuteAudioSource(chuvas, "SomChu", effectP);
        MuteAudioSource(fogo, "SomFo", effectP);
        MuteAudioSource(passos, "SomPa", effectP);
        MuteAudioSource(trova, "SomTro", effectP);
    }

    private void MuteAudioSource(AudioSource audioSource, string playerPrefKey, Toggle toggle)
    {
        if (audioSource != null)
        {
            if (PlayerPrefs.GetInt(playerPrefKey) == 0)
            {
                audioSource.mute = false;
            }
            else if (PlayerPrefs.GetInt(playerPrefKey) == 1)
            {
                audioSource.mute = true;
                if (toggle != null)
                {
                    toggle.SetIsOnWithoutNotify(false);
                }
            }
        }
    }

    // Método para alternar entre mutar e desmutar o som
    public void ToggleMute()
    {
        ToggleMuteAudioSource(mainAudioSource, "SomLigado");
    }

    // Método para definir explicitamente o som ligado ou desligado
    public void SetMute(bool isMuted)
    {
        mainAudioSource.mute = isMuted;
    }

    public void ToggleMuteC()
    {
        ToggleMuteAudioSource(chuvas, "SomChu");
    }

    public void SetMuteC(bool isMuted)
    {
        chuvas.mute = isMuted;
    }

    public void ToggleMuteF()
    {
        ToggleMuteAudioSource(fogo, "SomFo");
    }

    public void SetMuteF(bool isMuted)
    {
        fogo.mute = isMuted;
    }

    public void ToggleMuteP()
    {
        ToggleMuteAudioSource(passos, "SomPa");
    }

    public void SetMuteP(bool isMuted)
    {
        passos.mute = isMuted;
    }

    public void ToggleMuteT()
    {
        ToggleMuteAudioSource(trova, "SomTro");
    }

    public void SetMuteT(bool isMuted)
    {
        trova.mute = isMuted;
    }

    private void ToggleMuteAudioSource(AudioSource audioSource, string playerPrefKey)
    {
        if (audioSource != null)
        {
            int newPrefValue = PlayerPrefs.GetInt(playerPrefKey) == 0 ? 1 : 0;
            PlayerPrefs.SetInt(playerPrefKey, newPrefValue);
            audioSource.mute = !audioSource.mute;
        }
    }

    // Método para resetar todas as configurações de som e ligar todos os sons
    public void ResetAllSounds()
    {
        PlayerPrefs.SetInt("SomLigado", 0);
        PlayerPrefs.SetInt("SomChu", 0);
        PlayerPrefs.SetInt("SomFo", 0);
        PlayerPrefs.SetInt("SomPa", 0);
        PlayerPrefs.SetInt("SomTro", 0);

        if (musics != null)
        {
            musics.SetIsOnWithoutNotify(true);
        }
        if (effect != null)
        {
            effect.SetIsOnWithoutNotify(true);
        }

        if (musicsP != null)
        {
            musicsP.SetIsOnWithoutNotify(true);
        }
        if (effectP != null)
        {
            effectP.SetIsOnWithoutNotify(true);
        }

        mainAudioSource.mute = false;
        chuvas.mute = false;
        fogo.mute = false;
        passos.mute = false;
        trova.mute = false;
    }
}
