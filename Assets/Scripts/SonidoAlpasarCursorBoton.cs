using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource audioSource; // El AudioSource que reproducir� el sonido
    public AudioClip hoverSound; // El sonido que se reproducir� al poner el cursor encima

    // M�todo que se llama al poner el cursor encima del bot�n
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Reproduce el sonido
        audioSource.clip = hoverSound;
        audioSource.Play();
    }

    // M�todo que se llama al quitar el cursor del bot�n
    public void OnPointerExit(PointerEventData eventData)
    {
        // Detiene el sonido
        audioSource.Stop();
    }
}
