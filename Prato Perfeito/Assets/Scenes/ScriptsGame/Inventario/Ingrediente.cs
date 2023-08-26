using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

//SCRIPT ANEXADO AOS INGREDIENTES NA JANELA DA COZINHA.

public class Ingrediente : MonoBehaviour, IPointerDownHandler, IEndDragHandler, IBeginDragHandler, IDragHandler, IDropHandler
{

    private RectTransform rectTransform;
    private CanvasGroup _canvasGroup;
    public string NomeDoIngrediente;
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public TextMeshProUGUI TextoSlot1;
    public TextMeshProUGUI TextoSlot2;
    public TextMeshProUGUI TextoSlot3;
    public TextMeshProUGUI TextoSlot4;
    public GameObject SlotArmazem;
    [SerializeField] private Vector3 CordenadaIngrediente;
  
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        NomeDoIngrediente = GetComponent<Rigidbody>().name;
  
    }

    private void Update()
    {
        CordenadaIngrediente = rectTransform.position;
    }
   
    public void OnPointerDown(PointerEventData eventData)
    {
      
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        GameObject IngredienteArrastado = eventData.pointerDrag;
        _canvasGroup.alpha = 0.6f;
        _canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        GameObject IngredienteArrastado = eventData.pointerDrag;

        //Arrasta ingrediente
        rectTransform.anchoredPosition += eventData.delta;

        //Libera Slot para Vazio novamente.

        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position 
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot1.text)
        {
            Slot1.GetComponent<SlotVazio>().Vazio = true;
        }

        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot2.text)
        {
            Slot2.GetComponent<SlotVazio>().Vazio = true;
        }

        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot3.text)
        {
            Slot3.GetComponent<SlotVazio>().Vazio = true;
        }

        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot4.text)
        {
            Slot4.GetComponent<SlotVazio>().Vazio = true;
        }


        //Esvazia o texto do slot
        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot1.text)
        {
            TextoSlot1.text = null;
        }
        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot2.text)
        {
            TextoSlot2.text = null;
        }
        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot3.text)
        {
            TextoSlot3.text = null;
        }
        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot4.text)
        {
            TextoSlot4.text = null;
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {        
        _canvasGroup.alpha = 1f;
        _canvasGroup.blocksRaycasts = true;
        GameObject IngredienteArrastado = eventData.pointerDrag;

        //Muda nome do slot dentro da montagem
        if (IngredienteArrastado.GetComponent<RectTransform>().position == Slot1.GetComponent<RectTransform>().position)
        {
            TextoSlot1.text = IngredienteArrastado.name;
        }
        if (IngredienteArrastado.GetComponent<RectTransform>().position == Slot2.GetComponent<RectTransform>().position)
        {
            TextoSlot2.text = IngredienteArrastado.name;
        }
        if (IngredienteArrastado.GetComponent<RectTransform>().position == Slot3.GetComponent<RectTransform>().position)
        {
            TextoSlot3.text = IngredienteArrastado.name;
        }
        if (IngredienteArrastado.GetComponent<RectTransform>().position == Slot4.GetComponent<RectTransform>().position)
        {
            TextoSlot4.text = IngredienteArrastado.name;
        }

        //Retorna Objeto ao ponto original
        if (IngredienteArrastado.name == "Queijo")
        {   
            if(IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Alho")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Cebola")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Tomate")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Alface")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Pimenta")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }
        
        if (IngredienteArrastado.name == "Pao")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }
        
        if (IngredienteArrastado.name == "Cenoura")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Frango")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Ovo")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Peixe Pequeno")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Milho")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Atum")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Abobora")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Limao")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Bacon")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Manteiga")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Carne Bovina")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Carne Suina")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Mel")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Macarrao")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Ervilha")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Cogumelo")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Beringela")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Carne Ovelha")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Molho Branco")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Lula")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Chocolate")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Molho")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Polvo")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Peixe Grande")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Camarao")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Ostra Branca")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Ostra Preta")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Lagosta")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Carangueijo")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot2.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot3.GetComponent<RectTransform>().position
                && IngredienteArrastado.GetComponent<RectTransform>().position != Slot4.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        // Implementação vazia, apenas para atender aos requisitos da interface IDropHandler
    }

}
