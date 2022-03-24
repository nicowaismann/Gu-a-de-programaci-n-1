using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:
//YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
//producto comprado. Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

public class ejercicio11 : MonoBehaviour
{

    public string Fecha_De_Compra;
    public string Nombre_Del_Comprador;
    public string Producto_Solicitado;
    public int Cantidad_Solicitada;
    public float Precio_Unitario;
    float Total_a_Pagar;
    
    // Start is called before the first frame update
    void Start()
    {
        Total_a_Pagar = Cantidad_Solicitada * Precio_Unitario;

        Debug.Log(Fecha_De_Compra);
        Debug.Log(Nombre_Del_Comprador);
        Debug.Log(Producto_Solicitado);
        Debug.Log(Cantidad_Solicitada);
        Debug.Log(Precio_Unitario);
        Debug.Log(Total_a_Pagar);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
