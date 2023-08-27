using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaMenuInicial : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NovoJogo()
    {
        SceneManager.LoadScene("Game");
    }

    public void ContinuarJogo()
    {

    }
}
