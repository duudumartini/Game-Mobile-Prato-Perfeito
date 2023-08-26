using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliqueMouse : MonoBehaviour
{
    private Vector3 destino;
    private Vector3 PontoOriginal;
    private float velocidade = 10;
    private float contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        PontoOriginal = new Vector3(transform.position.x, 0.5f, transform.position.z);
        destino = new Vector3(transform.position.x, -0.6f, transform.position.z);
        transform.position = PontoOriginal;
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        Vector3 novaPosicao = Vector3.Lerp(transform.position, destino, velocidade * Time.deltaTime);
        transform.position = novaPosicao;
        if(contador >=1)
        {
            Destroy(gameObject);
        }
    }
}
