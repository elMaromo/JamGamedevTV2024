using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Callbacks;

public class MovRotateOlla : MonoBehaviour
{
    public float VelocidadRot;
    public float ejexPOS,ejexNE,ejeyPOS,ejeyNEG,ejezPOS,ejezNEG;
    private bool RandRot;
    private Vector3 randomDirection;
    private Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //la mision es actualizar la rotacion de la olla en un tiempo random al pasar mas de 1seg
    void Update()
    {
       RandRot= Random.value < 0.5f; //
       if (RandRot==true){//se realiza el mov
        // Generar una dirección de rotación aleatoria
        //variables rotacion
        float rot1 = Random.Range(ejexNE, ejexPOS);//eje x (-18,18)
        float rot2 = Random.Range(ejeyNEG, ejeyPOS);//eje y (-64, 64)
        float rot3 = Random.Range(ejezNEG, ejezPOS);//eje z (-30, -5)
        randomDirection = new Vector3(rot1,rot2,rot3).normalized;
        // Aplicar la rotación continua en la dirección aleatoria
        //transform.Rotate(randomDirection * VelocidadRot * Time.deltaTime);
        Debug.Log("------------------------------------------------------");
        Debug.Log("ROTACION:" + rot1 + " : " + " : " + rot2 + " : " + rot3);
        Debug.Log("VELOCIDAD DE MOVIMIENTO: " + Time.deltaTime);
        
        Quaternion deltaRotation = Quaternion.Euler(randomDirection * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);


        //rb.MoveRotation(randomDirection * deltaRotation);
        //randomDirection /* * VelocidadRot * Time.deltaTime*/,;
        
        Debug.Log("------------------------------------------------------");
       }
    }
}
