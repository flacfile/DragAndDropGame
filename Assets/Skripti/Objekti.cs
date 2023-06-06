using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public float milisekundes;
    public int sekundes;
    public int minutes;
    public int stundas;
    public Sprite[] zvaigznesMasivs;
    public GameObject restartButton;
    public GameObject[] time;
    public GameObject zvaigznes;
    public GameObject timer;
    public GameObject[] logsArRezultatu;
    public GameObject rezultats;
    public int masinuSk;
    public int zvagznuSk=1;
    public Text laikuIzvade;

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


    private void FixedUpdate()
    {
        if (masinuSk < 12)
        {
            milisekundes += 0.02f;
        }

        if (milisekundes >= 1)
        {
            sekundes++;
            milisekundes= 0;
        }

        if (sekundes>=60)
        {
            minutes++;
            sekundes = 0;
        }

        if (minutes>=60)
        {
            stundas++;
            minutes= 0;
        }

        laikuIzvade.text = $"{stundas}: {minutes} : {sekundes}";

        switch(minutes)
        {
            case 0: zvagznuSk = 1; break;
                case 1: zvagznuSk = 2; break;
                case 2: zvagznuSk = 3; break;
        }
    }

   

    void Start() {

        zvaigznes.SetActive(false);
        restartButton.SetActive(false);
        rezultats.SetActive(false);
        timer.SetActive(false);



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

    public void restartButt()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
    public void vaiVisasMasinasSaliktas()
    {
        if (masinuSk == 12)
        {
            zvaigznes.SetActive(true);
            restartButton.SetActive(true);
            rezultats.SetActive(true);
            timer.SetActive(true);

            switch (zvagznuSk)
            {
                case 1: zvaigznes.GetComponent<Image>().sprite = zvaigznesMasivs[0];
                    break;
                case 2: zvaigznes.GetComponent<Image>().sprite = zvaigznesMasivs[1];
                    break;
                case 3: zvaigznes.GetComponent<Image>().sprite = zvaigznesMasivs[2];
                    break;
            }
        
        }
    }
}
