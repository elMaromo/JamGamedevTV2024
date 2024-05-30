using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource audioSource; // El AudioSource que reproducirá el sonido
    public AudioClip hoverSound; // El sonido que se reproducirá al poner el cursor encima

    // Método que se llama al poner el cursor encima del botón
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Reproduce el sonido
        audioSource.clip = hoverSound;
        audioSource.Play();
    }

    // Método que se llama al quitar el cursor del botón
    public void OnPointerExit(PointerEventData eventData)
    {
        // Detiene el sonido
        audioSource.Stop();
    }
}
