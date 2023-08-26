using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class ControlaCozinha : MonoBehaviour
{
    public AudioClip ErrorS;
    public AudioClip PopUpS;
    public AudioSource AudioSource;
    public GameObject Jogador;
    public GameObject CanvasCozinha;
    public GameObject DadosIngredientesBebidas;
    public GameObject[] BandejaPedido;
    public GameObject PontoCriacaoPedido;
    public GameObject JaExisteUmPedido;
    public GameObject SistemaDeGasCozinha;
    public GameObject SistemaDeGasHUB;
    public GameObject ControlaHUB;
    public Button _ConfirmarPedido;
    public TextMeshProUGUI textoSlot1;
    public TextMeshProUGUI textoSlot2;
    public TextMeshProUGUI textoSlot3;
    public TextMeshProUGUI textoSlot4;
    public TextMeshProUGUI textoSlotBebida;
    public TextMeshProUGUI textovalorVendaPedido;
    public TextMeshProUGUI textoCustoTotal;
    public GameObject LiberaPedido;
    public GameObject PedidoSendoFabricado;
    public GameObject NaoPossuiBurgerCoinSuficiente;
    public GameObject NaoPossuiBurgerCoinSuficienteGAS;
    public TextMeshProUGUI TempoFinalPedido;
    public Slider SliderGas;
    public TextMeshProUGUI ValorGas;
    public TextMeshProUGUI PorcentGas;
    public Button RecarregarGas;
    public float ResumoTempo;
    public float PreçoAntecipaPedido;
    public float TempoPedidoPronto;
    private bool LiberaBandejaPedido = false;
    private float PrecoDoGas = 250;
    [NonSerialized] public string item1Pedido;
    [NonSerialized] public string item2Pedido;
    [NonSerialized] public string item3Pedido;
    [NonSerialized] public string item4Pedido;
    [NonSerialized] public string BebidaPedido;
    [NonSerialized] public float valorVendaPedido;
    [NonSerialized] public float CustoTotalDoPedido;
    [NonSerialized] public float _PorcentGas = 100;
    [NonSerialized] public float ValorRecargaGas = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtivaBotaoConfirmarPedido();
        PedidoLiberado();
        CustoTotalDoPedido = float.Parse(textoCustoTotal.text);
        ControlaGas();
    }
    
    public void AbreFechaCozinha()
    {
            CanvasCozinha.SetActive(!CanvasCozinha.activeSelf);
            GetComponent<ResetaCozinha>().ResetaIngredientes();
            GetComponent<ResetaCozinha>().ResetaTextos();
            GetComponent<ResetaCozinha>().ResetaSlotsVazio();
    }

    private void AtivaBotaoConfirmarPedido()
    {
        if (CanvasCozinha.activeSelf == true)
        {
            if (!string.IsNullOrEmpty(textoSlot1.text) && !string.IsNullOrEmpty(textoSlot2.text) && !string.IsNullOrEmpty(textoSlot3.text) && !string.IsNullOrEmpty(textoSlot4.text) && !string.IsNullOrEmpty(textoSlotBebida.text))
            {
                _ConfirmarPedido.interactable = true;
            }
            else
            {
                _ConfirmarPedido.interactable = false;
            }
        }
    }

    public void IniciaPedido()
    {
        GameObject _BandejaPedido = GameObject.FindGameObjectWithTag("PedidoNaoEntregue");
        if (_BandejaPedido == null && LiberaPedido.activeSelf == false && CustoTotalDoPedido <= ControlaHUB.GetComponent<ControlaHUB>().Gemas && SliderGas.value > 0)
        {
            LiberaPedido.SetActive(true);
            ResumoTempo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().ResumoTempo;
            item1Pedido = textoSlot1.text;
            item2Pedido = textoSlot2.text;
            item3Pedido = textoSlot3.text;
            item4Pedido = textoSlot4.text;
            BebidaPedido = textoSlotBebida.text;
            ControlaHUB.GetComponent<ControlaHUB>().Gemas = ControlaHUB.GetComponent<ControlaHUB>().Gemas - CustoTotalDoPedido;
            ControlaHUB.GetComponent<ControlaHUB>().ValorNovoNegativo(CustoTotalDoPedido);
            valorVendaPedido = float.Parse(textovalorVendaPedido.text);
            GetComponent<ResetaCozinha>().ResetaIngredientes();
            GetComponent<ResetaCozinha>().ResetaSlotsVazio();
            GetComponent<ResetaCozinha>().ResetaTextos();
            LiberaBandejaPedido = true;
            PreçoAntecipaPedido = valorVendaPedido / 7;


            //Adiciona os itens no pedido em producao do HUB.
            ControlaHUB.GetComponent<ControlaHUB>().Item1Pedido.text = item1Pedido.ToString();
            ControlaHUB.GetComponent<ControlaHUB>().Item2Pedido.text = item2Pedido.ToString();
            ControlaHUB.GetComponent<ControlaHUB>().Item3Pedido.text = item3Pedido.ToString();
            ControlaHUB.GetComponent<ControlaHUB>().Item4Pedido.text = item4Pedido.ToString();
            ControlaHUB.GetComponent<ControlaHUB>().BebidaPedido.text = BebidaPedido.ToString();
        }
        else if (CustoTotalDoPedido > ControlaHUB.GetComponent<ControlaHUB>().Gemas)
        {
            NaoPossuiBurgerCoinSuficiente.SetActive(true);
            ErrorSound();
        }

        else if (LiberaPedido.activeSelf == true)
        {
            PedidoSendoFabricado.SetActive(true);
            ErrorSound();
        }

        else if (_BandejaPedido != null)
        {
            JaExisteUmPedido.SetActive(true);
            ErrorSound();
        }
        else if(SliderGas.value <= 0)
        {
            SistemaDeGasCozinha.SetActive(true);
            ErrorSound();
        }
       
    }

    public void PedidoLiberado()
    {
        
        if (ResumoTempo >= 0)
        { 
            ResumoTempo -= Time.deltaTime;
            TempoPedidoPronto = Mathf.Floor(ResumoTempo);
            TempoFinalPedido.text = TempoPedidoPronto.ToString() + " s";
        }
        else
        {
            LiberaPedido.SetActive(false);
        }

        if (ResumoTempo <= 0 && LiberaBandejaPedido == true && SliderGas.value > 0)
        {
            int BandejaAleatoria = UnityEngine.Random.Range(0, BandejaPedido.Length);
            Instantiate(BandejaPedido[BandejaAleatoria], PontoCriacaoPedido.transform.position, PontoCriacaoPedido.transform.rotation);
            GameObject _BandejaPedido = GameObject.FindGameObjectWithTag("PedidoNaoEntregue");
            _BandejaPedido.GetComponent<Pedido>().Item1 = item1Pedido;
            _BandejaPedido.GetComponent<Pedido>().Item2 = item2Pedido;
            _BandejaPedido.GetComponent<Pedido>().Item3 = item3Pedido;
            _BandejaPedido.GetComponent<Pedido>().Item4 = item4Pedido;
            _BandejaPedido.GetComponent<Pedido>().Bebida = BebidaPedido;
            _BandejaPedido.GetComponent<Pedido>().ValorVendaPedido = valorVendaPedido;
            LiberaBandejaPedido = false;
        }

        if(SliderGas.value <= 0)
        {
            LiberaPedido.SetActive(false);
        }
    }

    void ControlaGas()
    {
        //Consome Gás quando o pedido está ativo / sendo produzido.
        ValorGas.text = ValorRecargaGas.ToString();
        SliderGas.value = _PorcentGas;
        PorcentGas.text = SliderGas.value.ToString() + "%";
        if (LiberaPedido.activeSelf == true)
        {
            _PorcentGas -= (Time.deltaTime / 2);
        }
        if(SliderGas.value >= 100)
        {
            RecarregarGas.interactable = false;
        }
        else
        {
            RecarregarGas.interactable = true;
        }

        if (SliderGas.value <= 0)
        {
            SistemaDeGasCozinha.SetActive(true);
        }
        else
        {
            SistemaDeGasCozinha.SetActive(false);
            SistemaDeGasHUB.SetActive(false);
        }

        if (SliderGas.value <= 0 && CanvasCozinha.activeSelf == false)
        {
            SistemaDeGasHUB.SetActive(true);
        }
        else
        {
            SistemaDeGasHUB.SetActive(false);
        }

        //Altera valor do gas de acordo com a quantidade de gás existente.
       ValorRecargaGas = (PrecoDoGas/100) * (100 - SliderGas.value);
        
    }
    public void RecarregaGas()
    {
        if(ValorRecargaGas <= ControlaHUB.GetComponent<ControlaHUB>().Gemas)
        {
            _PorcentGas = 100;
            ControlaHUB.GetComponent<ControlaHUB>().Gemas -= ValorRecargaGas;
            ControlaHUB.GetComponent<ControlaHUB>().ValorNovoNegativo(ValorRecargaGas);
        }
        else
        { 
           NaoPossuiBurgerCoinSuficienteGAS.SetActive(true);
           ErrorSound();
        }
    }

    public void ErrorSound()
    {
        AudioSource.clip = ErrorS;
        AudioSource.Play();
    }

    public void PopUpSound()
    {
        AudioSource.clip = PopUpS;
        AudioSource.Play();
    }

    public void AnteciparPedido()
    {
        float NovoPreçoAntecipado;
        NovoPreçoAntecipado = Mathf.Floor(PreçoAntecipaPedido);
        if (PreçoAntecipaPedido <= ControlaHUB.GetComponent<ControlaHUB>().Gemas)
        {
            ResumoTempo = 0;
            ControlaHUB.GetComponent<ControlaHUB>().Gemas -= PreçoAntecipaPedido;
            ControlaHUB.GetComponent<ControlaHUB>().ValorNovoNegativo(NovoPreçoAntecipado);
        }
        
    }
}
