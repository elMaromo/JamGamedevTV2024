using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject hasPerdido, hasGanado;
    public int numEnemigos;


    private bool haTerminado = false;
    private int contador = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (!haTerminado)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                PerderFuncion();
            }
            if (other.gameObject.CompareTag("enemy"))
            {
                contador++;

                if (contador == numEnemigos)
                {
                    GanarFuncion();
                }
            }
        }
    }


    public void PerderFuncion()
    {
        hasPerdido.SetActive(true);
        haTerminado = true;
    }

    public void GanarFuncion()
    {
        hasGanado.SetActive(true);
        haTerminado = true;
    }
}
