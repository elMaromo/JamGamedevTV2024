using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KillZone : MonoBehaviour
{
    public GameObject hasPerdido, hasGanado;
    public TextMeshProUGUI hasGanadoText;
    public int numEnemigos;
    public List<Transform> losePositions;

    public AudioSource audioGanar;
    public AudioSource audioPerder;
    public AudioSource grito;


    private float cuentaTiempo = 0;
    private bool haTerminado = false;
    private int contadorEnemigos = 0;

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
                contadorEnemigos++;
                grito.Play();

                SendEnemyToStart( other.gameObject );

                if (contadorEnemigos == numEnemigos)
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
        audioPerder.Play();
    }

    public void GanarFuncion()
    {
        print(cuentaTiempo);
        hasGanadoText.text = cuentaTiempo.ToString("F2") + " Seconds";
        hasGanado.SetActive(true);
        haTerminado = true;
        audioGanar.Play();
    }


    public void SendEnemyToStart( GameObject currentEnemy )
    {
        currentEnemy.GetComponent<Rigidbody>().velocity = Vector3.zero;
        currentEnemy.GetComponent<Rigidbody>().isKinematic  = true;
        currentEnemy.GetComponent<CapsuleCollider>().enabled = false;
        currentEnemy.GetComponent<movimientoPJ>().enabled = false;

        currentEnemy.transform.DOMove( losePositions[contadorEnemigos-1].position, 1 );
    }
}
