using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteRose : MonoBehaviour
{
    public LevelManager lvlMN;
    [SerializeField]
    

    // Start is called before the first frame update
    void Start()
    {
        lvlMN = FindObjectOfType<LevelManager>();//se buscara el lvlmn para verificar que se pueda hacer la reaparicion y trabaje con los otros dos codigos antes mencionados
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Rose")
        {
           
            lvlMN.RespPlayer();
            

        }

    }
}
