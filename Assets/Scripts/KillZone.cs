using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KillZone : MonoBehaviour
{
    public GameObject hasPerdido, hasGanado;
    public TextMeshProUGUI hasGanadoText;
    public int numEnemigos;


    private float cuentaTiempo = 0;
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

    public void Update()
    {
        if (!haTerminado)
        {
            cuentaTiempo += Time.deltaTime;
        }
    }


    public void PerderFuncion()
    {
        hasPerdido.SetActive(true);
        haTerminado = true;
    }

    public void GanarFuncion()
    {
        print(cuentaTiempo);
        hasGanadoText.text = "hasGanado en " + cuentaTiempo + " segundos";
        hasGanado.SetActive(true);
        haTerminado = true;
    }
}
