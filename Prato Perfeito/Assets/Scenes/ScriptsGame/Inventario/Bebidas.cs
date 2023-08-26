using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

//SCRIPT ANEXADO NAS BEBIDAS NA JANELA DA COZINHA
public class Bebidas : MonoBehaviour, IPointerDownHandler, IEndDragHandler, IBeginDragHandler, IDragHandler, IDropHandler
{
    
    private RectTransform rectTransform;
    private CanvasGroup _canvasGroup;
    public string NomeDoIngrediente;
    public GameObject Slot1;
    public TextMeshProUGUI TextoSlot1;
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


        //Esvazia o texto do slot
        if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position
            && IngredienteArrastado.GetComponent<RectTransform>().name == TextoSlot1.text)
        {
            TextoSlot1.text = null;
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {        
        _canvasGroup.alpha = 1f;
        _canvasGroup.blocksRaycasts = true;
        GameObject IngredienteArrastado = eventData.pointerDrag;

        //Muda nome do slot dentro da montagem da bebida
        if (IngredienteArrastado.GetComponent<RectTransform>().position == Slot1.GetComponent<RectTransform>().position)
        {
            TextoSlot1.text = IngredienteArrastado.name;
        }

        //Retorna Objeto ao ponto original caso não seja solto no slot da bebida.
        if (IngredienteArrastado.name == "Agua")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Suco de Morango")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Suco de Limao")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Suco de Laranja")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Cha Gelado")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Suco de Cereja")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Cafe")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Limonada Suica")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Leite")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Cappuccino")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Drink de Morango")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Cerveja")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Cha Quente")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Drink Suico")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Drink Colorido")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }
        if (IngredienteArrastado.name == "Cha de Mel")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Vinho")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
            {
                IngredienteArrastado.GetComponent<RectTransform>().position = SlotArmazem.GetComponent<RectTransform>().position;
            }
        }

        if (IngredienteArrastado.name == "Drink Luxo")
        {
            if (IngredienteArrastado.GetComponent<RectTransform>().position != Slot1.GetComponent<RectTransform>().position)
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
