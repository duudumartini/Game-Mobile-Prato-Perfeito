using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorCliente : MonoBehaviour
{
    private GameObject[] NumeroDeMesas;
    public GameObject Cliente;
    public float Contador;
    public float TempoGeraCliente;
    [SerializeField]private float TempMin;
    [SerializeField]private float TempMax;
    private GameObject[] QuantidadeClientes;
    // Start is called before the first frame update
    void Start()
    {
        NumeroDeMesas = GameObject.FindGameObjectsWithTag("TampaMesa");
        TempoGeraCliente = Random.Range(15, 30);
    }

    // Update is called once per frame
    void Update()
    {
        VerificaCadeirasVazias();
        VerificaQuantidadeDeClientesNoRestaurante();
    }

    private void VerificaCadeirasVazias()
    {        
        Contador = Contador + Time.deltaTime;
        if (Contador >= TempoGeraCliente)
        {
            for (int i = 0; i < NumeroDeMesas.Length; i++)
            {
                if (NumeroDeMesas[i].GetComponent<Mesa>().MesaOcupada == false)
                {
                    TempoGeraCliente = Random.Range(TempMin, TempMax);
                    GeraCliente();
                    break;
                }

            }
        Contador = 0;
        }
    }

    private void GeraCliente()
    {
        Instantiate(Cliente, transform.position, Quaternion.identity);
    }

    private void VerificaQuantidadeDeClientesNoRestaurante()
    {
        QuantidadeClientes = GameObject.FindGameObjectsWithTag("Cliente");
        if(QuantidadeClientes.Length <= 2 ) 
        {
            TempMin = 10;
            TempMax = 30;
        }
        else if(QuantidadeClientes.Length > 2 && QuantidadeClientes.Length <= 4)
        {
            TempMin = 30;
            TempMax = 60;
        }
        else if(QuantidadeClientes.Length > 4)
        {
            TempMin = 60;
            TempMax = 90;
        }
    }
}
