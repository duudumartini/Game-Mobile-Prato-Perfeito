using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlaMenuInicial : MonoBehaviour
{
    public GameObject BkLoading;
    public Image ImgLoading;
    private float AlphaLoading = 0;
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

    public void IniciaLoading()
    {
        BkLoading.SetActive(true);
        LeanTween.value(ImgLoading.gameObject, 0, 1, 1).setOnUpdate(AtualizaAlpha).setOnComplete(NovoJogo);
    }

    private void AtualizaAlpha(float Alpha)
    {
        Color NovaCor = ImgLoading.color;
        NovaCor.a = Alpha;
        ImgLoading.color = NovaCor;
    }
}
