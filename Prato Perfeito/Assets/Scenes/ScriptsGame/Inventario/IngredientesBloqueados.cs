using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.Collections;
using System.Drawing;

public class IngredientesBloqueados : MonoBehaviour
{
    public string NomeIngredienteBloqueado;
    public float ValorDesbloqueioItem = 150;   
    public GameObject ConfirmaDesbloqueio;
    public TextMeshProUGUI TextoDesbloqueio;
    private string TipoItem = "Ingrediente";
    
    // Start is called before the first frame update
    void Start()
    {
        NomeIngredienteBloqueado =  gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AbreConfirmaDesbloqueioItem()
    {
        ConfirmaDesbloqueio.SetActive(true);
        TextoDesbloqueio.text = "DESEJA DESBLOQUEAR <color=yellow>NOVO INGREDIENTE</color> POR: " + "<color=yellow>"+ValorDesbloqueioItem.ToString() + ",00</color> GEMAS ?";
        ConfirmaDesbloqueio.GetComponent<ConfirmaDesbloqueio>().NomedoItemBloqueado = gameObject.name;
        ConfirmaDesbloqueio.GetComponent<ConfirmaDesbloqueio>().ValorDesbloqueioItem = ValorDesbloqueioItem;
        ConfirmaDesbloqueio.GetComponent<ConfirmaDesbloqueio>().ItemBloqueado = gameObject;
        ConfirmaDesbloqueio.GetComponent<ConfirmaDesbloqueio>().TipoItem = TipoItem;
    }

}
