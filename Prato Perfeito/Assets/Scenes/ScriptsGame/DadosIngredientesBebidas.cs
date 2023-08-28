using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DadosIngredientesBebidas : MonoBehaviour
{
    
    public string[] Ingredientes = new string[] {
        "Queijo",
        "Cebola",
        "Tomate",
        "Alface",
        "Pimenta",
        "Pao",
        "Cenoura",
        "Frango",
        "Ovo",
        "Peixe Pequeno",
        "Milho",
        "Atum",
    };
    public string[] Bebidas = new string[] {
        "Agua",
        "Suco de Morango",
        "Suco de Limao",
    };
    [NonSerialized] public float tempoQueijo = 3.6f;
    [NonSerialized] public float tempoAlho = 3.1f;
    [NonSerialized] public float tempoCebola = 3.4f;
    [NonSerialized] public float tempoTomate = 3.2f;
    [NonSerialized] public float tempoAlface = 3.9f;
    [NonSerialized] public float tempoPimenta = 3.0f;
    [NonSerialized] public float tempoPao = 4.8f;
    [NonSerialized] public float tempoCenoura = 3.5f;
    [NonSerialized] public float tempoFrango = 6.9f;
    [NonSerialized] public float tempoOvo = 4.4f;
    [NonSerialized] public float tempoPeixePequeno = 7.1f;
    [NonSerialized] public float tempoMilho = 5.1f;
    [NonSerialized] public float tempoAtum = 8.5f;
    [NonSerialized] public float tempoAbobora = 4.3f;
    [NonSerialized] public float tempoLimao = 3.3f;
    [NonSerialized] public float tempoBacon = 5.8f;
    [NonSerialized] public float tempoManteiga = 3.3f;
    [NonSerialized] public float tempoCarneBovina = 7.8f;
    [NonSerialized] public float tempoCarneSuina = 8.2f;
    [NonSerialized] public float tempoMel = 5.7f;
    [NonSerialized] public float tempoMacarrao = 5.3f;
    [NonSerialized] public float tempoErvilha = 3.6f;
    [NonSerialized] public float tempoCogumelo = 4.6f;
    [NonSerialized] public float tempoBeringela = 3.9f;
    [NonSerialized] public float tempoCarneDeOvelha = 9.3f;
    [NonSerialized] public float tempoMolhoBranco = 4.8f;
    [NonSerialized] public float tempoLula = 11.5f;
    [NonSerialized] public float tempoChocolate = 5.8f;
    [NonSerialized] public float tempoMolho = 5.8f;
    [NonSerialized] public float tempoPolvo = 10.7f;
    [NonSerialized] public float tempoPeixeGrande = 11.3f;
    [NonSerialized] public float tempoCamarao = 10.3f;
    [NonSerialized] public float tempoOstraBranca = 9.3f;
    [NonSerialized] public float tempoOstraPreta = 9.4f;
    [NonSerialized] public float tempoLagosta = 13.6f;
    [NonSerialized] public float tempoCarangueijo = 14.1f;


    [NonSerialized] public float custoQueijo = 8.4f;
    [NonSerialized] public float custoAlho = 9.3f;
    [NonSerialized] public float custoCebola = 8.4f;
    [NonSerialized] public float custoTomate = 8.7f;
    [NonSerialized] public float custoAlface = 9.3f;
    [NonSerialized] public float custoPimenta = 7.2f;
    [NonSerialized] public float custoPao = 5.6f;
    [NonSerialized] public float custoCenoura = 7.5f;
    [NonSerialized] public float custoFrango = 14.2f;
    [NonSerialized] public float custoOvo = 9.5f;
    [NonSerialized] public float custoPeixePequeno = 16.7f;
    [NonSerialized] public float custoMilho = 10.7f;
    [NonSerialized] public float custoAtum = 28.6f;
    [NonSerialized] public float custoAbobora = 12.4f;
    [NonSerialized] public float custoLimao = 7.7f;
    [NonSerialized] public float custoBacon = 15.8f;
    [NonSerialized] public float custoManteiga = 7.8f;
    [NonSerialized] public float custoCarneBovina = 23.9f;
    [NonSerialized] public float custoCarneSuina = 25.4f;
    [NonSerialized] public float custoMel = 13.2f;
    [NonSerialized] public float custoMacarrao = 11.6f;
    [NonSerialized] public float custoErvilha = 7.2f;
    [NonSerialized] public float custoCogumelo = 13.8f;
    [NonSerialized] public float custoBeringela = 9.1f;
    [NonSerialized] public float custoCarneDeOvelha = 32.3f;
    [NonSerialized] public float custoMolhoBranco = 16.3f;
    [NonSerialized] public float custoLula = 38.6f;
    [NonSerialized] public float custoChocolate = 14.8f;
    [NonSerialized] public float custoMolho = 15.4f;
    [NonSerialized] public float custoPolvo = 31.7f;
    [NonSerialized] public float custoPeixeGrande = 35.6f;
    [NonSerialized] public float custoCamarao = 28.3f;
    [NonSerialized] public float custoOstraBranca = 26.7f;
    [NonSerialized] public float custoOstraPreta = 26.7f;
    [NonSerialized] public float custoLagosta = 43.4f;
    [NonSerialized] public float custoCarangueijo = 45.6f;

    [NonSerialized] public float tempoAgua = 1.7f;
    [NonSerialized] public float tempoSucoDeMorango = 2.3f;
    [NonSerialized] public float tempoSucoDeLimao = 2.6f;
    [NonSerialized] public float tempoSucoDeLaranja = 2.4f;
    [NonSerialized] public float tempoChaGelado = 3.7f;
    [NonSerialized] public float tempoSucoDeCereja = 2.8f;
    [NonSerialized] public float tempoCafe = 3.1f;
    [NonSerialized] public float tempoLimonadaSuica = 3.9f;
    [NonSerialized] public float tempoLeite = 2.2f;
    [NonSerialized] public float tempoCappuccino = 4.5f;
    [NonSerialized] public float tempoDrinkDeMorango = 3.9f;
    [NonSerialized] public float tempoCerveja = 3.2f;
    [NonSerialized] public float tempoChaQuente = 4.1f;
    [NonSerialized] public float tempoDrinkSuico = 4.1f;
    [NonSerialized] public float tempoDrinkColorido = 4.8f;
    [NonSerialized] public float tempoChaDeMel = 4.3f;
    [NonSerialized] public float tempoVinho = 4.2f;
    [NonSerialized] public float tempoDrinkLuxo = 5.5f;

    [NonSerialized] public float custoAgua = 3.5f;
    [NonSerialized] public float custoSucoDeMorango = 6.5f;
    [NonSerialized] public float custoSucoDeLimao = 6.4f;
    [NonSerialized] public float custoSucoDeLaranja = 6.7f;
    [NonSerialized] public float custoChaGelado = 7.1f;
    [NonSerialized] public float custoSucoDeCereja = 7.5f;
    [NonSerialized] public float custoCafe = 4.1f;
    [NonSerialized] public float custoLimonadaSuica = 7.9f;
    [NonSerialized] public float custoLeite = 3.9f;
    [NonSerialized] public float custoCappuccino = 5.7f;
    [NonSerialized] public float custoDrinkDeMorango = 8.9f;
    [NonSerialized] public float custoCerveja = 8.4f;
    [NonSerialized] public float custoChaQuente = 9.4f;
    [NonSerialized] public float custoDrinkSuico = 9.8f;
    [NonSerialized] public float custoDrinkColorido = 10.3f;
    [NonSerialized] public float custoChaDeMel = 8.3f;
    [NonSerialized] public float custoVinho = 14.9f;
    [NonSerialized] public float custoDrinkLuxo = 15.5f;

    [NonSerialized] public float ResumoCusto;
    [NonSerialized] public float ResumoTempo;
    [NonSerialized] public float Valorvenda;

    public TextMeshProUGUI TxSlot1;
    public TextMeshProUGUI TxSlot2;
    public TextMeshProUGUI TxSlot3;
    public TextMeshProUGUI TxSlot4;
    public TextMeshProUGUI TxSlotBebida;


    public TextMeshProUGUI ResumoDoCusto;
    public TextMeshProUGUI ResumoDoTempo;
    public TextMeshProUGUI ValorDaVenda;

    public float Lucro = 0.4f;
    public float _ValorDavenda;

    private float ValorItem1;
    private float ValorItem2;
    private float ValorItem3;
    private float ValorItem4;
    private float ValorItem5;
    private float TempoItem1;
    private float TempoItem2;
    private float TempoItem3;
    private float TempoItem4;
    private float TempoItem5;

    public GameObject[] ItemBloqueado;

    public GameObject ControlaHUB;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AtualizaResumo();
        Calcula();
        ControlaVersaoWeb();
    }

    public void AtualizaResumo()
    {
        if (TxSlot1.text == "Queijo")
        {
            ValorItem1 = custoQueijo;
            TempoItem1 = tempoQueijo;
        }
        else if (TxSlot1.text == "Alho")
        {
            ValorItem1 = custoAlho;
            TempoItem1 = tempoAlho;
        }
        else if (TxSlot1.text == "Cebola")
        {
            ValorItem1 = custoCebola;
            TempoItem1 = tempoCebola;
        }
        else if (TxSlot1.text == "Tomate")
        {
            ValorItem1 = custoTomate;
            TempoItem1 = tempoTomate;
        }
        else if (TxSlot1.text == "Alface")
        {
            ValorItem1 = custoAlface;
            TempoItem1 = tempoAlface;
        }
        else if (TxSlot1.text == "Pimenta")
        {
            ValorItem1 = custoPimenta;
            TempoItem1 = tempoPimenta;
        }
        else if (TxSlot1.text == "Pao")
        {
            ValorItem1 = custoPao;
            TempoItem1 = tempoPao;
        }
        else if (TxSlot1.text == "Cenoura")
        {
            ValorItem1 = custoCenoura;
            TempoItem1 = tempoCenoura;
        }
        else if (TxSlot1.text == "Frango")
        {
            ValorItem1 = custoFrango;
            TempoItem1 = tempoFrango;
        }
        else if (TxSlot1.text == "Ovo")
        {
            ValorItem1 = custoOvo;
            TempoItem1 = tempoOvo;
        }
        else if (TxSlot1.text == "Peixe Pequeno")
        {
            ValorItem1 = custoPeixePequeno;
            TempoItem1 = tempoPeixePequeno;
        }
        else if (TxSlot1.text == "Milho")
        {
            ValorItem1 = custoMilho;
            TempoItem1 = tempoMilho;
        }
        else if (TxSlot1.text == "Atum")
        {
            ValorItem1 = custoAtum;
            TempoItem1 = tempoAtum;
        }
        else if (TxSlot1.text == "Abobora")
        {
            ValorItem1 = custoAbobora;
            TempoItem1 = tempoAbobora;
        }
        else if (TxSlot1.text == "Limao")
        {
            ValorItem1 = custoLimao;
            TempoItem1 = tempoLimao;
        }
        else if (TxSlot1.text == "Bacon")
        {
            ValorItem1 = custoBacon;
            TempoItem1 = tempoBacon;
        }
        else if (TxSlot1.text == "Manteiga")
        {
            ValorItem1 = custoManteiga;
            TempoItem1 = tempoManteiga;
        }
        else if (TxSlot1.text == "Carne Bovina")
        {
            ValorItem1 = custoCarneBovina;
            TempoItem1 = tempoCarneBovina;
        }
        else if (TxSlot1.text == "Carne Suina")
        {
            ValorItem1 = custoCarneSuina;
            TempoItem1 = tempoCarneSuina;
        }
        else if (TxSlot1.text == "Mel")
        {
            ValorItem1 = custoMel;
            TempoItem1 = tempoMel;
        }
        else if (TxSlot1.text == "Macarrao")
        {
            ValorItem1 = custoMacarrao;
            TempoItem1 = tempoMacarrao;
        }
        else if (TxSlot1.text == "Ervilha")
        {
            ValorItem1 = custoErvilha;
            TempoItem1 = tempoErvilha;
        }
        else if (TxSlot1.text == "Cogumelo")
        {
            ValorItem1 = custoCogumelo;
            TempoItem1 = tempoCogumelo;
        }
        else if (TxSlot1.text == "Beringela")
        {
            ValorItem1 = custoBeringela;
            TempoItem1 = tempoBeringela;
        }
        else if (TxSlot1.text == "Carne Ovelha")
        {
            ValorItem1 = custoCarneDeOvelha;
            TempoItem1 = tempoCarneDeOvelha;
        }
        else if (TxSlot1.text == "Molho Branco")
        {
            ValorItem1 = custoMolhoBranco;
            TempoItem1 = tempoMolhoBranco;
        }
        else if (TxSlot1.text == "Lula")
        {
            ValorItem1 = custoLula;
            TempoItem1 = tempoLula;
        }
        else if (TxSlot1.text == "Chocolate")
        {
            ValorItem1 = custoChocolate;
            TempoItem1 = tempoChocolate;
        }
        else if (TxSlot1.text == "Molho")
        {
            ValorItem1 = custoMolho;
            TempoItem1 = tempoMolho;
        }
        else if (TxSlot1.text == "Polvo")
        {
            ValorItem1 = custoPolvo;
            TempoItem1 = tempoPolvo;
        }
        else if (TxSlot1.text == "Camarao")
        {
            ValorItem1 = custoCamarao;
            TempoItem1 = tempoCamarao;
        }
        else if (TxSlot1.text == "Peixe Grande")
        {
            ValorItem1 = custoPeixeGrande;
            TempoItem1 = tempoPeixeGrande;
        }
        else if (TxSlot1.text == "Ostra Branca")
        {
            ValorItem1 = custoOstraBranca;
            TempoItem1 = tempoOstraBranca;
        }
        else if (TxSlot1.text == "Ostra Preta")
        {
            ValorItem1 = custoOstraPreta;
            TempoItem1 = tempoOstraPreta;
        }
        else if (TxSlot1.text == "Lagosta")
        {
            ValorItem1 = custoLagosta;
            TempoItem1 = tempoLagosta;
        }
        else if (TxSlot1.text == "Carangueijo")
        {
            ValorItem1 = custoCarangueijo;
            TempoItem1 = tempoCarangueijo;
        }
        else if (TxSlot1.text == null)
        {
            ValorItem1 = 0;
            TempoItem1 = 0;
        }

        //Slot 2

        if (TxSlot2.text == "Queijo")
        {
            ValorItem2 = custoQueijo;
            TempoItem2 = tempoQueijo;
        }
        else if (TxSlot2.text == "Alho")
        {
            ValorItem2 = custoAlho;
            TempoItem2 = tempoAlho;
        }
        else if (TxSlot2.text == "Cebola")
        {
            ValorItem2 = custoCebola;
            TempoItem2 = tempoCebola;
        }
        else if (TxSlot2.text == "Tomate")
        {
            ValorItem2 = custoTomate;
            TempoItem2 = tempoTomate;
        }
        else if (TxSlot2.text == "Alface")
        {
            ValorItem2 = custoAlface;
            TempoItem2 = tempoAlface;
        }
        else if (TxSlot2.text == "Pimenta")
        {
            ValorItem2 = custoPimenta;
            TempoItem2 = tempoPimenta;
        }
        else if (TxSlot2.text == "Pao")
        {
            ValorItem2 = custoPao;
            TempoItem2 = tempoPao;
        }
        else if (TxSlot2.text == "Cenoura")
        {
            ValorItem2 = custoCenoura;
            TempoItem2 = tempoCenoura;
        }
        else if (TxSlot2.text == "Frango")
        {
            ValorItem2 = custoFrango;
            TempoItem2 = tempoFrango;
        }
        else if (TxSlot2.text == "Ovo")
        {
            ValorItem2 = custoOvo;
            TempoItem2 = tempoOvo;
        }
        else if (TxSlot2.text == "Peixe Pequeno")
        {
            ValorItem2 = custoPeixePequeno;
            TempoItem2 = tempoPeixePequeno;
        }
        else if (TxSlot2.text == "Milho")
        {
            ValorItem2 = custoMilho;
            TempoItem2 = tempoMilho;
        }
        else if (TxSlot2.text == "Atum")
        {
            ValorItem2 = custoAtum;
            TempoItem2 = tempoAtum;
        }
        else if (TxSlot2.text == "Abobora")
        {
            ValorItem2 = custoAbobora;
            TempoItem2 = tempoAbobora;
        }
        else if (TxSlot2.text == "Limao")
        {
            ValorItem2 = custoLimao;
            TempoItem2 = tempoLimao;
        }
        else if (TxSlot2.text == "Bacon")
        {
            ValorItem2 = custoBacon;
            TempoItem2 = tempoBacon;
        }
        else if (TxSlot2.text == "Manteiga")
        {
            ValorItem2 = custoManteiga;
            TempoItem2 = tempoManteiga;
        }
        else if (TxSlot2.text == "Carne Bovina")
        {
            ValorItem2 = custoCarneBovina;
            TempoItem2 = tempoCarneBovina;
        }
        else if (TxSlot2.text == "Carne Suina")
        {
            ValorItem2 = custoCarneSuina;
            TempoItem2 = tempoCarneSuina;
        }
        else if (TxSlot2.text == "Mel")
        {
            ValorItem2 = custoMel;
            TempoItem2 = tempoMel;
        }
        else if (TxSlot2.text == "Macarrao")
        {
            ValorItem2 = custoMacarrao;
            TempoItem2 = tempoMacarrao;
        }
        else if (TxSlot2.text == "Ervilha")
        {
            ValorItem2 = custoErvilha;
            TempoItem2 = tempoErvilha;
        }
        else if (TxSlot2.text == "Cogumelo")
        {
            ValorItem2 = custoCogumelo;
            TempoItem2 = tempoCogumelo;
        }
        else if (TxSlot2.text == "Beringela")
        {
            ValorItem2 = custoBeringela;
            TempoItem2 = tempoBeringela;
        }
        else if (TxSlot2.text == "Carne Ovelha")
        {
            ValorItem2 = custoCarneDeOvelha;
            TempoItem2 = tempoCarneDeOvelha;
        }
        else if (TxSlot2.text == "Molho Branco")
        {
            ValorItem2 = custoMolhoBranco;
            TempoItem2 = tempoMolhoBranco;
        }
        else if (TxSlot2.text == "Lula")
        {
            ValorItem2 = custoLula;
            TempoItem2 = tempoLula;
        }
        else if (TxSlot2.text == "Chocolate")
        {
            ValorItem2 = custoChocolate;
            TempoItem2 = tempoChocolate;
        }
        else if (TxSlot2.text == "Molho")
        {
            ValorItem2 = custoMolho;
            TempoItem2 = tempoMolho;
        }
        else if (TxSlot2.text == "Polvo")
        {
            ValorItem2 = custoPolvo;
            TempoItem2 = tempoPolvo;
        }
        else if (TxSlot2.text == "Camarao")
        {
            ValorItem2 = custoCamarao;
            TempoItem2 = tempoCamarao;
        }
        else if (TxSlot2.text == "Peixe Grande")
        {
            ValorItem2 = custoPeixeGrande;
            TempoItem2 = tempoPeixeGrande;
        }
        else if (TxSlot2.text == "Ostra Branca")
        {
            ValorItem2 = custoOstraBranca;
            TempoItem2 = tempoOstraBranca;
        }
        else if (TxSlot2.text == "Ostra Preta")
        {
            ValorItem2 = custoOstraPreta;
            TempoItem2 = tempoOstraPreta;
        }
        else if (TxSlot2.text == "Lagosta")
        {
            ValorItem2 = custoLagosta;
            TempoItem2 = tempoLagosta;
        }
        else if (TxSlot2.text == "Carangueijo")
        {
            ValorItem2 = custoCarangueijo;
            TempoItem2 = tempoCarangueijo;
        }
        else if (TxSlot2.text == null)
        {
            ValorItem2 = 0;
            TempoItem2 = 0;
        }

        //Slot 3

        if (TxSlot3.text == "Queijo")
        {
            ValorItem3 = custoQueijo;
            TempoItem3 = tempoQueijo;
        }
        else if (TxSlot3.text == "Alho")
        {
            ValorItem3 = custoAlho;
            TempoItem3 = tempoAlho;
        }
        else if (TxSlot3.text == "Cebola")
        {
            ValorItem3 = custoCebola;
            TempoItem3 = tempoCebola;
        }
        else if (TxSlot3.text == "Tomate")
        {
            ValorItem3 = custoTomate;
            TempoItem3 = tempoTomate;
        }
        else if (TxSlot3.text == "Alface")
        {
            ValorItem3 = custoAlface;
            TempoItem3 = tempoAlface;
        }
        else if (TxSlot3.text == "Pimenta")
        {
            ValorItem3 = custoPimenta;
            TempoItem3 = tempoPimenta;
        }
        else if (TxSlot3.text == "Pao")
        {
            ValorItem3 = custoPao;
            TempoItem3 = tempoPao;
        }
        else if (TxSlot3.text == "Cenoura")
        {
            ValorItem3 = custoCenoura;
            TempoItem3 = tempoCenoura;
        }
        else if (TxSlot3.text == "Frango")
        {
            ValorItem3 = custoFrango;
            TempoItem3 = tempoFrango;
        }
        else if (TxSlot3.text == "Ovo")
        {
            ValorItem3 = custoOvo;
            TempoItem3 = tempoOvo;
        }
        else if (TxSlot3.text == "Peixe Pequeno")
        {
            ValorItem3 = custoPeixePequeno;
            TempoItem3 = tempoPeixePequeno;
        }
        else if (TxSlot3.text == "Milho")
        {
            ValorItem3 = custoMilho;
            TempoItem3 = tempoMilho;
        }
        else if (TxSlot3.text == "Atum")
        {
            ValorItem3 = custoAtum;
            TempoItem3 = tempoAtum;
        }
        else if (TxSlot3.text == "Abobora")
        {
            ValorItem3 = custoAbobora;
            TempoItem3 = tempoAbobora;
        }
        else if (TxSlot3.text == "Limao")
        {
            ValorItem3 = custoLimao;
            TempoItem3 = tempoLimao;
        }
        else if (TxSlot3.text == "Bacon")
        {
            ValorItem3 = custoBacon;
            TempoItem3 = tempoBacon;
        }
        else if (TxSlot3.text == "Manteiga")
        {
            ValorItem3 = custoManteiga;
            TempoItem3 = tempoManteiga;
        }
        else if (TxSlot3.text == "Carne Bovina")
        {
            ValorItem3 = custoCarneBovina;
            TempoItem3 = tempoCarneBovina;
        }
        else if (TxSlot3.text == "Carne Suina")
        {
            ValorItem3 = custoCarneSuina;
            TempoItem3 = tempoCarneSuina;
        }
        else if (TxSlot3.text == "Mel")
        {
            ValorItem3 = custoMel;
            TempoItem3 = tempoMel;
        }
        else if (TxSlot3.text == "Macarrao")
        {
            ValorItem3 = custoMacarrao;
            TempoItem3 = tempoMacarrao;
        }
        else if (TxSlot3.text == "Ervilha")
        {
            ValorItem3 = custoErvilha;
            TempoItem3 = tempoErvilha;
        }
        else if (TxSlot3.text == "Cogumelo")
        {
            ValorItem3 = custoCogumelo;
            TempoItem3 = tempoCogumelo;
        }
        else if (TxSlot3.text == "Beringela")
        {
            ValorItem3 = custoBeringela;
            TempoItem3 = tempoBeringela;
        }
        else if (TxSlot3.text == "Carne Ovelha")
        {
            ValorItem3 = custoCarneDeOvelha;
            TempoItem3 = tempoCarneDeOvelha;
        }
        else if (TxSlot3.text == "Molho Branco")
        {
            ValorItem3 = custoMolhoBranco;
            TempoItem3 = tempoMolhoBranco;
        }
        else if (TxSlot3.text == "Lula")
        {
            ValorItem3 = custoLula;
            TempoItem3 = tempoLula;
        }
        else if (TxSlot3.text == "Chocolate")
        {
            ValorItem3 = custoChocolate;
            TempoItem3 = tempoChocolate;
        }
        else if (TxSlot3.text == "Molho")
        {
            ValorItem3 = custoMolho;
            TempoItem3 = tempoMolho;
        }
        else if (TxSlot3.text == "Polvo")
        {
            ValorItem3 = custoPolvo;
            TempoItem3 = tempoPolvo;
        }
        else if (TxSlot3.text == "Camarao")
        {
            ValorItem3 = custoCamarao;
            TempoItem3 = tempoCamarao;
        }
        else if (TxSlot3.text == "Peixe Grande")
        {
            ValorItem3 = custoPeixeGrande;
            TempoItem3 = tempoPeixeGrande;
        }
        else if (TxSlot3.text == "Ostra Branca")
        {
            ValorItem3 = custoOstraBranca;
            TempoItem3 = tempoOstraBranca;
        }
        else if (TxSlot3.text == "Ostra Preta")
        {
            ValorItem3 = custoOstraPreta;
            TempoItem3 = tempoOstraPreta;
        }
        else if (TxSlot3.text == "Lagosta")
        {
            ValorItem3 = custoLagosta;
            TempoItem3 = tempoLagosta;
        }
        else if (TxSlot3.text == "Carangueijo")
        {
            ValorItem3 = custoCarangueijo;
            TempoItem3 = tempoCarangueijo;
        }
        else if (TxSlot3.text == null)
        {
            ValorItem3 = 0;
            TempoItem3 = 0;
        }

        //Slot 4

        if (TxSlot4.text == "Queijo")
        {
            ValorItem4 = custoQueijo;
            TempoItem4 = tempoQueijo;
        }
        else if (TxSlot4.text == "Alho")
        {
            ValorItem4 = custoAlho;
            TempoItem4 = tempoAlho;
        }
        else if (TxSlot4.text == "Cebola")
        {
            ValorItem4 = custoCebola;
            TempoItem4 = tempoCebola;
        }
        else if (TxSlot4.text == "Tomate")
        {
            ValorItem4 = custoTomate;
            TempoItem4 = tempoTomate;
        }
        else if (TxSlot4.text == "Alface")
        {
            ValorItem4 = custoAlface;
            TempoItem4 = tempoAlface;
        }
        else if (TxSlot4.text == "Pimenta")
        {
            ValorItem4 = custoPimenta;
            TempoItem4 = tempoPimenta;
        }
        else if (TxSlot4.text == "Pao")
        {
            ValorItem4 = custoPao;
            TempoItem4 = tempoPao;
        }
        else if (TxSlot4.text == "Cenoura")
        {
            ValorItem4 = custoCenoura;
            TempoItem4 = tempoCenoura;
        }
        else if (TxSlot4.text == "Frango")
        {
            ValorItem4 = custoFrango;
            TempoItem4 = tempoFrango;
        }
        else if (TxSlot4.text == "Ovo")
        {
            ValorItem4 = custoOvo;
            TempoItem4 = tempoOvo;
        }
        else if (TxSlot4.text == "Peixe Pequeno")
        {
            ValorItem4 = custoPeixePequeno;
            TempoItem4 = tempoPeixePequeno;
        }
        else if (TxSlot4.text == "Milho")
        {
            ValorItem4 = custoMilho;
            TempoItem4 = tempoMilho;
        }
        else if (TxSlot4.text == "Atum")
        {
            ValorItem4 = custoAtum;
            TempoItem4 = tempoAtum;
        }
        else if (TxSlot4.text == "Abobora")
        {
            ValorItem4 = custoAbobora;
            TempoItem4 = tempoAbobora;
        }
        else if (TxSlot4.text == "Limao")
        {
            ValorItem4 = custoLimao;
            TempoItem4 = tempoLimao;
        }
        else if (TxSlot4.text == "Bacon")
        {
            ValorItem4 = custoBacon;
            TempoItem4 = tempoBacon;
        }
        else if (TxSlot4.text == "Manteiga")
        {
            ValorItem4 = custoManteiga;
            TempoItem4 = tempoManteiga;
        }
        else if (TxSlot4.text == "Carne Bovina")
        {
            ValorItem4 = custoCarneBovina;
            TempoItem4 = tempoCarneBovina;
        }
        else if (TxSlot4.text == "Carne Suina")
        {
            ValorItem4 = custoCarneSuina;
            TempoItem4 = tempoCarneSuina;
        }
        else if (TxSlot4.text == "Mel")
        {
            ValorItem4 = custoMel;
            TempoItem4 = tempoMel;
        }
        else if (TxSlot4.text == "Macarrao")
        {
            ValorItem4 = custoMacarrao;
            TempoItem4 = tempoMacarrao;
        }
        else if (TxSlot4.text == "Ervilha")
        {
            ValorItem4 = custoErvilha;
            TempoItem4 = tempoErvilha;
        }
        else if (TxSlot4.text == "Cogumelo")
        {
            ValorItem4 = custoCogumelo;
            TempoItem4 = tempoCogumelo;
        }
        else if (TxSlot4.text == "Beringela")
        {
            ValorItem4 = custoBeringela;
            TempoItem4 = tempoBeringela;
        }
        else if (TxSlot4.text == "Carne Ovelha")
        {
            ValorItem4 = custoCarneDeOvelha;
            TempoItem4 = tempoCarneDeOvelha;
        }
        else if (TxSlot4.text == "Molho Branco")
        {
            ValorItem4 = custoMolhoBranco;
            TempoItem4 = tempoMolhoBranco;
        }
        else if (TxSlot4.text == "Lula")
        {
            ValorItem4 = custoLula;
            TempoItem4 = tempoLula;
        }
        else if (TxSlot4.text == "Chocolate")
        {
            ValorItem4 = custoChocolate;
            TempoItem4 = tempoChocolate;
        }
        else if (TxSlot4.text == "Molho")
        {
            ValorItem4 = custoMolho;
            TempoItem4 = tempoMolho;
        }
        else if (TxSlot4.text == "Polvo")
        {
            ValorItem4 = custoPolvo;
            TempoItem4 = tempoPolvo;
        }
        else if (TxSlot4.text == "Camarao")
        {
            ValorItem4 = custoCamarao;
            TempoItem4 = tempoCamarao;
        }
        else if (TxSlot4.text == "Peixe Grande")
        {
            ValorItem4 = custoPeixeGrande;
            TempoItem4 = tempoPeixeGrande;
        }
        else if (TxSlot4.text == "Ostra Branca")
        {
            ValorItem4 = custoOstraBranca;
            TempoItem4 = tempoOstraBranca;
        }
        else if (TxSlot4.text == "Ostra Preta")
        {
            ValorItem4 = custoOstraPreta;
            TempoItem4 = tempoOstraPreta;
        }
        else if (TxSlot4.text == "Lagosta")
        {
            ValorItem4 = custoLagosta;
            TempoItem4 = tempoLagosta;
        }
        else if (TxSlot4.text == "Carangueijo")
        {
            ValorItem4 = custoCarangueijo;
            TempoItem4 = tempoCarangueijo;
        }
        else if (TxSlot4.text == null)
        {
            ValorItem4 = 0;
            TempoItem4 = 0;
        }

        //Slot Bebida

        if (TxSlotBebida.text == "Agua")
        {
            ValorItem5 = custoAgua;
            TempoItem5 = tempoAgua;
        }
        else if (TxSlotBebida.text == "Suco de Morango")
        {
            ValorItem5 = custoSucoDeMorango;
            TempoItem5 = tempoSucoDeMorango;
        }
        else if (TxSlotBebida.text == "Suco de Limao")
        {
            ValorItem5 = custoSucoDeLimao;
            TempoItem5 = tempoSucoDeLimao;
        }
        else if (TxSlotBebida.text == "Suco de Laranja")
        {
            ValorItem5 = custoSucoDeLaranja;
            TempoItem5 = tempoSucoDeLaranja;
        }
        else if (TxSlotBebida.text == "Cha Gelado")
        {
            ValorItem5 = custoChaGelado;
            TempoItem5 = tempoChaGelado;
        }
        else if (TxSlotBebida.text == "Suco de Cereja")
        {
            ValorItem5 = custoSucoDeCereja;
            TempoItem5 = tempoSucoDeCereja;
        }
        else if (TxSlotBebida.text == "Cafe")
        {
            ValorItem5 = custoCafe;
            TempoItem5 = tempoCafe;
        }
        else if (TxSlotBebida.text == "Limonada Suica")
        {
            ValorItem5 = custoLimonadaSuica;
            TempoItem5 = tempoLimonadaSuica;
        }
        else if (TxSlotBebida.text == "Leite")
        {
            ValorItem5 = custoLeite;
            TempoItem5 = tempoLeite;
        }
        else if (TxSlotBebida.text == "Cappuccino")
        {
            ValorItem5 = custoCappuccino;
            TempoItem5 = tempoCappuccino;
        }
        else if (TxSlotBebida.text == "Drink de Morango")
        {
            ValorItem5 = custoDrinkDeMorango;
            TempoItem5 = tempoDrinkDeMorango;
        }
        else if (TxSlotBebida.text == "Cerveja")
        {
            ValorItem5 = custoCerveja;
            TempoItem5 = tempoCerveja;
        }
        else if (TxSlotBebida.text == "Cha Quente")
        {
            ValorItem5 = custoChaQuente;
            TempoItem5 = tempoChaQuente;
        }
        else if (TxSlotBebida.text == "Drink Suico")
        {
            ValorItem5 = custoDrinkSuico;
            TempoItem5 = tempoDrinkSuico;
        }
        else if (TxSlotBebida.text == "Drink Colorido")
        {
            ValorItem5 = custoDrinkColorido;
            TempoItem5 = tempoDrinkColorido;
        }
        else if (TxSlotBebida.text == "Cha de Mel")
        {
            ValorItem5 = custoChaDeMel;
            TempoItem5 = tempoChaDeMel;
        }
        else if (TxSlotBebida.text == "Vinho")
        {
            ValorItem5 = custoVinho;
            TempoItem5 = tempoVinho;
        }
        else if (TxSlotBebida.text == "Drink Luxo")
        {
            ValorItem5 = custoDrinkLuxo;
            TempoItem5 = tempoDrinkLuxo;
        }
        else if (TxSlotBebida.text == null)
        {
            ValorItem5 = 0;
            TempoItem5 = 0;
        }
    }

    public void Calcula()
    {
        ResumoDoCusto.text = ResumoCusto.ToString();
        ResumoDoTempo.text = ResumoTempo.ToString() + " s";
        ValorDaVenda.text = (ResumoCusto + ((ResumoCusto * Lucro) / 100)).ToString();
        ResumoCusto = ValorItem1 + ValorItem2 + ValorItem3 + ValorItem4 + ValorItem5;
        ResumoTempo = TempoItem1 + TempoItem2 + TempoItem3 + TempoItem4 + TempoItem5;
    }

    public void ControlaVersaoWeb() 
    {
        if (ControlaHUB.GetComponent<ControlaHUB>().VersaoWEB == true)
        {
            System.Array.Resize(ref Ingredientes, 35);
            System.Array.Resize(ref Bebidas, 18);
            Ingredientes[12] = "Abobora";
            Ingredientes[13] = "Limao";
            Ingredientes[14] = "Bacon";
            Ingredientes[15] = "Manteiga";
            Ingredientes[16] = "Carne Bovina";
            Ingredientes[17] = "Carne Suina";
            Ingredientes[18] = "Mel";
            Ingredientes[19] = "Macarrao";
            Ingredientes[20] = "Ervilha";
            Ingredientes[21] = "Cogumelo";
            Ingredientes[22] = "Beringela";
            Ingredientes[23] = "Carne de Ovelha";
            Ingredientes[24] = "Molho Branco";
            Ingredientes[25] = "Lula";
            Ingredientes[26] = "Chocolate";
            Ingredientes[27] = "Molho";
            Ingredientes[28] = "Polvo";
            Ingredientes[29] = "Peixe Grande";
            Ingredientes[30] = "Camarao";
            Ingredientes[31] = "Ostra Branca";
            Ingredientes[32] = "Ostra Preta";
            Ingredientes[33] = "Lagosta";
            Ingredientes[34] = "Carangueijo";

            Bebidas[3] = "Suco de Laranja";
            Bebidas[4] = "Cha Gelado";
            Bebidas[5] = "Suco de Cereja";
            Bebidas[6] = "Cafe";
            Bebidas[7] = "Limonada Suica";
            Bebidas[8] = "Leite";
            Bebidas[9] = "Cappuccino";
            Bebidas[10] = "Drink de Morango";
            Bebidas[11] = "Cerveja";
            Bebidas[12] = "Cha Quente";
            Bebidas[13] = "Drink Suico";
            Bebidas[14] = "Drink Colorido";
            Bebidas[15] = "Cha de Mel";
            Bebidas[16] = "Vinho";
            Bebidas[17] = "Drink Luxo";

            for (int i = 0; i < ItemBloqueado.Length; i++)
            {
                if (ItemBloqueado[i].activeSelf == true)
                {
                    ItemBloqueado[i].SetActive(false);
                }
            }
        }
    }
 }
