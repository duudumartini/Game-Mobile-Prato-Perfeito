using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlaJogador : MonoBehaviour
{
    private Rigidbody rb;
    private Camera mainCamera;
    public LayerMask Chao;
    RaycastHit hit;
    public Vector3 pontoDeDestino;
    public FixedJoystick joystick;
    public GameObject CanvasCozinha;
    private Vector3 direcao;
    private int VelocidadeMovimento = 5;
    private int VelocidadeRotacao = 10;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;   
    }

    private void Update()
    {
        AtivaAnimacao();
    }

    private void FixedUpdate()
    {
        float HorizontalInput = joystick.Vertical *-1;
        float VerticalInput = joystick.Horizontal;
        Vector3 moveDirection = new Vector3(HorizontalInput, 0.0f, VerticalInput);

        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, VelocidadeRotacao * Time.deltaTime);

            moveDirection.Normalize();
        }

        rb.velocity = moveDirection * VelocidadeMovimento;
    }

    private void AtivaAnimacao()
    {
        GetComponent<Animator>().SetFloat("Andar", rb.velocity.magnitude);
        Debug.Log(rb.velocity.magnitude);
    }

}