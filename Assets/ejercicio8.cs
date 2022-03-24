using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Crear una variable entera que pueda ser modificada desde el Inspector. Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error &quot; El día ingresado no es válido&quot;.

public class ejercicio8 : MonoBehaviour
{

    public int día;
    // Start is called before the first frame update
    void Start()
    {
        if (día == 1)
        {
            Debug.Log("Domingo");
        }

        else if (día == 2)
        {
            Debug.Log("Lunes");
        }

        else if (día == 3)
        {
            Debug.Log("Martes");
        }

        else if (día == 4)
        {
            Debug.Log("Miércoles");
        }

        else if (día == 5)
        {
            Debug.Log("Jueves");
        }

        else if (día == 6)
        {
            Debug.Log("Viernes");
        }

        else if (día == 7)
        {
            Debug.Log("Sábado");
        }


        else
        {
            Debug.Log("El día ingresado no es válido");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
