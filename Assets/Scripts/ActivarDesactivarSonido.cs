using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDesactivarSonido : MonoBehaviour
{
    private AudioListener audioListener;

    void Start()
    {
        // Obt�n el componente AudioListener del GameObject al que est� adjunto este script
        audioListener = GetComponent<AudioListener>();

        if (audioListener == null)
        {
            Debug.LogError("No AudioListener found on this GameObject");
        }
    }

    // M�todo para alternar el estado del AudioListener
    public void ToggleAudioListener()
    {
        if (audioListener != null)
        {
            audioListener.enabled = !audioListener.enabled;
        }
    }
}
