using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPJ : MonoBehaviour
{
    private float moviPJ;
    private float closestDistancePlayer;
    private float closestDistanceEnemy; 
    private float distPJ;
    // Start is called before the first frame update
    void Start()
    {
        moviPJ=0.7f;
    }

    // Update is called once per frame
    void Update()
    {
      //distancia jugador
      GameObject closestPlayer = FindClosestPlayer(); 
      //busca enemigos
      GameObject closestenemy=calculaDistEnemy(); 

            if (closestDistanceEnemy<closestDistancePlayer) //compara las distancias etre pj u jugador
            {
            //Debug.Log("ataca a un enemigo");
            // Mueve hacia el enemigo más cercano
            MoveTowards(closestenemy);
            }else {
                // Mueve hacia el jugador más cercano
                MoveTowards(closestPlayer);
            }  
    }
    GameObject FindClosestPlayer() //Busca al jugador
    {
        //busca jugador
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject closest = null;
        float distancePlayer;
        closestDistancePlayer = Mathf.Infinity; //distancia jugador
        Vector3 currentPosition = transform.position;
        foreach (GameObject player in players)
        {
            if (player != gameObject) // Evitar compararse con sí mismo
            {
                distancePlayer = Vector3.Distance(player.transform.position, currentPosition);
                if (distancePlayer < closestDistancePlayer)
                {
                    closestDistancePlayer = distancePlayer;
                    closest = player;
                }
            }
        }
        return closest;
    }
    
    //calcula distancia entre PJ´s
    GameObject calculaDistEnemy() //busca enemigos
    {
        //busca enemigos
        GameObject[] players = GameObject.FindGameObjectsWithTag("enemy");
        GameObject closest = null;
        float distanceEnemy;
        closestDistanceEnemy = Mathf.Infinity; //distancia jugador
        Vector3 currentPosition = transform.position;
        foreach (GameObject player in players)
        {
            if (player != gameObject) // Evitar compararse con sí mismo
            {
                distanceEnemy = Vector3.Distance(player.transform.position, currentPosition);
                if (distanceEnemy < closestDistanceEnemy)
                {
                    closestDistanceEnemy = distanceEnemy;
                    closest = player;
                }

                float distance = (transform.position - player.transform.position).sqrMagnitude;
            }
        }
        return closest;
    }

    void MoveTowards(GameObject target) //choque con jugadores
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        transform.position += direction * moviPJ * Time.deltaTime;

        //aplicamos fuerza de empuje
        //Rigidbody rb = enemy.collider.GetComponent<Rigidbody>();
        //rb.AddForce(10, ForceMode.Impulse);

    }
}
