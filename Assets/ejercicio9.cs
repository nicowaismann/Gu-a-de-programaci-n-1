using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: % .... , Monto total aportado: $ ….

public class ejercicio9 : MonoBehaviour
{
    public float CantidadPrimeraPersona;
    public float CantidadSegundaPersona;
    public float CantidadTerceraPersona;

    public string nombre1;
    public string nombre2;
    public string nombre3;

    

    // Start is called before the first frame update
    void Start()

    {

        float CantidadTotal = CantidadPrimeraPersona + CantidadSegundaPersona + CantidadTerceraPersona;

        Debug.Log("Nombre: " + nombre1 + " Capital aportado:  " + CantidadPrimeraPersona + "$" + " Porcentaje del capital: " + "%" + 100/CantidadTotal*CantidadPrimeraPersona + " Monto total aportado: $" + CantidadTotal);

        Debug.Log("Nombre: " + nombre2 + " Capital aportado:  " + CantidadSegundaPersona + "$" + " Porcentaje del capital: " + "%" + 100 / CantidadTotal * CantidadSegundaPersona + " Monto total aportado: $" + CantidadTotal);

        Debug.Log("Nombre: " + nombre3 + " Capital aportado:  " + CantidadTerceraPersona + "$" + " Porcentaje del capital: " + "%" + 100 / CantidadTotal * CantidadTerceraPersona + " Monto total aportado: $" + CantidadTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
