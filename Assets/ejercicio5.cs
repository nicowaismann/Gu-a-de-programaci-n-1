﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Realizá un programa que, dados dos números enteros num1 y num2 cargados desde el
//Inspector muestre el resultado de la división del primero por el segundo en la consola
//siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.
//En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:
//“No se puede dividir por cero”.

public class ejercicio5 : MonoBehaviour
{
    public double num1;
    public double num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por cero");
        }
        else
        {
            Debug.Log(num1 + "/" + num2 + "=" + num1 / num2);
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
