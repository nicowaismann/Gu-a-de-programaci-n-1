using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio15 : MonoBehaviour
{

    public int num1;
    


    // Start is called before the first frame update
    void Start()
    {

        bool estaEnA = num1 % 2 == 1;
        bool estaEnB = num1 <= 9 && num1 >= (-9);
        bool estaEnAmbos = num1 % 2 == 1 && num1 <= 9 && num1 >= (-9);
        bool noEstaEnNinguno = num1 % 2 == 0 && num1 < (-9) && num1 < 9;

        Debug.Log(estaEnA + "el numero es impar");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
