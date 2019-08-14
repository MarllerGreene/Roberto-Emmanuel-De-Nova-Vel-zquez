using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardadoPunto : MonoBehaviour
{
    public LevelManager lvlMN;//el level manager sirve basicamente para trabajar en conjunto con el game object y con el punto de guardado
    // Start is called before the first frame update
    void Start()
    {
        lvlMN = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Rose")
        {
            lvlMN.currentCheck = gameObject;
            Debug.Log("He Volvido :v" + transform.position);
        }
    }
}
