using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PopUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler, IPointerClickHandler, IBeginDragHandler, IEndDragHandler
{
    public GameObject _PopUp;
    public TextMeshProUGUI PopUpPre�o;
    public TextMeshProUGUI PopUpNome;
    public TextMeshProUGUI PopUpTempo;
    private string NomeDoIngrediente;
    public GameObject DadosIngredientesBebidas;
    private Vector3 clickPos;

    private float tempoQueijo;
    private float tempoAlho;
    private float tempoCebola;
    private float tempoTomate;
    private float tempoAlface;
    private float tempoPimenta;
    private float tempoPao;
    private float tempoCenoura;
    private float tempoFrango;
    private float tempoOvo;
    private float tempoPeixePequeno;
    private float tempoMilho;
    private float tempoAtum;
    private float tempoAbobora;
    private float tempoLimao;
    private float tempoBacon;
    private float tempoManteiga;
    private float tempoCarneBovina;
    private float tempoCarneSuina;
    private float tempoMel;
    private float tempoMacarrao;
    private float tempoErvilha;
    private float tempoCogumelo;
    private float tempoBeringela;
    private float tempoCarneDeOvelha;
    private float tempoMolhoBranco;
    private float tempoLula;
    private float tempoChocolate;
    private float tempoMolho;
    private float tempoPolvo;
    private float tempoPeixeGrande;
    private float tempoCamarao;
    private float tempoOstraBranca;
    private float tempoOstraPreta;
    private float tempoLagosta;
    private float tempoCarangueijo;

    private float custoQueijo;
    private float custoAlho;
    private float custoCebola;
    private float custoTomate;
    private float custoAlface;
    private float custoPimenta;
    private float custoPao;
    private float custoCenoura;
    private float custoFrango;
    private float custoOvo;
    private float custoPeixePequeno;
    private float custoMilho;
    private float custoAtum;
    private float custoAbobora;
    private float custoLimao;
    private float custoBacon;
    private float custoManteiga;
    private float custoCarneBovina;
    private float custoCarneSuina;
    private float custoMel;
    private float custoMacarrao;
    private float custoErvilha;
    private float custoCogumelo;
    private float custoBeringela;
    private float custoCarneDeOvelha;
    private float custoMolhoBranco;
    private float custoLula;
    private float custoChocolate;
    private float custoMolho;
    private float custoPolvo;
    private float custoPeixeGrande;
    private float custoCamarao;
    private float custoOstraBranca;
    private float custoOstraPreta;
    private float custoLagosta;
    private float custoCarangueijo;

    private float tempoAgua;
    private float tempoSucoDeMorango;
    private float tempoSucoDeLaranja;
    private float tempoSucoDeLimao;
    private float tempoChaGelado;
    private float tempoSucoDeCereja;
    private float tempoCafe;
    private float tempoLimonadaSuica;
    private float tempoLeite;
    private float tempoCappuccino;
    private float tempoDrinkDeMorango;
    private float tempoCerveja;
    private float tempoChaQuente;
    private float tempoDrinkSuico;
    private float tempoDrinkColorido;
    private float tempoChaDeMel;
    private float tempoVinho;
    private float tempoDrinkLuxo;

    private float custoAgua;
    private float custoSucoDeMorango;
    private float custoSucoDeLimao;
    private float custoSucoDeLaranja;
    private float custoChaGelado;
    private float custoSucoDeCereja;
    private float custoCafe;
    private float custoLimonadaSuica;
    private float custoLeite;
    private float custoCappuccino;
    private float custoDrinkDeMorango;
    private float custoCerveja;
    private float custoChaQuente;
    private float custoDrinkSuico;
    private float custoDrinkColorido;
    private float custoChaDeMel;
    private float custoVinho;
    private float custoDrinkLuxo;

    private void Start()
    {
        tempoQueijo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoQueijo;
        tempoCebola = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCebola;
        tempoTomate = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoTomate;
        tempoAlface = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoAlface;
        tempoPimenta = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoPimenta;
        tempoPao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoPao;
        tempoCenoura = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCenoura;
        tempoFrango = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoFrango;
        tempoOvo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoOvo;
        tempoPeixePequeno = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoPeixePequeno;
        tempoMilho = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoMilho;
        tempoAtum = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoAtum;
        tempoAbobora = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoAbobora;
        tempoLimao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoLimao;
        tempoBacon = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoBacon;
        tempoManteiga = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoManteiga;
        tempoCarneBovina = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCarneBovina;
        tempoCarneSuina = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCarneSuina;
        tempoMel = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoMel;
        tempoMacarrao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoMacarrao;
        tempoErvilha = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoErvilha;
        tempoCogumelo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCogumelo;
        tempoBeringela = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoBeringela;
        tempoCarneDeOvelha = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCarneDeOvelha;
        tempoMolhoBranco = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoMolhoBranco;
        tempoLula = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoLula;
        tempoChocolate = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoChocolate;
        tempoMolho = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoMolho;
        tempoPolvo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoPolvo;
        tempoPeixeGrande = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoPeixeGrande;
        tempoCamarao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCamarao;
        tempoOstraBranca = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoOstraBranca;
        tempoOstraPreta = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoOstraPreta;
        tempoLagosta = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoLagosta;
        tempoCarangueijo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCarangueijo;


        custoQueijo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoQueijo;
        custoAlho = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoAlho;
        custoCebola = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCebola;
        custoTomate = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoTomate;
        custoAlface = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoAlface;
        custoPimenta = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoPimenta;
        custoPao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoPao;
        custoFrango = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoFrango;
        custoOvo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoOvo;
        custoPeixePequeno = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoPeixePequeno;
        custoMilho = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoMilho;
        custoAtum = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoAtum;
        custoAbobora = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoAbobora;
        custoLimao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoLimao;
        custoBacon = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoBacon;
        custoManteiga = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoManteiga;
        custoCarneBovina = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCarneBovina;
        custoCarneSuina = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCarneSuina;
        custoMel = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoMel;
        custoMacarrao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoMacarrao;
        custoErvilha = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoErvilha;
        custoCogumelo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCogumelo;
        custoBeringela = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoBeringela;
        custoCarneDeOvelha = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCarneDeOvelha;
        custoMolhoBranco = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoMolhoBranco;
        custoLula = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoLula;
        custoChocolate = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoChocolate;
        custoMolho = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoMolho;
        custoPolvo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoPolvo;
        custoPeixeGrande = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoPeixeGrande;
        custoCamarao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCamarao;
        custoOstraBranca = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoOstraBranca;
        custoOstraPreta = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoOstraPreta;
        custoLagosta = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoLagosta;
        custoCarangueijo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCarangueijo;

        //Bebidas abaixo

        tempoAgua = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoAgua;
        tempoSucoDeMorango = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoSucoDeMorango;
        tempoSucoDeLimao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoSucoDeLimao;
        tempoSucoDeLaranja = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoSucoDeLaranja;
        tempoChaGelado = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoChaGelado;
        tempoSucoDeCereja = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoSucoDeCereja;
        tempoCafe = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCafe;
        tempoLimonadaSuica = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoLimonadaSuica;
        tempoLeite = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoLeite;
        tempoCappuccino = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCappuccino;
        tempoDrinkDeMorango = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoDrinkDeMorango;
        tempoCerveja = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoCerveja;
        tempoChaQuente = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoChaQuente;
        tempoDrinkSuico = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoDrinkSuico;
        tempoDrinkColorido = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoDrinkColorido;
        tempoChaDeMel = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoChaDeMel;
        tempoVinho = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoVinho;
        tempoDrinkLuxo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().tempoDrinkLuxo;



        custoAgua = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoAgua;
        custoSucoDeMorango = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoSucoDeMorango;
        custoSucoDeLimao = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoSucoDeLimao;
        custoSucoDeLaranja = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoSucoDeLaranja;
        custoChaGelado = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoChaGelado;
        custoSucoDeCereja = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoSucoDeCereja;
        custoCafe = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCafe;
        custoLimonadaSuica = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoLimonadaSuica;
        custoLeite = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoLeite;
        custoCappuccino = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCappuccino;
        custoDrinkDeMorango = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoDrinkDeMorango;
        custoCerveja = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoCerveja;
        custoChaQuente = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoChaQuente;
        custoDrinkSuico = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoDrinkSuico;
        custoDrinkColorido = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoDrinkColorido;
        custoChaDeMel = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoChaDeMel;
        custoVinho = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoVinho;
        custoDrinkLuxo = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().custoDrinkLuxo;

    }

    private void Update()
    {
        string tagName = gameObject.tag;
        if(tagName == "Bebida")
        {
            NomeDoIngrediente = GetComponent<Bebidas>().NomeDoIngrediente;
        }
        if (tagName == "Ingredientes")
        {
            NomeDoIngrediente = GetComponent<Ingrediente>().NomeDoIngrediente;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        clickPos = eventData.position;
        if (clickPos.x > Screen.width / 2)
        {
            _PopUp.SetActive(!_PopUp.activeSelf);
            _PopUp.transform.position = clickPos + new Vector3(-270, 150, 0);
            AtualizaPosicaoPopUp(eventData.position);
        }

        // Verificar se a posi��o X do clique est� na metade esquerda da tela
        if (clickPos.x < Screen.width / 2)
        {
            _PopUp.SetActive(!_PopUp.activeSelf);
            _PopUp.transform.position = clickPos + new Vector3(270, 150, 0);
            AtualizaPosicaoPopUp(eventData.position);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _PopUp.SetActive(false);
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    public void OnPointerMove(PointerEventData eventData)
    {
    }

    private void AtualizaPosicaoPopUp(Vector2 PosicaoMouse)
    {        
        PopUpNome.text = NomeDoIngrediente;
        if (NomeDoIngrediente == "Queijo")
        {
            PopUpTempo.text = tempoQueijo.ToString();
            PopUpPre�o.text = custoQueijo.ToString();
        }
        if (NomeDoIngrediente == "Alho")
        {
            PopUpTempo.text = tempoAlho.ToString();
            PopUpPre�o.text = custoAlho.ToString();
        }
        if (NomeDoIngrediente == "Cebola")
        {
            PopUpTempo.text = tempoCebola.ToString();
            PopUpPre�o.text = custoCebola.ToString();
        }
        if (NomeDoIngrediente == "Tomate")
        {
            PopUpTempo.text = tempoTomate.ToString();
            PopUpPre�o.text = custoTomate.ToString();
        }
        if (NomeDoIngrediente == "Alface")
        {
            PopUpTempo.text = tempoAlface.ToString();
            PopUpPre�o.text = custoAlface.ToString();
        }
        if (NomeDoIngrediente == "Pimenta")
        {
            PopUpTempo.text = tempoPimenta.ToString();
            PopUpPre�o.text = custoPimenta.ToString();
        }
        if (NomeDoIngrediente == "Pao")
        {
            PopUpTempo.text = tempoPao.ToString();
            PopUpPre�o.text = custoPao.ToString();
        }
        if (NomeDoIngrediente == "Cenoura")
        {
            PopUpTempo.text = tempoCenoura.ToString();
            PopUpPre�o.text = custoCenoura.ToString();
        }
        if (NomeDoIngrediente == "Frango")
        {
            PopUpTempo.text = tempoFrango.ToString();
            PopUpPre�o.text = custoFrango.ToString();
        }
        if (NomeDoIngrediente == "Ovo")
        {
            PopUpTempo.text = tempoOvo.ToString();
            PopUpPre�o.text = custoOvo.ToString();
        }
        if (NomeDoIngrediente == "Peixe Pequeno")
        {
            PopUpTempo.text = tempoPeixePequeno.ToString();
            PopUpPre�o.text = custoPeixePequeno.ToString();
        }
        if (NomeDoIngrediente == "Milho")
        {
            PopUpTempo.text = tempoMilho.ToString();
            PopUpPre�o.text = custoMilho.ToString();
        }
        if (NomeDoIngrediente == "Atum")
        {
            PopUpTempo.text = tempoAtum.ToString();
            PopUpPre�o.text = custoAtum.ToString();
        }
        if (NomeDoIngrediente == "Abobora")
        {
            PopUpTempo.text = tempoAbobora.ToString();
            PopUpPre�o.text = custoAbobora.ToString();
        }
        if (NomeDoIngrediente == "Limao")
        {
            PopUpTempo.text = tempoLimao.ToString();
            PopUpPre�o.text = custoLimao.ToString();
        }
        if (NomeDoIngrediente == "Bacon")
        {
            PopUpTempo.text = tempoBacon.ToString();
            PopUpPre�o.text = custoBacon.ToString();
        }
        if (NomeDoIngrediente == "Manteiga")
        {
            PopUpTempo.text = tempoManteiga.ToString();
            PopUpPre�o.text = custoManteiga.ToString();
        }
        if (NomeDoIngrediente == "Carne Bovina")
        {
            PopUpTempo.text = tempoCarneBovina.ToString();
            PopUpPre�o.text = custoCarneBovina.ToString();
        }
        if (NomeDoIngrediente == "Carne Suina")
        {
            PopUpTempo.text = tempoCarneSuina.ToString();
            PopUpPre�o.text = custoCarneSuina.ToString();
        }
        if (NomeDoIngrediente == "Mel")
        {
            PopUpTempo.text = tempoMel.ToString();
            PopUpPre�o.text = custoMel.ToString();
        }
        if (NomeDoIngrediente == "Macarrao")
        {
            PopUpTempo.text = tempoMacarrao.ToString();
            PopUpPre�o.text = custoMacarrao.ToString();
        }
        if (NomeDoIngrediente == "Ervilha")
        {
            PopUpTempo.text = tempoErvilha.ToString();
            PopUpPre�o.text = custoErvilha.ToString();
        }
        if (NomeDoIngrediente == "Cogumelo")
        {
            PopUpTempo.text = tempoCogumelo.ToString();
            PopUpPre�o.text = custoCogumelo.ToString();
        }
        if (NomeDoIngrediente == "Beringela")
        {
            PopUpTempo.text = tempoBeringela.ToString();
            PopUpPre�o.text = custoBeringela.ToString();
        }
        if (NomeDoIngrediente == "Cerne Ovelha")
        {
            PopUpTempo.text = tempoCarneDeOvelha.ToString();
            PopUpPre�o.text = custoCarneDeOvelha.ToString();
        }
        if (NomeDoIngrediente == "Molho Branco")
        {
            PopUpTempo.text = tempoMolhoBranco.ToString();
            PopUpPre�o.text = custoMolhoBranco.ToString();
        }
        if (NomeDoIngrediente == "Lula")
        {
            PopUpTempo.text = tempoLula.ToString();
            PopUpPre�o.text = custoLula.ToString();
        }
        if (NomeDoIngrediente == "Chocolate")
        {
            PopUpTempo.text = tempoChocolate.ToString();
            PopUpPre�o.text = custoChocolate.ToString();
        }
        if (NomeDoIngrediente == "Molho")
        {
            PopUpTempo.text = tempoMolho.ToString();
            PopUpPre�o.text = custoMolho.ToString();
        }
        if (NomeDoIngrediente == "Polvo")
        {
            PopUpTempo.text = tempoPolvo.ToString();
            PopUpPre�o.text = custoPolvo.ToString();
        }
        if (NomeDoIngrediente == "Peixe Grande")
        {
            PopUpTempo.text = tempoPeixeGrande.ToString();
            PopUpPre�o.text = custoPeixeGrande.ToString();
        }
        if (NomeDoIngrediente == "Camarao")
        {
            PopUpTempo.text = tempoCamarao.ToString();
            PopUpPre�o.text = custoCamarao.ToString();
        }
        if (NomeDoIngrediente == "Ostra Branco")
        {
            PopUpTempo.text = tempoOstraBranca.ToString();
            PopUpPre�o.text = custoOstraBranca.ToString();
        }
        if (NomeDoIngrediente == "Ostra Preta")
        {
            PopUpTempo.text = tempoOstraPreta.ToString();
            PopUpPre�o.text = custoOstraPreta.ToString();
        }
        if (NomeDoIngrediente == "Lagosta")
        {
            PopUpTempo.text = tempoLagosta.ToString();
            PopUpPre�o.text = custoLagosta.ToString();
        }
        if (NomeDoIngrediente == "Carangueijo")
        {
            PopUpTempo.text = tempoCarangueijo.ToString();
            PopUpPre�o.text = custoCarangueijo.ToString();
        }

        //Bebidas abaixo
        if (NomeDoIngrediente == "Agua")
        {
            PopUpTempo.text = tempoAgua.ToString();
            PopUpPre�o.text = custoAgua.ToString();
        }
        if (NomeDoIngrediente == "Suco de Morango")
        {
            PopUpTempo.text = tempoSucoDeMorango.ToString();
            PopUpPre�o.text = custoSucoDeMorango.ToString();
        }
        if (NomeDoIngrediente == "Suco de Limao")
        {
            PopUpTempo.text = tempoSucoDeLimao.ToString();
            PopUpPre�o.text = custoSucoDeLimao.ToString();
        }
        if (NomeDoIngrediente == "Suco de Laranja")
        {
            PopUpTempo.text = tempoSucoDeLaranja.ToString();
            PopUpPre�o.text = custoSucoDeLaranja.ToString();
        }
        if (NomeDoIngrediente == "Cha Gelado")
        {
            PopUpTempo.text = tempoChaGelado.ToString();
            PopUpPre�o.text = custoChaGelado.ToString();
        }
        if (NomeDoIngrediente == "Suco de Cereja")
        {
            PopUpTempo.text = tempoSucoDeCereja.ToString();
            PopUpPre�o.text = custoSucoDeCereja.ToString();
        }
        if (NomeDoIngrediente == "Cafe")
        {
            PopUpTempo.text = tempoCafe.ToString();
            PopUpPre�o.text = custoCafe.ToString();
        }
        if (NomeDoIngrediente == "Limonada Suica")
        {
            PopUpTempo.text = tempoLimonadaSuica.ToString();
            PopUpPre�o.text = custoLimonadaSuica.ToString();
        }
        if (NomeDoIngrediente == "Leite")
        {
            PopUpTempo.text = tempoLeite.ToString();
            PopUpPre�o.text = custoLeite.ToString();
        }
        if (NomeDoIngrediente == "Cappuccino")
        {
            PopUpTempo.text = tempoCappuccino.ToString();
            PopUpPre�o.text = custoCappuccino.ToString();
        }
        if (NomeDoIngrediente == "Cha Quente")
        {
            PopUpTempo.text = tempoChaQuente.ToString();
            PopUpPre�o.text = custoChaQuente.ToString();
        }
        if (NomeDoIngrediente == "Drink Suico")
        {
            PopUpTempo.text = tempoDrinkSuico.ToString();
            PopUpPre�o.text = custoDrinkSuico.ToString();
        }
        if (NomeDoIngrediente == "Drink Colorido")
        {
            PopUpTempo.text = tempoDrinkColorido.ToString();
            PopUpPre�o.text = custoDrinkColorido.ToString();
        }
        if (NomeDoIngrediente == "Cha de Mel")
        {
            PopUpTempo.text = tempoChaDeMel.ToString();
            PopUpPre�o.text = custoChaDeMel.ToString();
        }
        if (NomeDoIngrediente == "Vinho")
        {
            PopUpTempo.text = tempoVinho.ToString();
            PopUpPre�o.text = custoVinho.ToString();
        }
        if (NomeDoIngrediente == "Drink Luxo")
        {
            PopUpTempo.text = tempoDrinkLuxo.ToString();
            PopUpPre�o.text = custoDrinkLuxo.ToString();
        }
    }
}
