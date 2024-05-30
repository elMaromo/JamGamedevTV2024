using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad;
    public float potenciaDeSalto;
    private Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        Vector3 moveInput = new Vector2();
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");

        Vector3.Normalize(moveInput);

        //rb.velocity = moveInput * velocidad;
        //Vector3 playerVel = rb.velocity;
        //playerVel.x += moveInput.x * velocidad * Time.deltaTime;
        //playerVel.z += moveInput.z * velocidad * Time.deltaTime;
        //rb.velocity = playerVel;
        rb.AddForce(moveInput * velocidad * Time.deltaTime);
    }
}
