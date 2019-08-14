using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AbrirPanel()
    {
        Panel.SetActive(true);
    }
    public void CambiarEscena () {
    SceneManager.LoadScene("Examen",LoadSceneMode.Single) ;
        }
}
