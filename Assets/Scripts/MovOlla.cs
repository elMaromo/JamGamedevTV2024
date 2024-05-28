using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MovOlla : MonoBehaviour
{
    
    // Start is called before the first frame update
    int Giro=0; //Giro derecha o izquierda
    float ContadorCambio=6.0f; //Cambia de estado
    public float VelocidadGiro= 0.0f; 
    public float VelocidadMovimiento= 0.0f;
    private Vector3 startPosition; // Posición inicial
    void Start()   
    {
        float ContadorSeg=3.0f;
        float currentTime = ContadorSeg; 
        while (currentTime >0) 
        {
            Debug.Log("Tiempo restante: " + Mathf.Ceil(currentTime).ToString() + "s");
            currentTime -= Time.deltaTime;
        }
      VelocidadGiro= 100.0f;
      VelocidadMovimiento=1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = ContadorCambio; 
        while (currentTime >0){
            Giro = Cambio(0,Giro);
        } Giro= Cambio(1, Giro);
        
    }

    int Cambio (int NG,int Giro){

        if(NG==1){
        Giro= Random.Range(0,9);        
            if (Giro > 4) //sentido horario
            {   
                transform.Rotate(Vector3.up, VelocidadGiro * Time.deltaTime);
            ContadorCambio=6.0f;
            }else //sentido antihorario
            {
                transform.Rotate(Vector3.up, -( VelocidadGiro * Time.deltaTime));
            ContadorCambio=6.0f;
            };
            return Giro;
        }else{
            transform.Rotate(Vector3.up, VelocidadGiro * Time.deltaTime);
            return Giro;
        }
    }
   /* void Movimiento()
    {
        float RangoMax = 5.0f; // Rango de movimiento maximo


    }*/
}
