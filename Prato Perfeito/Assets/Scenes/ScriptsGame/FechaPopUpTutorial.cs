using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FechaPopUpTutorial : MonoBehaviour
{
    void Start()
    {
        GetComponent<Transform>().localScale = Vector3.zero;
        LeanTween.scale(gameObject, Vector3.one, 0.5f).setEase(LeanTweenType.easeOutElastic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FechaPopUp()
    {
        LeanTween.scale(gameObject, Vector3.zero, 0f).setOnComplete(Desliga);
        //LeanTween.rotateZ(gameObject, -1077f, 0.5f);
    }

    public void Desliga()
    {
        gameObject.SetActive(false);
    }
}
