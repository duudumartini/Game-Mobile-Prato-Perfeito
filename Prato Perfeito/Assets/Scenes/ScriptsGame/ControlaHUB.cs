using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlaHUB : MonoBehaviour
{
    [NonSerialized]public bool VersaoWEB = true;

    public AudioClip GemaPositivo;
    public AudioClip GemaNegativo;
    public AudioClip Click;
    public AudioClip SomBonusPositivo;
    public AudioClip SomBonusNegativo;
    public AudioClip PedidoNoLixoSound;
    public AudioSource AudioSource;

    public TextMeshProUGUI ValorBurgerCoinNaTela;
    public TextMeshProUGUI TempoPedido;
    public TextMeshProUGUI TempoPedidoDaCozinha;
    public TextMeshProUGUI TextoPedidoProntoParaEntrega;
    public TextMeshProUGUI Item1Pedido;
    public TextMeshProUGUI Item2Pedido;
    public TextMeshProUGUI Item3Pedido;
    public TextMeshProUGUI Item4Pedido;
    public TextMeshProUGUI BebidaPedido;
    public TextMeshProUGUI ValorNovo;

    [NonSerialized]public float Gemas = 250f;

    public GameObject PedidoEmProducao;
    public GameObject PedidoEmProducaoCozinha;
    public GameObject CanvasCozinha;
    public GameObject PedidoProntoParaEntrega;
    public GameObject Joystick;
    public GameObject JanelaDePedido;
    public GameObject MenuPause;
    public GameObject BotaoMenuPause;
    public GameObject BotaoCozinha;
    public GameObject BotaoPedido;
    public GameObject BotaoPedidoDaCozinha;
    private GameObject Jogador;
    public GameObject Telhado;
    public GameObject BKJogadorPedidoFora;
    public Slider SliderEstrelas;
    public GameObject Estrelas_;
    public GameObject PedidoNaoEntregue;
    private GameObject PedidosProntosParaEntrega;
    public GameObject DadosIngredientesBebidas;
    public GameObject BKVersaoWEB;
    public GameObject BKEditaPersongem;
    public Button BotaoSaveGame;

    public RectTransform PosicaoDoBurgerCoinNaCozinha;
    public RectTransform RectBurgerCoin;
    public RectTransform PosicaoDoBurgerCoin;

    public float Estrelas = 2.5f;
    private float AnteriorEstrelas;
    public float ValorBonus;

    private bool AceitouVersaoWEB = false;
    private float VersaoWEBCont = 10;
    public Button BotaoOKVersaoWeb;
    public Button PauseButton;
    public TextMeshProUGUI TextBotaoOkVersaoWeb;

    public bool TutorialAtivado = false;
    private bool JaFezTutorial = false;
    void Start()
    {
        Telhado.SetActive(true);
        AnteriorEstrelas = Estrelas;
    }

    // Update is called once per frame
    void Update()
    {
        float GemasNaTela = (float)Math.Round(Gemas,2); //deixa a variavel float com apenas 2 casas decimais.
        Jogador = GameObject.FindGameObjectWithTag("Player");
        PedidoNaoEntregue = GameObject.FindGameObjectWithTag("PedidoNaoEntregue");
        ValorBurgerCoinNaTela.text = GemasNaTela.ToString();        
        AtivaTempoPedido();
        AtivaPedidoPronto();
        AtivaJoystick();
        MenuPauseAtivado();
        CozinhaAtivada();
        ControlaEstrelas();
        ControlaBonus();
        VerificarMudancaDeEstrelas();
        AtivaVersaoWEB();
    }

    void AtivaTempoPedido()
    {
        if (CanvasCozinha.activeSelf == false && PedidoEmProducaoCozinha.activeSelf == true)
        {
            PedidoEmProducao.SetActive(true);
            TempoPedido.text = "Tempo: " + TempoPedidoDaCozinha.text;
        }
        else
        {
            PedidoEmProducao.SetActive(false);
        }
        
    }

    void AtivaPedidoPronto()
    {
        PedidosProntosParaEntrega = GameObject.FindGameObjectWithTag("PedidoNaoEntregue");
        if (PedidosProntosParaEntrega != null && CanvasCozinha.activeSelf == false)
        {
            PedidoProntoParaEntrega.SetActive(true);
        }
        else
        {
            PedidoProntoParaEntrega.SetActive(false);
        }
    }

    void AtivaJoystick()
    {
        if(JanelaDePedido.activeSelf == false)
        {
            Joystick.SetActive(true);
        }
        else
        {
            Joystick.SetActive(false);
        }
    }

    void MenuPauseAtivado()
    {
        if(MenuPause.activeSelf == true) 
        {
            Time.timeScale = 0;
            Jogador.GetComponent<AudioListener>().enabled = false;
            
        }
        else
        {
            Time.timeScale = 1;
            Jogador.GetComponent<AudioListener>().enabled = true;
        }
    }

    void CozinhaAtivada() 
    {
        if(CanvasCozinha.activeSelf == true)
        {
            BotaoMenuPause.SetActive(false);
            BotaoCozinha.SetActive(false);
            BotaoPedido.SetActive(false);
            BotaoPedidoDaCozinha.SetActive(true);
            Joystick.SetActive(false);
            Estrelas_.SetActive(false);
            RectBurgerCoin.position = PosicaoDoBurgerCoinNaCozinha.position;
            
        }
        else
        {
            BotaoMenuPause.SetActive(true);
            BotaoCozinha.SetActive(true);
            BotaoPedido.SetActive(true);
            BotaoPedidoDaCozinha.SetActive(false);
            Joystick.SetActive(true);
            Estrelas_.SetActive(true);
            RectBurgerCoin.position = PosicaoDoBurgerCoin.position;
        }
    }

    public void ValorNovoPositivo(float Valor)
    {
        ValorNovo.alpha = 1;
        ValorNovo.color = Color.green;
        ValorNovo.text = "+" + Valor.ToString();
        AudioSource.clip = GemaPositivo;
        AudioSource.Play();
        LeanTween.moveLocalY(ValorNovo.gameObject, -80f, 1f).setEase(LeanTweenType.easeOutElastic).setOnComplete(MoveValorNovoParaPontoOriginal);
    }

    public void ValorNovoNegativo(float Valor)
    {
        ValorNovo.alpha = 1;
        ValorNovo.color = Color.red;
        ValorNovo.text = "-" + Valor.ToString();
        AudioSource.clip = GemaNegativo;
        AudioSource.Play();
        LeanTween.moveLocalY(ValorNovo.gameObject, -80f, 1f).setEase(LeanTweenType.easeOutElastic).setOnComplete(MoveValorNovoParaPontoOriginal);
    }

    void MoveValorNovoParaPontoOriginal()
    {
        ValorNovo.alpha = 0;
        ValorNovo.GetComponent<Transform>().position = ValorBurgerCoinNaTela.GetComponent<Transform>().position;
    }

    public void ClickSound()
    {
        AudioSource.clip = Click;
        AudioSource.Play();
    }

    public void ControlaEstrelas()
    {
        SliderEstrelas.value = Estrelas;
    }

    public void ReduzEstrelas(float ValorSubtraido)
    {
        Estrelas = Estrelas - ValorSubtraido;
    }

    public void AumentaEstrelas(float ValorSomado)
    {
        Estrelas = Estrelas + ValorSomado;
    }

    private void ControlaBonus()
    {
        if(Estrelas >= 0 && Estrelas < 1)
        {
            ValorBonus = 0.9f;
        }
        if (Estrelas >= 1 && Estrelas < 2)
        {
            ValorBonus = 0.95f;
        }
        if (Estrelas >= 2 && Estrelas < 3)
        {
            ValorBonus = 1;
        }
        if (Estrelas >= 3 && Estrelas < 4)
        {
            ValorBonus = 1.1f;
        }
        if (Estrelas >= 4)
        {
            ValorBonus = 1.2f;
        }
    }

    private void VerificarMudancaDeEstrelas()
    {
        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            AumentaEstrelas(0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            ReduzEstrelas(0.1f);
        }

        if (Estrelas != AnteriorEstrelas)
        {
            //Verifica se aumentou
            if(AnteriorEstrelas >= 0 &&  AnteriorEstrelas < 1 && Estrelas >= 1)
            {
                AudioSource.clip = SomBonusPositivo;
                AudioSource.Play();
            }
            if(AnteriorEstrelas >= 1 && AnteriorEstrelas < 2 && Estrelas >= 2)
            {
                AudioSource.clip = SomBonusPositivo;
                AudioSource.Play();
            }
            if(AnteriorEstrelas >= 2 && AnteriorEstrelas < 3 && Estrelas >= 3)
            {
                AudioSource.clip = SomBonusPositivo;
                AudioSource.Play();
            }
            if (AnteriorEstrelas >= 3 && AnteriorEstrelas < 4 && Estrelas >= 4)
            {
                AudioSource.clip = SomBonusPositivo;
                AudioSource.Play();
            }
            if (AnteriorEstrelas >= 4 && AnteriorEstrelas < 5 && Estrelas >= 5)
            {
                AudioSource.clip = SomBonusPositivo;
                AudioSource.Play();
            }

            //Verifica se diminuiu
            if (AnteriorEstrelas >= 1 && AnteriorEstrelas < 2 && Estrelas < 1)
            {
                AudioSource.clip = SomBonusNegativo;
                AudioSource.Play();
            }
            if (AnteriorEstrelas >= 2 && AnteriorEstrelas < 3 && Estrelas < 2)
            {
                AudioSource.clip = SomBonusNegativo;
                AudioSource.Play();
            }
            if (AnteriorEstrelas >= 3 && AnteriorEstrelas < 4 && Estrelas < 3)
            {
                AudioSource.clip = SomBonusNegativo;
                AudioSource.Play();
            }
            if (AnteriorEstrelas >= 4 && AnteriorEstrelas < 5 && Estrelas < 4)
            {
                AudioSource.clip = SomBonusNegativo;
                AudioSource.Play();
            }
            AnteriorEstrelas = Estrelas;
        }
    }

    public void AtivaBKJogadorPedidoFora()
    {
        BKJogadorPedidoFora.SetActive(true);
    }

    public void JogaPedidoFora()
    {
        Jogador.GetComponent<Animator>().SetLayerWeight(1, 0f);
        AudioSource.clip = PedidoNoLixoSound;
        AudioSource.Play();
        Destroy(PedidoNaoEntregue);
    }

    private void AtivaVersaoWEB()
    {
        if(VersaoWEB == true && AceitouVersaoWEB == false) 
        { 
            BKVersaoWEB.SetActive(true);
            VersaoWEBCont -= Time.deltaTime;
            int NovoVersaoWebCount = Mathf.FloorToInt(VersaoWEBCont);
            TextBotaoOkVersaoWeb.text = NovoVersaoWebCount.ToString();
            PauseButton.interactable = false;
            
            if(NovoVersaoWebCount <= 0)
            {
                BotaoOKVersaoWeb.interactable = true;
                TextBotaoOkVersaoWeb.text = "Ok";
                BotaoSaveGame.interactable = false;
            }
        }
    }

    public void AceitaVersaoWeb()
    {
        AceitouVersaoWEB = true;
        BKVersaoWEB.SetActive(false);
    }

    public void AtivaTutorial()
    {
        TutorialAtivado = true;
        Time.timeScale = 0f;
    }

    public void DestivaTutorial()
    {
        TutorialAtivado = false;
        Time.timeScale = 1f;
        if (JaFezTutorial == false)
        {
            BKEditaPersongem.SetActive(true);
            JaFezTutorial = true;
        }
    }

    public void FechaJogo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
