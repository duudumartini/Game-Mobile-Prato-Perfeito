using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotVazio : MonoBehaviour, IDropHandler
{

    public bool Vazio = true;



    private void Start()
    {
      
    }

    private void Update()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {       
        if (Vazio == true)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Vazio = false;
        }
           
    }

   
}
