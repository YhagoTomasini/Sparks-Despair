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
    public AudioSource gatos;
    public AudioSource raio;

    public Toggle musics;
    public Toggle effect;
    public Toggle musicsP;
    public Toggle effectP;

    private List<AudioSource> checkedAudioSources = new List<AudioSource>();


    private void Update()
    {
        CheckAndMuteNewAudioSources();


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
        SoundPrefs();
    }

    public void SoundPrefs()
    {
        MuteAudioSource(mainAudioSource, "SomLigado", musics);
        MuteAudioSource(chuvas, "SomChu", effect);
        MuteAudioSource(fogo, "SomFo", effect);
        MuteAudioSource(passos, "SomPa", effect);
        MuteAudioSource(trova, "SomTro", effect);
        MuteAudioSource(gatos, "SomGa", effect);
        MuteAudioSource(raio, "SomRa", effect);


        MuteAudioSource(mainAudioSource, "SomLigado", musicsP);
        MuteAudioSource(chuvas, "SomChu", effectP);
        MuteAudioSource(fogo, "SomFo", effectP);
        MuteAudioSource(passos, "SomPa", effectP);
        MuteAudioSource(trova, "SomTro", effectP);
        MuteAudioSource(gatos, "SomGa", effectP);
        MuteAudioSource(raio, "SomRa", effectP);


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

    private void CheckAndMuteNewAudioSources()
    {
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audioSource in allAudioSources)
        {
            if (!checkedAudioSources.Contains(audioSource))
            {
                // Adicione verificações para mutar o novo audio source conforme as preferências
                if (audioSource == mainAudioSource)
                    MuteAudioSource(audioSource, "SomLigado", musics);
                else if (audioSource == chuvas)
                    MuteAudioSource(audioSource, "SomChu", effect);
                else if (audioSource == fogo)
                    MuteAudioSource(audioSource, "SomFo", effect);
                else if (audioSource == passos)
                    MuteAudioSource(audioSource, "SomPa", effect);
                else if (audioSource == trova)
                    MuteAudioSource(audioSource, "SomTro", effect);
                else if (audioSource == raio)
                    MuteAudioSource(audioSource, "SomRa", effect);
                else if (audioSource == gatos)
                    MuteAudioSource(audioSource, "SomGa", effect);
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

    public void ToggleMuteG()
    {
        ToggleMuteAudioSource(gatos, "SomGa");
    }

    public void SetMuteG(bool isMuted)
    {
        gatos.mute = isMuted;
    }

    public void ToggleMuteR()
    {
        ToggleMuteAudioSource(raio, "SomRa");
    }

    public void SetMuteR(bool isMuted)
    {
        raio.mute = isMuted;
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

    public void ResetAllSounds()
    {
        PlayerPrefs.SetInt("SomLigado", 0);
        PlayerPrefs.SetInt("SomChu", 0);
        PlayerPrefs.SetInt("SomFo", 0);
        PlayerPrefs.SetInt("SomPa", 0);
        PlayerPrefs.SetInt("SomTro", 0);
        PlayerPrefs.SetInt("SomGa", 0);
        PlayerPrefs.SetInt("SomRa", 0);

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
        gatos.mute = false; 
        raio.mute = false;


        checkedAudioSources.Clear();
    }
}
