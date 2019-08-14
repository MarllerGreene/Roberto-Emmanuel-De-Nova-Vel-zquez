using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemigoIA2
{
    Patrulla,
    Perseguir,
    Atacar
}
//Roberto Emmanuel De Nova Velázquez
//13/06/2019
//Estructura de base de datos
//Puntos
public class MovPuntosIA2 : MonoBehaviour
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;
    public Transform player;
    public EnemigoIA estadoActual= new EnemigoIA();
    // Start is called before the first frame update
    void Start()
    {
        estadoActual = EnemigoIA.Patrulla;
        target = puntos[1];
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - sierra.position;
        float distance = Vector3.Distance(sierra.position, target.position);

        float distancePlayer= Vector3.Distance(sierra.position, player.position);

        sierra.Translate(dir.normalized * velocidad, Space.World);
        if (estadoActual == EnemigoIA.Patrulla)
            target = puntos[indiceTarget];
            {

            if (distance <= 0.5f)
            {
                if (indiceTarget >= puntos.Length - 1)//el propio sistema lee la extencion total del array con "length",si indiceTarget es >= a la extension del
                                                      //ArrayList sera -1
                {
                    indiceTarget = 0;//al llegar a 0 se parara la lista debido a la sorecarga de indice
                    target = puntos[indiceTarget];//aqui se pone el valor de "target" para tomarlo como recorido

                }

                indiceTarget++;//el aumento de un numero +1
                target = puntos[indiceTarget];//se basa en la lectura de indice segun sea lo que lleve

            }
        }
        if (distancePlayer<=2)
        {
            estadoActual = EnemigoIA.Perseguir;

        }
        

        if  (estadoActual == EnemigoIA.Perseguir)
        {
            target = player;
}
        else if (distancePlayer > 5)
        {
            estadoActual = EnemigoIA.Patrulla;

        }
        if (estadoActual == EnemigoIA.Perseguir)
        {
            target = player;
        }


    }
}
