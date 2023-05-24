using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Objekti : MonoBehaviour,
	IBeginDragHandler, IDragHandler, IEndDragHandler {
	public Objekti objektuSkripts;
	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRectTransf;


	void Start ()
	{
		kanvasGrupa= GetComponent<CanvasGroup>();
		velkObjRectTransf= GetComponent<RectTransform>();
	}


	public void OnBeginDrag(PointerEventData eventData)
	{

	}


	public void OnDrag(PointerEventData eventData)
	{

	}

	public void OnEndDrag(PointerEventData eventData)
	{

	}
	

}
