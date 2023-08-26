using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmaDesbloqueio : MonoBehaviour
{
    [NonSerialized] public string NomedoItemBloqueado;
    [NonSerialized] public float ValorDesbloqueioItem;
    [NonSerialized] public GameObject ItemBloqueado;
    [NonSerialized] public string TipoItem;
    public GameObject ControlaHUB;
    public GameObject ControlaCozinha;
    public GameObject DadosIngredientesBebidas;
    public GameObject VoceNaoPossuiGemas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void Desbloquia()
    {
        if (ValorDesbloqueioItem <= ControlaHUB.GetComponent<ControlaHUB>().Gemas)
        {
            //Adiciona o nome do Item a lista;
            if(TipoItem == "Ingrediente")
            {
                int NovoTamanhoArray = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().Ingredientes.Length + 1;
                System.Array.Resize(ref DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().Ingredientes, NovoTamanhoArray);
                DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().Ingredientes[NovoTamanhoArray - 1] = NomedoItemBloqueado;
                ControlaHUB.GetComponent<ControlaHUB>().Gemas = ControlaHUB.GetComponent<ControlaHUB>().Gemas - ValorDesbloqueioItem;
                ControlaHUB.GetComponent<ControlaHUB>().ValorNovoNegativo(ValorDesbloqueioItem);
                gameObject.SetActive(false);
                Destroy(ItemBloqueado);
            }
            else if(TipoItem == "Bebida")
            {
                int NovoTamanhoArray = DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().Bebidas.Length + 1;
                System.Array.Resize(ref DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().Bebidas, NovoTamanhoArray);
                DadosIngredientesBebidas.GetComponent<DadosIngredientesBebidas>().Bebidas[NovoTamanhoArray - 1] = NomedoItemBloqueado;
                ControlaHUB.GetComponent<ControlaHUB>().Gemas = ControlaHUB.GetComponent<ControlaHUB>().Gemas - ValorDesbloqueioItem;
                ControlaHUB.GetComponent<ControlaHUB>().ValorNovoNegativo(ValorDesbloqueioItem);
                gameObject.SetActive(false);
                Destroy(ItemBloqueado);
            }
            
        }
        else
        {
            gameObject.SetActive(false);
            VoceNaoPossuiGemas.SetActive(true);
            ControlaCozinha.GetComponent<ControlaCozinha>().ErrorSound();
        }
    }
}
