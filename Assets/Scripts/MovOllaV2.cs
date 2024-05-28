using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class MovOllaV2 : MonoBehaviour
{
    public float velocidadOlla;
    public float tiempoCambiarDir;

    private float contadorCambioSentido;
    private int isMovHorario;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        isMovHorario = 1;
        contadorCambioSentido = tiempoCambiarDir/2;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        contadorCambioSentido -= Time.deltaTime;

        if( contadorCambioSentido < 0 )
        {
            contadorCambioSentido = tiempoCambiarDir;
            isMovHorario = -isMovHorario;
        }
        
        //transform.Rotate(Vector3.up, currSpeedOlla * Time.deltaTime);
        rb.AddRelativeTorque(Vector3.down * velocidadOlla * Time.deltaTime * isMovHorario );
    }
}
