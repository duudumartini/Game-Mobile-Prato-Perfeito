using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Cozinheiro : MonoBehaviour
{
    private NavMeshAgent Agent;
    private GameObject[] PontosCozinha;
    private GameObject PontoVazio;
    private int TempoDeProcura = 0;
    private int Vazio;
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        PontosCozinha = GameObject.FindGameObjectsWithTag("PontoCozinha");
    }

    // Update is called once per frame
    void Update()
    {
        Animacoes();
        Invoke("VerificaPontoVazio", TempoDeProcura);
    }

    private void VerificaPontoVazio()
    {
        Vazio = Random.Range(0, PontosCozinha.Length);
        if (PontosCozinha[Vazio].GetComponent<ItemCozinha>().PontoOcupado == false)
        {
            CancelInvoke("VerificaPontoVazio");
            TempoDeProcura = Random.Range(5, 30);
            Agent.SetDestination(PontosCozinha[Vazio].transform.position);
            PontosCozinha[Vazio].GetComponent<ItemCozinha>().PontoOcupado = true;
            AnimacaoNoPonto(Vazio);
            Invoke("AtualizaPonto", TempoDeProcura);
        }
    }

    private void AtualizaPonto()
    {
        PontosCozinha[Vazio].GetComponent<ItemCozinha>().PontoOcupado = false;
        Invoke("VerificaPontoVazio", TempoDeProcura);
    }
    
    private void Animacoes()
    {
        GetComponent<Animator>().SetFloat("Andar", Agent.velocity.magnitude);
    }

    private void AnimacaoNoPonto(int Ponto)
    {
        if (PontosCozinha[Ponto].name == "Fogao")
        {
            GetComponent<Animator>().SetInteger("Ponto", 1);
        }
        if (PontosCozinha[Ponto].name == "Caixa")
        {
            GetComponent<Animator>().SetInteger("Ponto", 2);
        }
        if (PontosCozinha[Ponto].name == "MaquinaBebida" || PontosCozinha[Ponto].name == "MaquinaSalgado")
        {
            GetComponent<Animator>().SetInteger("Ponto", 3);
        }
    }
}
