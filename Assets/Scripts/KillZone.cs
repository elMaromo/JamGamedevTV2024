using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    int contador=0;
    public void OnTriggerEnter( Collider other )
    {
        if( other.gameObject.CompareTag("Player"))
        {
            print("has perdido");
        }
        if (other.gameObject.CompareTag("enemy")) { 
            print(other.gameObject.name +" eliminado");
            Debug.Log(other.gameObject.name +" eliminado");
            //contador
            }
    }
}
