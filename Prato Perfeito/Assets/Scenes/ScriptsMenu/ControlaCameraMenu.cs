using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ControlaCameraMenu : MonoBehaviour
{
    private GameObject Jogador;
    public GameObject EditaPersonagem_;
    public GameObject PosicaoCameraEditaPersonagem;
    public GameObject HUB;
    Vector3 distanciaCompensar;
    private bool AlternaCamera = false;
    Vector3 posicaoCameraOriginal;
    Quaternion RotacaoOriginal;
    private bool Iniciou = true;

    public float Sensibilidade = 100f;
    private float XRotation = 0f;

    private void Awake()
    {
        Jogador = GameObject.FindGameObjectWithTag("Player");
    }
    void Start()
    {
        distanciaCompensar = transform.position - Jogador.transform.position;
        posicaoCameraOriginal = transform.position;
        RotacaoOriginal = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Jogador = GameObject.FindGameObjectWithTag("Player");
        ThirdPerson();
    }

    private void ThirdPerson()
    {
        transform.rotation = RotacaoOriginal;
        transform.position = Jogador.transform.position + distanciaCompensar;
    }
}
