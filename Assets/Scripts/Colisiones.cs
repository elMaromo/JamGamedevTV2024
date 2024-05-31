
using UnityEngine;


public class Colisiones : MonoBehaviour
{
    public AudioSource audioColision;
    // Metodo colisionador
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="enemy"){
            audioColision.Play();
        }
    }
}
