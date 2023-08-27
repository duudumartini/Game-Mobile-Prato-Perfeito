using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlaJogadorMenu : MonoBehaviour
{
    private Rigidbody rb;
    private Camera mainCamera;
    public LayerMask Chao;
    RaycastHit hit;
    public Vector3 pontoDeDestino;
    public FixedJoystick joystick;
    public GameObject CanvasCozinha;
    private Vector3 direcao;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;   
    }

    private void Update()
    {

    }

}