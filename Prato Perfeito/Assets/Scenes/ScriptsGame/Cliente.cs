using Sunbox.Avatars;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;


public class Cliente : MonoBehaviour
{
    private GameObject[] NumeroDeMesas;
    private GameObject Jogador;
    private GameObject[] GeradorCliente;
    private Transform TransformJogador;
    private NavMeshAgent Agent;
    public int MesaSelecionada;
    private bool AchouMesa = false;
    private bool Sentado = false;
    Vector3 PosicaoCadeira1;
    private GameObject JanelaPedido;
    private GameObject[] BandejasPedidos;
    private GameObject BandejaSelecionada;
    private GameObject ControlaHUB;
    private GameObject DadosIngredientesBebidas;
    private float DistanciaDaBandeja;
    [SerializeField]private float TempoDeConsumo;
    private int SatisfacaoClienteComPedido = 0;
    private bool VerificouItensDoPedido = false;
    private bool SairDaMesa = false;
    private bool levantar = false;
    public AudioSource SonsDePagamento;
    public AudioSource SomComendo;
    public AudioSource SomCaminhando;    
    public AudioClip PedidoErradoSound_;
    public AudioClip PedidoCorretoSound_;
    public GameObject[] Camisas;
    public GameObject[] Calca;
    public GameObject[] Tenis;
    public GameObject[] Cabelo;
    private bool Comendo = false;
    private bool AnimacaoComendo = false;
    [SerializeField]private float TempoDeEsperaDoCliente;



    // Start is called before the first frame update
    void Start()
    {
        NumeroDeMesas = GameObject.FindGameObjectsWithTag("TampaMesa");

        JanelaPedido = GameObject.FindGameObjectWithTag("JanelaPedido");

        ControlaHUB = GameObject.FindGameObjectWithTag("ControlaHUB");
        
        DadosIngredientesBebidas = GameObject.FindGameObjectWithTag("DadosIngredientesBebidas");

        Jogador = GameObject.FindGameObjectWithTag("Player");

        Agent = GetComponent<NavMeshAgent>();

        GeradorCliente = GameObject.FindGameObjectsWithTag("GeradorCliente");

        TempoDeEsperaDoCliente = UnityEngine.Random.Range(180f, 240f);
        AchaMesaVazia();
        RandomizaAparencia();
    }



    // Update is called once per frame
    void Update()
    {
        BandejasPedidos = GameObject.FindGameObjectsWithTag("PedidoEntregue");
        Animacao();
        AlteraStatusMesa();
        Sentar();
        Levantar();
        PreencheJanelaDePedido();
        ComparaPedidoRecebidoNaMesa();
        TocaSomCaminhando();
        TocaSomComendo();
    }

    void AchaMesaVazia()
    {
        for (int i = 0; i < NumeroDeMesas.Length;)
        {
            if (NumeroDeMesas[i].GetComponent<Mesa>().MesaOcupada == false)
            {
                MovimentaClienteAtéMesaVazia(i);
                MesaSelecionada = i;
                AchouMesa = true;
                return;
            }
            else
            {
                i++;
            }
        }
    }
    void MovimentaClienteAtéMesaVazia(int i)
    {   
        Agent.SetDestination(NumeroDeMesas[i].transform.position);        
    }

