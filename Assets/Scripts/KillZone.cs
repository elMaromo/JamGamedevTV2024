using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public void OnTriggerEnter( Collider other )
    {
        if( other.gameObject.CompareTag("Player"))
        {
            print("has perdido");
        }
    }
}
