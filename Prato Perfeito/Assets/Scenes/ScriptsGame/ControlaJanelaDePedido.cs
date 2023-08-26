using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlaJanelaDePedido : MonoBehaviour
{
    public GameObject Cozinha;
    public Button BotaoPedidos;
    public GameObject JanelaDePedido;

    public GameObject JanelaPedidoMesa1;
    public GameObject JanelaPedidoMesa2;
    public GameObject JanelaPedidoMesa3;
    public GameObject JanelaPedidoMesa4;
    public GameObject JanelaPedidoMesa5;
    public GameObject JanelaPedidoMesa6;
    public GameObject JanelaPedidoMesa7;

    public Button BotaoMesa1;
    public Button BotaoMesa2;
    public Button BotaoMesa3;
    public Button BotaoMesa4;
    public Button BotaoMesa5;
    public Button BotaoMesa6;
    public Button BotaoMesa7;

    public TextMeshProUGUI Mesa1Bebida;
    public TextMeshProUGUI Mesa1Ingrediente1;
    public TextMeshProUGUI Mesa1Ingrediente2;
    public TextMeshProUGUI Mesa1Ingrediente3;
    public TextMeshProUGUI Mesa1Ingrediente4;

    public TextMeshProUGUI Mesa2Bebida;
    public TextMeshProUGUI Mesa2Ingrediente1;
    public TextMeshProUGUI Mesa2Ingrediente2;
    public TextMeshProUGUI Mesa2Ingrediente3;
    public TextMeshProUGUI Mesa2Ingrediente4;

    public TextMeshProUGUI Mesa3Bebida;
    public TextMeshProUGUI Mesa3Ingrediente1;
    public TextMeshProUGUI Mesa3Ingrediente2;
    public TextMeshProUGUI Mesa3Ingrediente3;
    public TextMeshProUGUI Mesa3Ingrediente4;

    public TextMeshProUGUI Mesa4Bebida;
    public TextMeshProUGUI Mesa4Ingrediente1;
    public TextMeshProUGUI Mesa4Ingrediente2;
    public TextMeshProUGUI Mesa4Ingrediente3;
    public TextMeshProUGUI Mesa4Ingrediente4;

    public TextMeshProUGUI Mesa5Bebida;
    public TextMeshProUGUI Mesa5Ingrediente1;
    public TextMeshProUGUI Mesa5Ingrediente2;
    public TextMeshProUGUI Mesa5Ingrediente3;
    public TextMeshProUGUI Mesa5Ingrediente4;

    public TextMeshProUGUI Mesa6Bebida;
    public TextMeshProUGUI Mesa6Ingrediente1;
    public TextMeshProUGUI Mesa6Ingrediente2;
    public TextMeshProUGUI Mesa6Ingrediente3;
    public TextMeshProUGUI Mesa6Ingrediente4;

    public TextMeshProUGUI Mesa7Bebida;
    public TextMeshProUGUI Mesa7Ingrediente1;
    public TextMeshProUGUI Mesa7Ingrediente2;
    public TextMeshProUGUI Mesa7Ingrediente3;
    public TextMeshProUGUI Mesa7Ingrediente4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HabilitaBotoesDasMesas();
    }

    
    public void AbreJanelaPedido()
    {   
            JanelaDePedido.SetActive(!JanelaDePedido.activeSelf);
            FechaJanelaDePedidoMesas();
    }

    void FechaJanelaDePedidoMesas()
    {
        JanelaPedidoMesa1.SetActive(false);
        JanelaPedidoMesa2.SetActive(false);
        JanelaPedidoMesa3.SetActive(false);
        JanelaPedidoMesa4.SetActive(false);
        JanelaPedidoMesa5.SetActive(false);
        JanelaPedidoMesa6.SetActive(false);
        JanelaPedidoMesa7.SetActive(false);
    }

    public void HabilitaJanelaPedidoMesa1()
    {
        JanelaPedidoMesa1.SetActive(!JanelaPedidoMesa1.activeSelf);
        JanelaPedidoMesa2.SetActive(false);
        JanelaPedidoMesa3.SetActive(false);
        JanelaPedidoMesa4.SetActive(false);
        JanelaPedidoMesa5.SetActive(false);
        JanelaPedidoMesa6.SetActive(false);
        JanelaPedidoMesa7.SetActive(false);
    }

    public void HabilitaJanelaPedidoMesa2()
    {
        JanelaPedidoMesa1.SetActive(false);
        JanelaPedidoMesa2.SetActive(!JanelaPedidoMesa2.activeSelf);
        JanelaPedidoMesa3.SetActive(false);
        JanelaPedidoMesa4.SetActive(false);
        JanelaPedidoMesa5.SetActive(false);
        JanelaPedidoMesa6.SetActive(false);
        JanelaPedidoMesa7.SetActive(false);
    }

    public void HabilitaJanelaPedidoMesa3()
    {
        JanelaPedidoMesa1.SetActive(false);
        JanelaPedidoMesa2.SetActive(false);
        JanelaPedidoMesa3.SetActive(!JanelaPedidoMesa3.activeSelf);
        JanelaPedidoMesa4.SetActive(false);
        JanelaPedidoMesa5.SetActive(false);
        JanelaPedidoMesa6.SetActive(false);
        JanelaPedidoMesa7.SetActive(false);
    }

    public void HabilitaJanelaPedidoMesa4()
    {
        JanelaPedidoMesa1.SetActive(false);
        JanelaPedidoMesa2.SetActive(false);
        JanelaPedidoMesa3.SetActive(false);
        JanelaPedidoMesa4.SetActive(!JanelaPedidoMesa4.activeSelf);
        JanelaPedidoMesa5.SetActive(false);
        JanelaPedidoMesa6.SetActive(false);
        JanelaPedidoMesa7.SetActive(false);
    }

    public void HabilitaJanelaPedidoMesa5()
    {
        JanelaPedidoMesa1.SetActive(false);
        JanelaPedidoMesa2.SetActive(false);
        JanelaPedidoMesa3.SetActive(false);
        JanelaPedidoMesa4.SetActive(false);
        JanelaPedidoMesa5.SetActive(!JanelaPedidoMesa5.activeSelf);
        JanelaPedidoMesa6.SetActive(false);
        JanelaPedidoMesa7.SetActive(false);
    }

    public void HabilitaJanelaPedidoMesa6()
    {
        JanelaPedidoMesa1.SetActive(false);
        JanelaPedidoMesa2.SetActive(false);
        JanelaPedidoMesa3.SetActive(false);
        JanelaPedidoMesa4.SetActive(false);
        JanelaPedidoMesa5.SetActive(false);
        JanelaPedidoMesa6.SetActive(!JanelaPedidoMesa6.activeSelf);
        JanelaPedidoMesa7.SetActive(false);
    }

    public void HabilitaJanelaPedidoMesa7()
    {
        JanelaPedidoMesa1.SetActive(false);
        JanelaPedidoMesa2.SetActive(false);
        JanelaPedidoMesa3.SetActive(false);
        JanelaPedidoMesa4.SetActive(false);
        JanelaPedidoMesa5.SetActive(false);
        JanelaPedidoMesa6.SetActive(false);
        JanelaPedidoMesa7.SetActive(!JanelaPedidoMesa7.activeSelf);
    }

    void HabilitaBotoesDasMesas()
    {
       if(Mesa1Bebida.text == string.Empty)
        {
            BotaoMesa1.interactable = false;
        }
       else
        {
            BotaoMesa1.interactable = true;
        }

        if (Mesa2Bebida.text == string.Empty)
        {
            BotaoMesa2.interactable = false;
        }
        else
        {
            BotaoMesa2.interactable = true;
        }

        if (Mesa3Bebida.text == string.Empty)
        {
            BotaoMesa3.interactable = false;
        }
        else
        {
            BotaoMesa3.interactable = true;
        }

        if (Mesa4Bebida.text == string.Empty)
        {
            BotaoMesa4.interactable = false;
        }
        else
        {
            BotaoMesa4.interactable = true;
        }

        if (Mesa5Bebida.text == string.Empty)
        {
            BotaoMesa5.interactable = false;
        }
        else
        {
            BotaoMesa5.interactable = true;
        }

        if (Mesa6Bebida.text == string.Empty)
        {
            BotaoMesa6.interactable = false;
        }
        else
        {
            BotaoMesa6.interactable = true;
        }

        if (Mesa7Bebida.text == string.Empty)
        {
            BotaoMesa7.interactable = false;
        }
        else
        {
            BotaoMesa7.interactable = true;
        }
    }
}
