using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinasParsledzejs : MonoBehaviour {

    public void uzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }


    public void spelet()
    {
        SceneManager.LoadScene("DragAndDropUnityFile", LoadSceneMode.Single);
    }

  


    public void apturet()
    {
        Application.Quit();
    }
}
