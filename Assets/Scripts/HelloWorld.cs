using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 10f;
    void Start()
    {
        Debug.Log("Hello Wolrd from "+ gameObject.name+ " with speed: "+ Speed);
    }

    // Update is called once per frame
    void Update()
    {
        float tempo = Time.deltaTime;
        // Objetivo: Aumentar o eixo Z do transform ao passar do tempo
        transform.position+= new Vector3(0,0,Speed * tempo);
        

    }
}
