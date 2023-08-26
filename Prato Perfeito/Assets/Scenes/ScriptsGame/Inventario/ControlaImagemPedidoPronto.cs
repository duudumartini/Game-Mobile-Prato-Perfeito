using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ControlaImagemPedidoPronto : MonoBehaviour
{
    public TextMeshProUGUI[] ItensDoPedido;
    private string[] IngredientesAntigo = new string[4];

    public Image ImagemPrincipal;
    public Sprite[] IngredientesProntos;
    private int IngredienteAleatorio;

    void Start()
    {
        IngredientesAntigo[0] = ItensDoPedido[0].text;
        IngredientesAntigo[1] = ItensDoPedido[1].text;
        IngredientesAntigo[2] = ItensDoPedido[2].text;
        IngredientesAntigo[3] = ItensDoPedido[3].text;
    }

    // Update is called once per frame
    void Update()
    {
        
        AtivaImagem();
    }

    private void AtivaImagem()
    {
        if (TodosOsItensVazios() == true)
        {
            ImagemPrincipal.enabled = true;
            AlteraImagemPedido();
        }
        else
        {
            ImagemPrincipal.enabled = false;
            IngredienteAleatorio = Random.Range(0, IngredientesProntos.Length);

        }
    }

    public bool TodosOsItensVazios()
    {
        for(int i = 0; i < ItensDoPedido.Length; i++) 
        {
            if (string.IsNullOrWhiteSpace(ItensDoPedido[i].text))
            {
                // Se algum TextMeshPro estiver vazio, retorna false
                return false;
            }
        }
        return true;
    }

    private void AlteraImagemPedido()
    {        
        for(int i = 0; i < ItensDoPedido.Length; i++)
        {
            if (ItensDoPedido[i].text != IngredientesAntigo[i])
            {
                ImagemPrincipal.sprite = IngredientesProntos[IngredienteAleatorio];
            }
        }
        IngredientesAntigo[0] = ItensDoPedido[0].text;
        IngredientesAntigo[1] = ItensDoPedido[1].text;
        IngredientesAntigo[2] = ItensDoPedido[2].text;
        IngredientesAntigo[3] = ItensDoPedido[3].text;

    }
}
