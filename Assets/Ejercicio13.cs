using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//    Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
//manera:
//• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar
//el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
//por cada hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
//el salario correspondiente.

public class Ejercicio13 : MonoBehaviour
{
    public int Horas_Trabajadas;
    int pago16;
    // Start is called before the first frame update
   void Start()
    
    {
        pago16 = 16
        if (Horas_Trabajadas =< 40)
        {
            Debug.Log(Horas_Trabajadas * pago16);
        }

        else if (Horas_Trabajadas > 40)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
