using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    public Boolean muteButton=false; //audio activado
    public bool isMuted;
    // Start is called before the first frame update
    void Start()
    {
        //empieza con el audio activado
        //isMuted=false;
        //AddListener(ToggleMute);
    }

    public void Onclick(){
        if(muteButton==false){
            Mute();//mutea audio
        }
        if(muteButton==true){
            SoundOn();
        }
    }
    //
    void Mute()
    {
            AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSourceOff in allAudioSources)
            {
                audioSourceOff.Pause(); 
            }
    }
    void SoundOn(){
            AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSourceOn in allAudioSources)
            {
                audioSourceOn.Play();
            }
        }
}
