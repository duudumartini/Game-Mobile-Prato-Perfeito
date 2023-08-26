using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPedido : MonoBehaviour
{
    public List<string> PedidoAtualIngrediente;
    public List<string> PedidoAtualBebidas;
    private string[] Ingredientes;
    private string[] Bebidas;
    // Start is called before the first frame update
    void Start()
    {
        PedidoAtualIngrediente = new List<string>();
        PedidoAtualBebidas = new List<string>();       
        
        //Pega os ingredientes disponiveis.
        Ingredientes = new string[GameObject.FindGameObjectWithTag("DadosIngredientesBebidas").GetComponent<DadosIngredientesBebidas>().Ingredientes.Length];
        for(int i = 0; i< GameObject.FindGameObjectWithTag("DadosIngredientesBebidas").GetComponent<DadosIngredientesBebidas>().Ingredientes.Length; i++)
        {
            Ingredientes[i] = GameObject.FindGameObjectWithTag("DadosIngredientesBebidas").GetComponent<DadosIngredientesBebidas>().Ingredientes[i];
        }

        Bebidas = new string[GameObject.FindGameObjectWithTag("DadosIngredientesBebidas").GetComponent<DadosIngredientesBebidas>().Bebidas.Length];
        for (int i = 0; i < GameObject.FindGameObjectWithTag("DadosIngredientesBebidas").GetComponent<DadosIngredientesBebidas>().Bebidas.Length; i++)
        {
            Bebidas[i] = GameObject.FindGameObjectWithTag("DadosIngredientesBebidas").GetComponent<DadosIngredientesBebidas>().Bebidas[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        PedidoDoCliente();
    }

    void PedidoDoCliente()
    {
        if(PedidoAtualIngrediente.Count < 4)
        {
            int IngredienteAdicionar = Random.Range(0, Ingredientes.Length);
            if (!PedidoAtualIngrediente.Contains(Ingredientes[IngredienteAdicionar]))
            {
                PedidoAtualIngrediente.Add(Ingredientes[IngredienteAdicionar]);
            }
        }
        
        if(PedidoAtualBebidas.Count < 1)
        {
            int BebidaAdicionar = Random.Range(0, Bebidas.Length);
            if (!PedidoAtualBebidas.Contains(Bebidas[BebidaAdicionar]))
            {
                PedidoAtualBebidas.Add(Bebidas[BebidaAdicionar]);
            }
        }
        
    }
    
    
}
