using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager2 : MonoBehaviour
{
    public AudioSource mainAudioSource;
    public AudioSource chuvas;
    public AudioSource fogo;
    public AudioSource passos;
    public AudioSource trova;

    public Toggle musics;
    public Toggle effect;

    private void OnEnable()
    {
        AudioEvents.OnSoundSettingsChanged.AddListener(UpdateAllAudioSources);
    }

    private void OnDisable()
    {
        AudioEvents.OnSoundSettingsChanged.RemoveListener(UpdateAllAudioSources);
    }

    private void Start()
    {
        UpdateAllAudioSources();
    }

    private void UpdateAllAudioSources()
    {
        MuteAudioSource(mainAudioSource, "SomLigado", musics);
        MuteAudioSource(chuvas, "SomChu", effect);
        MuteAudioSource(fogo, "SomFo", effect);
        MuteAudioSource(passos, "SomPa", effect);
        MuteAudioSource(trova, "SomTro", effect);
    }

    private void MuteAudioSource(AudioSource audioSource, string playerPrefKey, Toggle toggle)
    {
        if (audioSource != null)
        {
            bool isMuted = PlayerPrefs.GetInt(playerPrefKey) == 1;
            audioSource.mute = isMuted;
            if (toggle != null)
            {
                toggle.SetIsOnWithoutNotify(!isMuted);
            }
        }
    }

    public void ToggleMute(string playerPrefKey, AudioSource audioSource, Toggle toggle)
    {
        if (audioSource != null)
        {
            int currentValue = PlayerPrefs.GetInt(playerPrefKey);
            int newValue = currentValue == 0 ? 1 : 0;
            PlayerPrefs.SetInt(playerPrefKey, newValue);
            audioSource.mute = (newValue == 1);
            if (toggle != null)
            {
                toggle.SetIsOnWithoutNotify(newValue == 0);
            }
            AudioEvents.OnSoundSettingsChanged.Invoke();
        }
    }

    public void ResetAllSounds()
    {
        PlayerPrefs.SetInt("SomLigado", 0);
        PlayerPrefs.SetInt("SomChu", 0);
        PlayerPrefs.SetInt("SomFo", 0);
        PlayerPrefs.SetInt("SomPa", 0);
        PlayerPrefs.SetInt("SomTro", 0);

        mainAudioSource.mute = false;
        chuvas.mute = false;
        fogo.mute = false;
        passos.mute = false;
        trova.mute = false;

        if (musics != null)
        {
            musics.SetIsOnWithoutNotify(true);
        }
        if (effect != null)
        {
            effect.SetIsOnWithoutNotify(true);
        }

        AudioEvents.OnSoundSettingsChanged.Invoke();
    }
}
