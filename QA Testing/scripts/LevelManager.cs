using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheck;
    private Move MovePL;//aqui se encuentra el nombre de la secuencia de movimiento y el nombre por el cual se le conocera a dicha accion

    // Start is called before the first frame update
    void Start()
    {
        MovePL = FindObjectOfType<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespPlayer()
    {
        Debug.Log("no te desaras tan facil de mi ");
        MovePL.transform.position = currentCheck.transform.position;

    }
}
