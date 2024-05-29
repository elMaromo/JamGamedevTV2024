using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Callbacks;

public class MovRotateOlla : MonoBehaviour
{
    //public float VelocidadRot=1; //velocidad asignada
    public float ejexPOS,ejexNE,ejeyPOS,ejeyNEG,ejezPOS,ejezNEG; //tope ejes
    
    private float cambio;
    private float contador;
    private bool RandRot; //boolean rand para girar
    private Vector3 randomDirection;
    private Vector3 Olla;
    private Rigidbody rb;
    
   
    // Start is called before the first frame update
    void Start()
    {
        contador=0;
        rb = GetComponent<Rigidbody>();
        Olla = new Vector3(39.22f, 73.81f, -8.4f);

        //Debug.Log("Limites MIN:MAX " +  ejexPOS+","+ejexNE+","+ejeyPOS+","+ejeyNEG+","+ejezPOS+","+ejezNEG);
        cambio= Random.Range(0,4);
        //Debug.Log("cambia cada: "+ cambio);
    }

    // Update is called once per frame
    //la mision es actualizar la rotacion de la olla en un tiempo random al pasar mas de 1seg
    void Update()
    {
       if (contador >= cambio){
        // Generar una dirección de rotación aleatoria
        //variables rotacion
        float rot1 = Random.Range(ejexNE, ejexPOS);//eje x (-18,18)
        float rot2 = Random.Range(ejeyNEG, ejeyPOS);//eje y (-64, 64)
        float rot3 = Random.Range(ejezNEG, ejezPOS);//eje z (-30, -5)
        randomDirection = new Vector3(rot1,rot2,rot3).normalized;
        
  
        Quaternion deltaRotation = Quaternion.Euler(randomDirection * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
        cambio= Random.Range(0,4);
        //Debug.Log("cambia cada: "+ cambio);
       }else{
        contador = contador + Time.deltaTime;
         //Debug.Log("sugundos: "+ contador);
        }
    }

    private void limites() //no funciona
    {
        // Limita la rotación eje X
        randomDirection.y = Mathf.Clamp(Olla.x, ejexNE,ejexPOS);
       
        // Limita la rotación eje Y
        randomDirection.y = Mathf.Clamp(Olla.y, ejeyNEG,ejeyPOS);

        // Limita la rotación eje Z
        randomDirection.y = Mathf.Clamp(Olla.z, ejezNEG,ejezPOS);

        // Aplicar la rotación limitada
        //transform.eulerAngles = Olla;
        //transform.Rotate(Olla * VelocidadRot * Time.deltaTime);
    }
}
