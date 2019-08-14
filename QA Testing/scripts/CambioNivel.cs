using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour
{
    private bool PlayerInLevel;
    public string levelCarga;
    // Start is called before the first frame update
    void Start()
    {
        PlayerInLevel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInLevel == true)//cuando se encuentre cerca de la puerta o bien el portal y se presione "e" este pasara a otra escena
        {
            SceneManager.LoadScene(levelCarga);//despues de que se precione el boton "e" este te redirigira a otra escena antes puesta en el public
        }
    }

    void OnTriggerEnter2D(Collider2D Personaje)//funcionara cuando este cerca de el portal con un objeto 2d triggered
    {
        if (Personaje.name == "Rose")//aqui con el nombre del personaje que por cierto es Rose
        {
            PlayerInLevel = true;//en dado caso de que este en el nivel y en el lugar correcto se mandara un mensaje de acceso para poder apretar el boton
            Debug.Log("Entro al portal");
        }

    }
    void OnTriggerExit2D(Collider2D Personaje)
    {
        if (Personaje.name == "Rose")
        {
            PlayerInLevel = false;//lo mismo pero cuando sale
            Debug.Log("Salgo del portal");
        }
    }


}
