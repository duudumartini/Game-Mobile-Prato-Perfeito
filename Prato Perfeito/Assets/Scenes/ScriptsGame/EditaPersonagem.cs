using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EditaPersonagem : MonoBehaviour
{
    public Slider SliderRotacaoJogador;
    public GameObject EditaPersonagem_;
    private GameObject Jogador;
    private Vector3 PosicaoJogador;
    private Quaternion RotacaoJogador;
    private float AnguloYRotacaoJogador;
    private bool EscolheuDanca = false;
    public GameObject[] Cabelo;
    public GameObject[] Franjas;
    public GameObject[] Camisa;
    public GameObject[] Calca;
    public GameObject[] Tenis;
    public GameObject[] Conjuntos;
    private int Camisa_ = 0;
    private int Franjas_ = 0;
    private int Cabelo_ = 0;
    private int Calca_ = 0;
    private int Tenis_ = 0;
    private int Conjuntos_ = 0;
    private int danca = 1;

    float RPele;
    float GPele;
    float BPele;

    float RCabelo = 255 / 255.0f;
    float GCabelo = 220 / 255.0f;
    float BCabelo = 177 / 255.0f;

    float RFranja = 255 / 255.0f;
    float GFranja = 220 / 255.0f;
    float BFranja = 177 / 255.0f;

    float RCamisa = 255 / 255.0f;
    float GCamisa = 220 / 255.0f;
    float BCamisa = 177 / 255.0f;
    float RCamisa2 = 255 / 255.0f;
    float GCamisa2 = 220 / 255.0f;
    float BCamisa2 = 177 / 255.0f;

    float RCalca = 255 / 255.0f;
    float GCalca = 220 / 255.0f;
    float BCalca = 177 / 255.0f;

    float RTenis = 255 / 255.0f;
    float GTenis = 220 / 255.0f;
    float BTenis = 177 / 255.0f;
    float RTenis2 = 255 / 255.0f;
    float GTenis2 = 220 / 255.0f;
    float BTenis2 = 177 / 255.0f;

    float RConjuntos = 255 / 255.0f;
    float GConjuntos = 220 / 255.0f;
    float BConjuntos = 177 / 255.0f;
    float RConjuntos2 = 255 / 255.0f;
    float GConjuntos2 = 220 / 255.0f;
    float BConjuntos2 = 177 / 255.0f;

    public Material[] MaterialPele;
    public Material[] MaterialCabelo;
    public Material[] MaterialFranjas;
    public Material[] MaterialCamisa;
    public Material[] MaterialCalca;
    public Material[] MaterialTenis;
    public Material[] MaterialConjuntos;
    void Start()
    {
        AlteraCorPeleR(226);
        AlteraCorPeleG(181);
        AlteraCorPeleB(141);
    }

    // Update is called once per frame
    void Update()
    {
        Jogador = GameObject.FindGameObjectWithTag("Player");
        PosicaoJogador = Jogador.transform.position;
        RotacaoJogador = Jogador.transform.rotation;
        RotacaoAtravesSlider();
        DefineEstilo();
        AlteraCoresMaterial();
    }


    private void RotacaoAtravesSlider()
    {
        if(EditaPersonagem_.activeSelf == true)
        {
            LeanTween.rotateY(Jogador, SliderRotacaoJogador.value, 0);
            Dancar();
            Jogador.GetComponent<Animator>().SetInteger("Danca", danca);
        }
        else
        {
            EscolheuDanca = false;
            AnguloYRotacaoJogador = Jogador.GetComponent<Transform>().rotation.eulerAngles.y;
            SliderRotacaoJogador.value = AnguloYRotacaoJogador;
            Jogador.GetComponent<Animator>().SetInteger("Danca", 0);
        }   
    }

    private void DefineEstilo()
    {
        for(int i = 0; i < Cabelo.Length; i++)
        {
            if(i == Cabelo_)
            {
                Cabelo[i].SetActive(true);
            }
            else
            {
                Cabelo[i].SetActive(false);
            }
        }

        for (int i = 0; i < Camisa.Length; i++)
        {
            if (i == Camisa_)
            {
                Camisa[i].SetActive(true);
            }
            else
            {
                Camisa[i].SetActive(false);
            }
        }

        for (int i = 0; i < Franjas.Length; i++)
        {
            if (i == Franjas_)
            {
                Franjas[i].SetActive(true);
            }
            else
            {
                Franjas[i].SetActive(false);
            }
        }

        for (int i = 0; i < Calca.Length; i++)
        {
            if (i == Calca_)
            {
                Calca[i].SetActive(true);
            }
            else
            {
                Calca[i].SetActive(false);
            }
        }
        for (int i = 0; i < Tenis.Length; i++)
        {
            if (i == Tenis_)
            {
                Tenis[i].SetActive(true);
            }
            else
            {
                Tenis[i].SetActive(false);
            }
        }

        for (int i = 0; i < Conjuntos.Length; i++)
        {
            if (i == Conjuntos_)
            {
                Conjuntos[i].SetActive(true);
            }
            else
            {
                Conjuntos[i].SetActive(false);
            }
        }
    }

    public void EstiloAleatorio()
    {
        Cabelo_ = Random.Range(-1, Cabelo.Length);
        Franjas_ = Random.Range(-1, Franjas.Length);
        Calca_ = Random.Range(0, Calca.Length);
        Camisa_ = Random.Range(0, Camisa.Length);
        Tenis_ = Random.Range(0, Tenis.Length);
    }

    private void Dancar()
    {
        if(EscolheuDanca == false)
        {
            danca = Random.Range(1, 8);
            EscolheuDanca = true;
        }
    }

    public void AlteraCamisa(int i)
    {
        Camisa_ = i;
        Conjuntos_ = -1;
        if (Calca_ == -1)
        {
            Calca_ = 1;
        }
    }

    public void AlteraCabelo(int i)
    {
        Cabelo_ = i;
    }

    public void AlteraFranja(int i)
    {
        Franjas_ = i;
    }

    public void AlteraCalca(int i)
    {
        Calca_ = i;
        Conjuntos_ = -1;
        if (Camisa_ == -1)
        {
            Camisa_ = 1;
        }
    }

    public void AlteraTenis(int i)
    {
        Tenis_ = i;
    }

    public void AlteraConjunto(int i)
    {
        Conjuntos_ = i;
        Camisa_ = -1;
        Calca_ = -1;
    }
    
    private void AlteraCoresMaterial()
    {
        Color CorPele = new Color(RPele / 255, GPele / 255, BPele / 255);
        Color CorCabelo = new Color(RCabelo/255, GCabelo/255, BCabelo/255);
        Color CorFranja = new Color(RFranja/ 255, GFranja/ 255, BFranja / 255);
        Color CorCamisa = new Color(RCamisa / 255, GCamisa / 255, BCamisa / 255);
        Color CorCamisa2 = new Color(RCamisa2 / 255, GCamisa2 / 255, BCamisa2 / 255);
        Color CorCalca = new Color(RCalca / 255, GCalca / 255, BCalca / 255);
        Color CorTenis = new Color(RTenis/ 255, GTenis / 255, BTenis / 255);
        Color CorTenis2 = new Color(RTenis2 / 255, GTenis2 / 255, BTenis2 / 255);
        Color CorConjunto = new Color(RConjuntos / 255, GConjuntos / 255, BConjuntos / 255);
        Color CorConjunto2 = new Color(RConjuntos2 / 255, GConjuntos2 / 255, BConjuntos2 / 255);

        for (int i = 0; i < MaterialCabelo.Length; i++) 
        {
            MaterialCabelo[i].SetColor("_Color_A_2", CorCabelo);
        }

        for (int i = 0; i < MaterialFranjas.Length; i++)
        {
            MaterialFranjas[i].SetColor("_Color_A_2", CorFranja);
        }

        for (int i = 0; i < MaterialCamisa.Length; i++)
        {
            MaterialCamisa[i].SetColor("_Color_A_2", CorCamisa);
            MaterialCamisa[i].SetColor("_Color_B_2", CorCamisa2);
        }

        for (int i = 0; i < MaterialCalca.Length; i++)
        {
            MaterialCalca[i].SetColor("_Color_A_2", CorCalca);
            MaterialCalca[i].SetColor("_Color_B_1", CorCalca);
        }

        for (int i = 0; i < MaterialTenis.Length; i++)
        {
            MaterialTenis[i].SetColor("_Color_A_2", CorTenis);
            MaterialTenis[i].SetColor("_Color_B_2", CorTenis2);
        }

        for (int i = 0; i < MaterialConjuntos.Length; i++)
        {
            MaterialConjuntos[i].SetColor("_Color_A_2", CorConjunto);
            MaterialConjuntos[i].SetColor("_Color_B_2", CorConjunto2);
        }

        for (int i = 0; i < MaterialPele.Length; i++)
        {
            MaterialPele[i].SetColor("_Color_A_2", CorPele);
        }

    }

    public void AlteraCorCabeloR(float R)
    {
        RCabelo = R;
    }

    public void AlteraCorCabeloG(float G)
    {
        GCabelo = G;
    }

    public void AlteraCorCabeloB(float B)
    {
        BCabelo = B;
    }

    public void AlteraCorCamisaR(float R)
    {
        RCamisa = R;
    }

    public void AlteraCorCamisaG(float G)
    {
        GCamisa = G;
    }

    public void AlteraCorCamisaB(float B)
    {
        BCamisa = B;
    }

    public void AlteraCorCamisa2R(float R)
    {
        RCamisa2 = R;
    }

    public void AlteraCorCamisa2G(float G)
    {
        GCamisa2 = G;
    }

    public void AlteraCorCamisa2B(float B)
    {
        BCamisa2 = B;
    }

    public void AlteraCorCalcaR(float R)
    {
        RCalca = R;
    }

    public void AlteraCorCalcaG(float G)
    {
        GCalca = G;
    }

    public void AlteraCorCalcaB(float B)
    {
        BCalca = B;
    }

    public void AlteraCorTenisR(float R)
    {
        RTenis = R;
    }

    public void AlteraCorTenisG(float G)
    {
        GTenis = G;
    }

    public void AlteraCorTenisB(float B)
    {
        BTenis = B;
    }

    public void AlteraCorTenis2R(float R)
    {
        RTenis2 = R;
    }

    public void AlteraCorTenis2G(float G)
    {
        GTenis2 = G;
    }

    public void AlteraCorTenis2B(float B)
    {
        BTenis2 = B;
    }

    public void AlteraCorFranjasR(float R)
    {
        RFranja = R;
    }

    public void AlteraCorFranjasG(float G)
    {
        GFranja= G;
    }

    public void AlteraCorFranjasB(float B)
    {
        BFranja = B;
    }

    public void AlteraCorConjuntosR(float R)
    {
        RConjuntos = R;
    }

    public void AlteraCorConjuntosG(float G)
    {
        GConjuntos = G;
    }

    public void AlteraCorConjuntosB(float B)
    {
        BConjuntos = B;
    }

    public void AlteraCorConjuntos2R(float R)
    {
        RConjuntos2 = R;
    }

    public void AlteraCorConjuntos2G(float G)
    {
        GConjuntos2 = G;
    }

    public void AlteraCorConjuntos2B(float B)
    {
        BConjuntos2 = B;
    }

    public void AlteraCorPeleR(float R)
    {
        RPele = R;
    }

    public void AlteraCorPeleG(float G)
    {
        GPele = G;
    }

    public void AlteraCorPeleB(float B)
    {
        BPele = B;
    }
}


