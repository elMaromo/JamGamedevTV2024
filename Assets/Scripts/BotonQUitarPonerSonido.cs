using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonQUitarPonerSonido : MonoBehaviour
{
    public GameObject imageSoundObject;
    public Sprite soundSprite;
    public Sprite noSoundSprite;

    private AudioListener audioListener;
    private Image imageSound;

    void Start()
    {
        // Obt�n el componente AudioListener del GameObject al que est� adjunto este script
        imageSound = imageSoundObject.GetComponent<Image>();

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

            if (audioListener.enabled)
            {
                imageSound.sprite = soundSprite;
            }
            else
            {
                imageSound.sprite = noSoundSprite;
            }
        }
    }
}
