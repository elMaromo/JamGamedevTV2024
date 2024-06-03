using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    // Start is called before the first frame update
    public List<AudioSource> allAudioSources;
    public Sprite soundSprite;
    public Sprite noSoundSprite;
    public Image imageSound;

    private bool audioActivated = true;

    public void toggleAudio()
    {
        audioActivated = !audioActivated;
        if (audioActivated)
        {
            imageSound.sprite = soundSprite;
        }
        else
        {
            imageSound.sprite = noSoundSprite;
        }

        for (int i = 0; i < allAudioSources.Count; i++)
        {
            if (audioActivated)
            {
                allAudioSources[i].UnPause();
            }
            else
            {
                allAudioSources[i].Pause();
            }
        }
    }
}
