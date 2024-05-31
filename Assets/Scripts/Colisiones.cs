
using UnityEngine;


public class Colisiones : MonoBehaviour
{
    public AudioSource audioColision;
    // Este método se llama cuando el colisionador entra en contacto con otro colisionador
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="enemy"){
            Debug.Log("Colisionó con " + collision.gameObject.name);
            audioColision.Play();
        }
    }
    /*
    // Este método se llama mientras el colisionador está en contacto con otro colisionador
    private void OnCollisionStay(Collision collision)
    {
        // Puedes usar esto para detectar colisiones continuas
        Debug.Log("Manteniendo colisión con " + collision.gameObject.name);
    }

    // Este método se llama cuando el colisionador deja de estar en contacto con otro colisionador
    private void OnCollisionExit(Collision collision)
    {
        // Imprime un mensaje cuando se termina la colisión
        Debug.Log("Dejó de colisionar con " + collision.gameObject.name);
    }*/
}
