using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPJ : MonoBehaviour
{
    public float moviPJ;
    

    private GameObject player;
    private GameObject[] enemys;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        enemys = GameObject.FindGameObjectsWithTag("enemy");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //distancia jugador
        float closestDistancePlayer = distanceToPlayer();
       
        //busca enemigos
        GameObject closestEnemy = distanceToEnemys();
        float closestDistanceEnemy = Vector3.Distance(closestEnemy.transform.position, transform.position);

        if (closestDistanceEnemy < closestDistancePlayer) //compara las distancias etre pj u jugador
        {
            MoveTowards(closestEnemy);
        }
        else
        {
            MoveTowards(player);
        }
    }


    float distanceToPlayer() //Busca al jugador
    {
        return Vector3.Distance(player.transform.position, transform.position);;
    }

    //calcula distancia entre PJ´s
    GameObject distanceToEnemys() //busca enemigos
    {
        //busca enemigos
        GameObject closest = null;
        float distanceEnemy;
        float closestDistanceEnemy = Mathf.Infinity; //distancia jugador

        foreach ( GameObject enemy in enemys)
        {
            if (enemy != gameObject) // Evitar compararse con sí mismo
            {
                distanceEnemy = Vector3.Distance(enemy.transform.position, transform.position);
                if (distanceEnemy < closestDistanceEnemy)
                {
                    closestDistanceEnemy = distanceEnemy;
                    closest = enemy;
                }
            }
        }
        return closest;
    }

    void MoveTowards(GameObject target) //choque con jugadores
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        rb.AddForce(direction * moviPJ * Time.deltaTime );
    }
}