    void AlteraStatusMesa()
    {
        if (AchouMesa == true)
        {
            NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().MesaOcupada = true;
            float Distancia = Vector3.Distance(NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().transform.position, transform.position);
            if (Distancia >= 5.5f && SairDaMesa == true)
            {
                NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().MesaOcupada = false;
                NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().PedidoNaMesa = false;
            }
        }
    }
    void Animacao()
    {
        //Ativa animacao andando.
        GetComponent<Animator>().SetFloat("Andar", Agent.velocity.magnitude);

        //Ativa animacao sentado.
        if(Sentado == true)
        {
            GetComponent<Animator>().SetBool("Sentado", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Sentado", false);
        }
        
        if(NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().PedidoNaMesa == false && Sentado == true)
        {
            GetComponent<Animator>().SetBool("EsperandoPedido", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("EsperandoPedido", false);

        }

        //Ativa animacao comendo.
        if (NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().PedidoNaMesa == true && AnimacaoComendo == false)
        {
            int Comendo = Random.Range(1, 3);
            if( Comendo == 1)
            {
                GetComponent<Animator>().SetInteger("Comendo", Comendo);
                AnimacaoComendo = true;
            }
            if (Comendo == 2)
            {
                GetComponent<Animator>().SetInteger("Comendo", Comendo);
                AnimacaoComendo = true;
            }
        }

        //Desativa animacao comendo, para andando.
        if (SairDaMesa == true) 
        {
            GetComponent<Animator>().SetInteger("Comendo", -1);
            GetComponent<Animator>().SetBool("Levantar", true);
            GetComponent<Animator>().SetBool("Sentado", false);
        }
       


    }
    void RandomizaAparencia()
    {
        int _Camisa = Random.Range(0, Camisas.Length);
        int _Calca = Random.Range(0, Calca.Length);
        int _Tenis = Random.Range(0, Tenis.Length);
        int _Cabelo = Random.Range(0, Cabelo.Length);
        
            Camisas[_Camisa].SetActive(true);
            Calca[_Calca].SetActive(true);
            Tenis[_Tenis].SetActive(true);
            Cabelo[_Cabelo].SetActive(true);
       
    }

    void Sentar()
    {
        float Distancia = Vector3.Distance(NumeroDeMesas[MesaSelecionada].transform.position, transform.position);
        PosicaoCadeira1 = new Vector3((NumeroDeMesas[MesaSelecionada].transform.position.x -1.2f), (NumeroDeMesas[MesaSelecionada].transform.position.y), NumeroDeMesas[MesaSelecionada].transform.position.z);
        if (Distancia <=4 && SairDaMesa == false) 
        {
           transform.position = PosicaoCadeira1;
           transform.rotation = NumeroDeMesas[MesaSelecionada].transform.rotation;
           Sentado = true;
           StartCoroutine(ClienteEsperando());
        }
        else
        {
            Sentado = false;
        }
        
    }
    void Levantar()
    {
        if(levantar == true)
        {            
            SairDaMesa = true;
            Sentado = false;
            int _GeradorCLiente;
            float distancia;
            _GeradorCLiente = Random.Range(0, 1);
            distancia = Vector3.Distance(GeradorCliente[_GeradorCLiente].transform.position, transform.position);
            Agent.SetDestination(GeradorCliente[_GeradorCLiente].transform.position);
            if (distancia <= 2)
            {
                Destroy(gameObject);
            }
            if (BandejaSelecionada != null)
            {
                BandejaSelecionada.GetComponent<Pedido>().RetiraPedidoDaMesa();
            }
        }
        
    }

    void PreencheJanelaDePedido()
    {
        if (Sentado == true)
        {
            if (MesaSelecionada == 0)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Bebida.text = GetComponent<ControlaPedido>().PedidoAtualBebidas[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente1.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente2.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[1];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente3.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[2];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente4.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[3];
            }
            if (MesaSelecionada == 1)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Bebida.text = GetComponent<ControlaPedido>().PedidoAtualBebidas[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente1.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente2.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[1];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente3.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[2];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente4.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[3];
            }
            if (MesaSelecionada == 2)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Bebida.text = GetComponent<ControlaPedido>().PedidoAtualBebidas[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente1.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente2.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[1];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente3.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[2];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente4.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[3];
            }
            if (MesaSelecionada == 3)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Bebida.text = GetComponent<ControlaPedido>().PedidoAtualBebidas[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente1.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente2.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[1];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente3.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[2];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente4.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[3];
            }
            if (MesaSelecionada == 4)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Bebida.text = GetComponent<ControlaPedido>().PedidoAtualBebidas[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente1.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente2.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[1];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente3.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[2];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente4.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[3];
            }
            if (MesaSelecionada == 5)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Bebida.text = GetComponent<ControlaPedido>().PedidoAtualBebidas[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente1.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente2.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[1];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente3.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[2];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente4.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[3];
            }
            if (MesaSelecionada == 6)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Bebida.text = GetComponent<ControlaPedido>().PedidoAtualBebidas[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente1.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[0];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente2.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[1];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente3.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[2];
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente4.text = GetComponent<ControlaPedido>().PedidoAtualIngrediente[3];
            }
        }
        else
        {
            if (MesaSelecionada == 0)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Bebida.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente1.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente2.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente3.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa1Ingrediente4.text = string.Empty;
            }
            if (MesaSelecionada == 1)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Bebida.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente1.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente2.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente3.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa2Ingrediente4.text = string.Empty;
            }
            if (MesaSelecionada == 2)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Bebida.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente1.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente2.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente3.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa3Ingrediente4.text = string.Empty;
            }
            if (MesaSelecionada == 3)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Bebida.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente1.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente2.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente3.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa4Ingrediente4.text = string.Empty;
            }
            if (MesaSelecionada == 4)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Bebida.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente1.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente2.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente3.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa5Ingrediente4.text = string.Empty;
            }
            if (MesaSelecionada == 5)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Bebida.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente1.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente2.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente3.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa6Ingrediente4.text = string.Empty;
            }
            if (MesaSelecionada == 6)
            {
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Bebida.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente1.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente2.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente3.text = string.Empty;
                JanelaPedido.GetComponent<ControlaJanelaDePedido>().Mesa7Ingrediente4.text = string.Empty;
            }
        }
    }

    void ComparaPedidoRecebidoNaMesa()
    {
        //Encontra qual bandeja está posicionada na mesa.
        for (int i = 0; i < BandejasPedidos.Length; i++) 
        { 
            DistanciaDaBandeja = Vector3.Distance(transform.position, BandejasPedidos[i].transform.position);
            if(DistanciaDaBandeja <= 1.5f && VerificouItensDoPedido == false)
            {
                BandejaSelecionada = BandejasPedidos[i];
                //Verifica se os itens e adiciona a 1 de pontuacao a cada pedido correto;
                if (BandejaSelecionada.GetComponent<Pedido>().Item1 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[0]
                    || BandejaSelecionada.GetComponent<Pedido>().Item1 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[1]
                    || BandejaSelecionada.GetComponent<Pedido>().Item1 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[2]
                    || BandejaSelecionada.GetComponent<Pedido>().Item1 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[3])
                {
                    SatisfacaoClienteComPedido++;
                }
                if (BandejaSelecionada.GetComponent<Pedido>().Item2 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[0]
                    || BandejaSelecionada.GetComponent<Pedido>().Item2 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[1]
                    || BandejaSelecionada.GetComponent<Pedido>().Item2 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[2]
                    || BandejaSelecionada.GetComponent<Pedido>().Item2 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[3])
                {
                    SatisfacaoClienteComPedido++;
                }
                if (BandejaSelecionada.GetComponent<Pedido>().Item3 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[0]
                    || BandejaSelecionada.GetComponent<Pedido>().Item3 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[1]
                    || BandejaSelecionada.GetComponent<Pedido>().Item3 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[2]
                    || BandejaSelecionada.GetComponent<Pedido>().Item3 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[3])
                {
                    SatisfacaoClienteComPedido++;
                }
                if (BandejaSelecionada.GetComponent<Pedido>().Item4 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[0]
                    || BandejaSelecionada.GetComponent<Pedido>().Item4 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[1]
                    || BandejaSelecionada.GetComponent<Pedido>().Item4 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[2]
                    || BandejaSelecionada.GetComponent<Pedido>().Item4 == GetComponent<ControlaPedido>().PedidoAtualIngrediente[3])
                {
                    SatisfacaoClienteComPedido++;
                }

                if (BandejaSelecionada.GetComponent<Pedido>().Bebida == GetComponent<ControlaPedido>().PedidoAtualBebidas[0])
                {
                    SatisfacaoClienteComPedido++;
                }
                VerificouItensDoPedido = true;
                TempoDeConsumo = BandejaSelecionada.GetComponent<Pedido>().TempoDoPedido;
                RealizaPagamentoDoPedido();
                
            }
        }
    }

    void RealizaPagamentoDoPedido()
    {
        if (SatisfacaoClienteComPedido == 5)
        {
            PedidoCorretoSound();
            ControlaHUB.GetComponent<ControlaHUB>().Gemas = ControlaHUB.GetComponent<ControlaHUB>().Gemas + (BandejaSelecionada.GetComponent<Pedido>().ValorVendaPedido * ControlaHUB.GetComponent<ControlaHUB>().ValorBonus);
            ControlaHUB.GetComponent<ControlaHUB>().ValorNovoPositivo(BandejaSelecionada.GetComponent<Pedido>().ValorVendaPedido);
            ControlaHUB.GetComponent<ControlaHUB>().AumentaEstrelas(0.2f);
            StartCoroutine(ClienteConsumindo());
        }
        else if (SatisfacaoClienteComPedido == 4)
        {
            PedidoCorretoSound();
            ControlaHUB.GetComponent<ControlaHUB>().Gemas = ControlaHUB.GetComponent<ControlaHUB>().Gemas + (((BandejaSelecionada.GetComponent<Pedido>().ValorVendaPedido * 0.6f) * ControlaHUB.GetComponent<ControlaHUB>().ValorBonus));
            ControlaHUB.GetComponent<ControlaHUB>().ValorNovoPositivo(BandejaSelecionada.GetComponent<Pedido>().ValorVendaPedido * 0.6f);
            StartCoroutine(ClienteConsumindo());
        }
        else if(SatisfacaoClienteComPedido <= 3)
        {
            ControlaHUB.GetComponent<ControlaHUB>().ReduzEstrelas(1);
            PedidoErradoSound();
            levantar = true;
            
        }
    }

    private IEnumerator ClienteConsumindo()
    {
            yield return new WaitForSeconds(TempoDeConsumo);
            levantar = true;               
    }

    private IEnumerator ClienteEsperando()
    {
        yield return new WaitForSeconds(TempoDeEsperaDoCliente);

        //se o pedido não estiver na mesa o cliente levanta.
        if (NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().PedidoNaMesa == false && levantar == false) 
        {
            levantar = true;
            ControlaHUB.GetComponent<ControlaHUB>().ReduzEstrelas(1);
        }
    }

    public void PedidoErradoSound()
    {
        SonsDePagamento.clip = PedidoErradoSound_;
        SonsDePagamento.Play();
    }

    public void PedidoCorretoSound()
    {
        SonsDePagamento.clip = PedidoCorretoSound_;
        SonsDePagamento.Play();
    }

    private void TocaSomCaminhando()
    {
        if (Agent.velocity.magnitude > 1)
        {
            SomCaminhando.Play();
        }
        else
        {
            SomCaminhando.Pause();
        }
    }
    private void TocaSomComendo()
    {
        
        if(NumeroDeMesas[MesaSelecionada].GetComponent<Mesa>().PedidoNaMesa == true)
        {
            if(Comendo == false)
            {
                SomComendo.Play();
                Comendo = !Comendo;
            }            
        }
        else 
        {
            SomComendo.Pause();
        }
    }

}
