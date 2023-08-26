using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class ResetaCozinha : MonoBehaviour
{
    public RectTransform Queijo;
    public RectTransform Alho;
    public RectTransform Cebola;
    public RectTransform Tomate;
    public RectTransform Alface;
    public RectTransform Pimenta;
    public RectTransform Pao;
    public RectTransform Cenoura;
    public RectTransform Frango;
    public RectTransform Ovo;
    public RectTransform PeixePequeno;
    public RectTransform Milho;
    public RectTransform Atum;
    public RectTransform Abobora;
    public RectTransform Limao;
    public RectTransform Bacon;
    public RectTransform Manteiga;
    public RectTransform CarneBovina;
    public RectTransform CarneSuina;
    public RectTransform Mel;
    public RectTransform Macarrao;
    public RectTransform Ervilha;
    public RectTransform Cogumelo;
    public RectTransform Beringela;
    public RectTransform CarneDeOvelha;
    public RectTransform MolhoBranco;
    public RectTransform Lula;
    public RectTransform Chocolate;
    public RectTransform Molho;
    public RectTransform Polvo;
    public RectTransform PeixeGrande;
    public RectTransform Camarao;
    public RectTransform OstraBranca;
    public RectTransform OstraPreta;
    public RectTransform Lagosta;
    public RectTransform Carangueijo;

    public RectTransform Agua;
    public RectTransform SucoDeMorango;
    public RectTransform SucoDeLimao;
    public RectTransform SucoDeLaranja;
    public RectTransform ChaGelado;
    public RectTransform SucoDeCereja;
    public RectTransform Cafe;
    public RectTransform LimonadaSuica;
    public RectTransform Leite;
    public RectTransform Cappuccino;
    public RectTransform DrinkDeMorango;
    public RectTransform Cerveja;
    public RectTransform ChaQuente;
    public RectTransform DrinkSuico;
    public RectTransform DrinkColorido;
    public RectTransform ChaDeMel;
    public RectTransform Vinho;
    public RectTransform DrinkLuxo;

    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject SlotBebida;
    public TextMeshProUGUI TextoSlot1;
    public TextMeshProUGUI TextoSlot2;
    public TextMeshProUGUI TextoSlot3;
    public TextMeshProUGUI TextoSlot4;
    public TextMeshProUGUI TextoSlotBebida;

    public GameObject[] SlotArmazemIngredientes;
    public GameObject[] SlotArmazemBebidas;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetaIngredientes()
    {
        Queijo.position = SlotArmazemIngredientes[0].GetComponent<RectTransform>().position;
        Alho.position = SlotArmazemIngredientes[1].GetComponent<RectTransform>().position;
        Cebola.position = SlotArmazemIngredientes[2].GetComponent<RectTransform>().position;
        Tomate.position = SlotArmazemIngredientes[3].GetComponent<RectTransform>().position;
        Alface.position = SlotArmazemIngredientes[4].GetComponent<RectTransform>().position;
        Pimenta.position = SlotArmazemIngredientes[5].GetComponent<RectTransform>().position;
        Pao.position = SlotArmazemIngredientes[6].GetComponent<RectTransform>().position;
        Cenoura.position = SlotArmazemIngredientes[7].GetComponent<RectTransform>().position;
        Frango.position = SlotArmazemIngredientes[8].GetComponent<RectTransform>().position;
        Ovo.position = SlotArmazemIngredientes[9].GetComponent<RectTransform>().position;
        PeixePequeno.position = SlotArmazemIngredientes[10].GetComponent<RectTransform>().position;
        Milho.position = SlotArmazemIngredientes[11].GetComponent<RectTransform>().position;
        Atum.position = SlotArmazemIngredientes[12].GetComponent<RectTransform>().position;
        Abobora.position = SlotArmazemIngredientes[13].GetComponent<RectTransform>().position;
        Limao.position = SlotArmazemIngredientes[14].GetComponent<RectTransform>().position;
        Bacon.position = SlotArmazemIngredientes[15].GetComponent<RectTransform>().position;
        Manteiga.position = SlotArmazemIngredientes[16].GetComponent<RectTransform>().position;
        CarneBovina.position = SlotArmazemIngredientes[17].GetComponent<RectTransform>().position;
        CarneSuina.position = SlotArmazemIngredientes[18].GetComponent<RectTransform>().position;
        Mel.position = SlotArmazemIngredientes[19].GetComponent<RectTransform>().position;
        Macarrao.position = SlotArmazemIngredientes[20].GetComponent<RectTransform>().position;
        Ervilha.position = SlotArmazemIngredientes[21].GetComponent<RectTransform>().position;
        Cogumelo.position = SlotArmazemIngredientes[22].GetComponent<RectTransform>().position;
        Beringela.position = SlotArmazemIngredientes[23].GetComponent<RectTransform>().position;
        CarneDeOvelha.position = SlotArmazemIngredientes[24].GetComponent<RectTransform>().position;
        MolhoBranco.position = SlotArmazemIngredientes[25].GetComponent<RectTransform>().position;
        Lula.position = SlotArmazemIngredientes[26].GetComponent<RectTransform>().position;
        Chocolate.position = SlotArmazemIngredientes[27].GetComponent<RectTransform>().position;
        Molho.position = SlotArmazemIngredientes[28].GetComponent<RectTransform>().position;
        Polvo.position = SlotArmazemIngredientes[29].GetComponent<RectTransform>().position;
        PeixeGrande.position = SlotArmazemIngredientes[30].GetComponent<RectTransform>().position;
        Camarao.position = SlotArmazemIngredientes[31].GetComponent<RectTransform>().position;
        OstraBranca.position = SlotArmazemIngredientes[32].GetComponent<RectTransform>().position;
        OstraPreta.position = SlotArmazemIngredientes[33].GetComponent<RectTransform>().position;
        Lagosta.position = SlotArmazemIngredientes[34].GetComponent<RectTransform>().position;
        Carangueijo.position = SlotArmazemIngredientes[35].GetComponent<RectTransform>().position;



        Agua.position = SlotArmazemBebidas[0].GetComponent<RectTransform>().position;
        SucoDeMorango.position = SlotArmazemBebidas[1].GetComponent<RectTransform>().position;
        SucoDeLimao.position = SlotArmazemBebidas[2].GetComponent<RectTransform>().position;
        SucoDeLaranja.position = SlotArmazemBebidas[3].GetComponent<RectTransform>().position;
        ChaGelado.position = SlotArmazemBebidas[4].GetComponent<RectTransform>().position;
        SucoDeCereja.position = SlotArmazemBebidas[5].GetComponent<RectTransform>().position;
        Cafe.position = SlotArmazemBebidas[6].GetComponent<RectTransform>().position;
        LimonadaSuica.position = SlotArmazemBebidas[7].GetComponent<RectTransform>().position;
        Leite.position = SlotArmazemBebidas[8].GetComponent<RectTransform>().position;
        Cappuccino.position = SlotArmazemBebidas[9].GetComponent<RectTransform>().position;
        DrinkDeMorango.position = SlotArmazemBebidas[10].GetComponent<RectTransform>().position;
        Cerveja.position = SlotArmazemBebidas[11].GetComponent<RectTransform>().position;
        ChaQuente.position = SlotArmazemBebidas[12].GetComponent<RectTransform>().position;
        DrinkSuico.position = SlotArmazemBebidas[13].GetComponent<RectTransform>().position;
        DrinkColorido.position = SlotArmazemBebidas[14].GetComponent<RectTransform>().position;
        ChaDeMel.position = SlotArmazemBebidas[15].GetComponent<RectTransform>().position;
        Vinho.position = SlotArmazemBebidas[16].GetComponent<RectTransform>().position;
        DrinkLuxo.position = SlotArmazemBebidas[17].GetComponent<RectTransform>().position;
    }

    public void ResetaTextos()
    {
        TextoSlot1.text = null;
        TextoSlot2.text = null;
        TextoSlot3.text = null;
        TextoSlot4.text = null;
        TextoSlotBebida.text = null;
    }

    public void ResetaSlotsVazio()
    {
        Slot1.GetComponent<SlotVazio>().Vazio = true;
        Slot2.GetComponent<SlotVazio>().Vazio = true;
        Slot3.GetComponent<SlotVazio>().Vazio = true;
        Slot4.GetComponent<SlotVazio>().Vazio = true;
        SlotBebida.GetComponent<SlotVazio>().Vazio = true;
    }
}
