using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVietaq : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti obejktuSkripts;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnDrop(PointerEventData eventData)
	{
		if(eventData.pointerDrag!= null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
		velkObjZRot=eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z; 

				rotacijasStarpiba=Mathf.Abs(velkObjZRot- vietasZRot);

                velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
				
				vietasIzm=GetComponent<RectTransform>().localScale;

				xIzmeruStarp=Mathf.Abs(velkObjIzm.x-vietasIzm.x);
				yIzmeruStarp=Mathf.Abs(velkObjIzm.y-vietasIzm.y);

				if ((rotacijasStarpiba<=10 || 
					(rotacijasStarpiba>= 354&& rotacijasStarpiba<=360))
					&& (xIzmeruStarp<=0.2 && yIzmeruStarp <= 0.2)){
					obejktuSkripts.vaiIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=
						GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation=
						GetComponent<RectTransform>().localRotation;
				
				eventData.pointerDrag.GetComponent<RectTransform>().localScale=
						GetComponent<RectTransform>().localScale;

                    obejktuSkripts.masinuSk++;
                    obejktuSkripts.vaiVisasMasinasSaliktas();




                    switch (eventData.pointerDrag.tag)
					{
						case "atkritumi":
							obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[1]);
								break;
                        case "medicina":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[2]);
                            break;
                        case "buss":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[3]);
                            break;
                        case "traktors5Car":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[4]);
                            break;
                        case "traktors1Car":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[5]);
                            break;
                        case "b2Car":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[6]);
                            break;
                        case "policijaCar":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[7]);
                            break;
                        case "EskavatorsCar":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[8]);
                            break;
                        case "e61Car":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[9]);
                            break;
                        case "cementa":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[10]);
                            break;
                        case "e46Car":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[11]);
                            break;
                        case "ugunsdzesej":
                            obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[12]);
                            break;


                    }
                }

			}else{
				obejktuSkripts.vaiIstajaVieta = false;
				obejktuSkripts.audioAvots.PlayOneShot(obejktuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumi":
						obejktuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition=
							obejktuSkripts.atkrMKoord;
                        break;
                    case "medicina":
                        obejktuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition =
                        obejktuSkripts.atraPKoord;
                        break;
                    case "buss":
                        obejktuSkripts.autobuss.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.bussKoord;
                        break;
                    case "traktors5Car":
                        obejktuSkripts.traktors5.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.trakt5Koord;
                        break;
                    case "traktors1Car":
                        obejktuSkripts.traktors1.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.trakt1Koord;
                        break;
                    case "b2Car":
                        obejktuSkripts.b2.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.b2Koord;
                        break;
                    case "policijaCar":
                        obejktuSkripts.policija.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.policKoord;
                        break;
                    case "EskavatorsCar":
                        obejktuSkripts.eskavators.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.eskavatKoord;
                        break;
                    case "e61Car":
                        obejktuSkripts.e61.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.e61Koord;
                        break;
                    case "cementa":
                        obejktuSkripts.cementamasina.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.cementKoord;
                        break;
                    case "e46Car":
                        obejktuSkripts.e46.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.e46Koord;
                        break;
                    case "ugunsdzesej":
                        obejktuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition =
                         obejktuSkripts.ugunsdzesKoord;
                        break;

                }
            }
		}
	}
}
