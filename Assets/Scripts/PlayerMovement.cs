using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad;
    public float potenciaDeSalto;
    
    private Vector3 moveInput;
    private Rigidbody rb;

    public void Start()
    {
        moveInput = new Vector3();
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        Vector3 moveInput = new Vector2();
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");

        Vector3.Normalize(moveInput);

        rb.velocity = moveInput * velocidad;
        
        //rb.AddForce(moveInput * Time.deltaTime);
    }
}
