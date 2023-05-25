using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropSkripts : MonoBehaviour,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Objekti objektuSkripts;
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;


    void Start()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaissVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts= false;
    }


    public void OnDrag(PointerEventData eventData)
    {
        velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaissVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if (objektuSkripts.vaiIstajaVieta == false)
            kanvasGrupa.blocksRaycasts = true;
        else
            objektuSkripts.pedejaissVilktais = null;
        objektuSkripts.vaiIstajaVieta= false;
    }


}
