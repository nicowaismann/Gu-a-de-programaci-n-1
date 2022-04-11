using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio14 : MonoBehaviour
{
    public string operación;
    public float num1;
    public float num2;

    // Start is called before the first frame update
    void Start()
    {
        switch (operación)
        {
            case "s":
                Debug.Log(num1 + num1);
                break;

            case "r":
                Debug.Log(num1 - num1);
                break;

            case "p":
                Debug.Log(num1 * num1);
                break;

            case "d":
                Debug.Log(num1 / num1);
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
