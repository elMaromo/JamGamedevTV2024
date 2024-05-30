using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonInicio : MonoBehaviour
{
    public AudioSource audioSource; // El AudioSource que reproducir� el sonido
    public AudioClip clickSound; // El sonido que se reproducir�
    public float delay = 0.5f; // El tiempo en segundos antes de cambiar de escena

    // M�todo que se llama al pulsar el bot�n
    public void OnButtonClick()
    {
        // Reproduce el sonido
        audioSource.PlayOneShot(clickSound);

        // Inicia la corrutina para cambiar de escena despu�s de un retraso
        StartCoroutine(ChangeSceneAfterDelay());
    }

    // Corrutina que espera un tiempo antes de cambiar de escena
    private IEnumerator ChangeSceneAfterDelay()
    {
        // Espera el tiempo especificado
        yield return new WaitForSeconds(delay);

        // Cambia a la nueva escena
        SceneManager.LoadScene("seleccionDePersonajes");
    }
}
