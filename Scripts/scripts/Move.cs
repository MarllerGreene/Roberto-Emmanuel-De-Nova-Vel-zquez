using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform myTransform;
    public float speed;//Basicamente el movimiento

    // Start is called before the first frame update
    void FixedUpdate()
    {
        myTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            myTransform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);//con este gracias a que se puso la velocidad en negativo ira hacia la izquierda,la velocidad esta dada por el public
        }
        if (Input.GetKey(KeyCode.D))
        {
            myTransform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {//con esto puede saltar y se pone en medio debido a la regla de x,y,z en esta ocacion se utilizo un numero para darle una velocidad en especifico osease un tope
            myTransform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
        }
    }
}
