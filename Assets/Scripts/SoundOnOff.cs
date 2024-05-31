using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    public Boolean muteButton;
    public bool isMuted;
    // Start is called before the first frame update
    void Start()
    {
        isMuted=false;
        //AddListener(ToggleMute);
    }

    public void Onclick(){
        if(muteButton==false){
            muteButton=true;
            Update();
        }
        if(muteButton==true){
           muteButton=false;
            Update(); 
        }
    }
    void Update(){
        if (isMuted == true){
            ToggleMute();
        }
        if(isMuted == false)
        {
            SoundOn();
        }
    }
    //
    void ToggleMute()
    {
        if(isMuted == true){
            AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSource in allAudioSources)
            {
                audioSource.mute = isMuted;
            }

        }
    }
    void SoundOn(){
        if(isMuted == false){
            AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSource in allAudioSources)
            {
                audioSource.Play();
            }

        }
    }
}
