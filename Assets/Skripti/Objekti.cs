using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Objekti : MonoBehaviour
{
	public GameObject atkritumuMasina;
    public GameObject atraPalidziba;
    public GameObject autobuss;
    public GameObject traktors5;
    public GameObject traktors1;
    public GameObject b2;
    public GameObject policija;
    public GameObject eskavators;
    public GameObject e61;
    public GameObject cementamasina;
    public GameObject e46;
    public GameObject ugunsdzeseji;

    [HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 trakt5Koord;
    [HideInInspector]
    public Vector2 trakt1Koord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 policKoord;
    [HideInInspector]
    public Vector2 eskavatKoord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 cementKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 ugunsdzesKoord;


    public Canvas kanva;
	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaissVilktais = null;

	void Start() {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atraPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        trakt5Koord = traktors5.GetComponent<RectTransform>().localPosition;
        trakt1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        policKoord = policija.GetComponent<RectTransform>().localPosition;
        eskavatKoord = eskavators.GetComponent<RectTransform>().localPosition;
        e61Koord = e61.GetComponent<RectTransform>().localPosition;
        cementKoord = cementamasina.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        ugunsdzesKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;

    }
}
