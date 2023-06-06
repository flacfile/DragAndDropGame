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
    public float milisekundes; //mainigia ar milisekundem
    public int sekundes; //mainigia ar sekundem
    public int minutes; //mainigia ar minutem
    public int stundas; //mainigia ar stundam
    public Sprite[] zvaigznesMasivs; //masivs, kur glabajas atteli ar zvaigznitem
    public GameObject restartButton; //restart poga
    public GameObject[] time; //gameobject, kurā ir laiks un zvaigznes
    public GameObject zvaigznes; //gameobject zvaigznes
    public GameObject timer; //gameobject laiks
    public GameObject[] logsArRezultatu; //logs, kurš izkrit speles beigās (fons, laiks utt.)
    public GameObject rezultats; //gameobject, kurā unity es liku paneli
    public int masinuSk; //masinas skaits, lai nākotnē, kad lietotajs salik visas mašinas, darbojas viss pārējais kods ar rezultatu logu
    public int zvagznuSk=1; //sakumvertība, cik ir zvaigznes
    public Text laikuIzvade; //teksta lauks, kurā printējas laiks

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


    private void FixedUpdate() //FixedUpdate parasti tiek izmantots aprēķiniem, jo: defoltā tas tiek izpildīts ik pēc 0,02 sekundēm, tāpec šājā metoda, lai
        //reķnatu laiku, izmantojam fixedupdate
    {
        if (masinuSk < 12) //ja salikto mašīnu skaits ir mazāks par 12
        {
            milisekundes += 0.02f; //+milisek
        }

        if (milisekundes >= 1) //kad milisekundu skaits ir 1000, sekundes = 1 utt, milisekundes 1000 ++sekundes
        {
            sekundes++; 
            milisekundes= 0;
        }

        if (sekundes>=60)  //kad sekundu skaits ir 60, minutes = 1 utt, sekundes 60 ++minutes
        {
            minutes++;
            sekundes = 0;
        }

        if (minutes>=60) //kad minūšu skaits ir 60, stundas = 1 utt, minūtes 60 ++stundas
        {
            stundas++;
            minutes= 0;
        }

        laikuIzvade.text = $"{stundas}: {minutes} : {sekundes}"; //printe laiku, paskatijos kā to darīt šeit: https://www.youtube.com/watch?v=Y_AOfPupWhU

        switch (minutes) //switch ar zvaigznitem, balstoties uz laiku
        {
            case 0: zvagznuSk = 1; break;
                case 1: zvagznuSk = 2; break;
                case 2: zvagznuSk = 3; break;
        }
    }

   

    void Start() {

        zvaigznes.SetActive(false); //paslept visas rezultatas logus
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
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single); //Samainit aini uz sākumu
    }
    public void vaiVisasMasinasSaliktas()
    {
        if (masinuSk == 12)
        {
            zvaigznes.SetActive(true); //gadijuma kad visie transportlidzekļi ir savas vietas, paradas rezultata logs ar laiku, fonu, restart pogu un zvaignem
            restartButton.SetActive(true);
            rezultats.SetActive(true);
            timer.SetActive(true);

            switch (zvagznuSk)
            {
                case 1: zvaigznes.GetComponent<Image>().sprite = zvaigznesMasivs[0]; //Paradīt atbilstošo rezultatu (1,2 vai 3 zvaigznites)
                    break;
                case 2: zvaigznes.GetComponent<Image>().sprite = zvaigznesMasivs[1];
                    break;
                case 3: zvaigznes.GetComponent<Image>().sprite = zvaigznesMasivs[2];
                    break;
            }
        
        }
    }
}
