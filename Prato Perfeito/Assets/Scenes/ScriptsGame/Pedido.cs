using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// SCRIPT ANEXADO NAS BANDEJAS DE PEDIDOS QUE SÃO INSTANCIADAS.
public class Pedido : MonoBehaviour
{
    public string Item1;
    public string Item2;
    public string Item3;
    public string Item4;
    public string Bebida;
    public float ValorVendaPedido;
    public float TempoDoPedido;
    private GameObject Jogador;
    private GameObject MaoJogador;
    private Vector3 _transformPedido;
    private bool ClicouNoPedido = false;
    public bool taNaMao = false;
    public bool PedidoNaMesa = false;
    private GameObject[] TampaMesa;
    private GameObject MesaClicada;
    private GameObject HUB;
    private GameObject ControlaCozinha;

    void Start()
    {
        Jogador = GameObject.FindGameObjectWithTag("Player");
        _transformPedido = transform.position;
        MaoJogador = GameObject.FindGameObjectWithTag("MaoJogador");
        TampaMesa = GameObject.FindGameObjectsWithTag("TampaMesa");
        HUB = GameObject.FindGameObjectWithTag("ControlaHUB");
        ControlaCozinha = GameObject.Find("CanvasCozinha");
        TempoDoPedido = UnityEngine.Random.Range(120f, 240f);
        GetComponent<AudioSource>().Play();
        
    }


    void Update()
    {
        ColetaPedido();
        PosicaoeRotacaoPedido();
        SoltaPedidoNaMesa();
    }

    private void ColetaPedido()
    {
        if(taNaMao == false && PedidoNaMesa == false)
        {
            if (Input.GetMouseButtonDown(0)) // Verifica se o botão esquerdo do mouse foi pressionado
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Cria um raio a partir da posição do clique do mouse
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == gameObject) // Verifica se o objeto clicado é o objeto desejado
                    {
                        ClicouNoPedido = true;
                    }
                }
            }
        }


        //Joga pedido no lixo.
        if (taNaMao == true && PedidoNaMesa == false)
        {
            if (Input.GetMouseButtonDown(0)) // Verifica se o botão esquerdo do mouse foi pressionado
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Cria um raio a partir da posição do clique do mouse
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Lixeira") // Verifica se o objeto clicado é o objeto desejado
                    {
                        HUB.GetComponent<ControlaHUB>().AtivaBKJogadorPedidoFora();
                        ControlaCozinha.GetComponent<ControlaCozinha>().PopUpSound();
                    }
                }
            }
        }

    }

    private void PosicaoeRotacaoPedido() 
    {
        float Distancia = Vector3.Distance(Jogador.transform.position, transform.position);
        if (ClicouNoPedido == true && Distancia <= 5f && PedidoNaMesa == false)
        {
            this.transform.position = new Vector3(MaoJogador.transform.position.x, MaoJogador.transform.position.y, MaoJogador.transform.position.z);
            Vector3 direcaoFrente = MaoJogador.transform.position + MaoJogador.transform.forward;
            transform.LookAt(direcaoFrente);
            Jogador.GetComponent<Animator>().SetLayerWeight(1, 1f);
            taNaMao = true;
        }
        else
        {
            Jogador.GetComponent<Animator>().SetLayerWeight(1, 0f);
        }
    }

    private void SoltaPedidoNaMesa()
    {
        if(taNaMao == true && PedidoNaMesa == false)
        {
            if (Input.GetMouseButtonDown(0)) // Verifica se o botão esquerdo do mouse foi pressionado
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Cria um raio a partir da posição do clique do mouse
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    GameObject _mesaClicada = hit.collider.gameObject;
                    if (System.Array.IndexOf(TampaMesa, _mesaClicada) != -1)
                    {
                        if(_mesaClicada.GetComponent<Mesa>().MesaOcupada == true && _mesaClicada.GetComponent<Mesa>().PedidoNaMesa == false) 
                        {
                            this.transform.position = new Vector3(_mesaClicada.transform.position.x, _mesaClicada.transform.position.y + 0.1f, _mesaClicada.transform.position.z);
                            this.transform.rotation = _mesaClicada.transform.rotation;
                            PedidoNaMesa = true;
                            _mesaClicada.GetComponent<Mesa>().PedidoNaMesa = true;
                            MesaClicada = _mesaClicada;
                            gameObject.tag = "PedidoEntregue";
                        }
                    }
                }
            }
        }
    }

    public void RetiraPedidoDaMesa()
    {
        Destroy(gameObject);
    }
}
