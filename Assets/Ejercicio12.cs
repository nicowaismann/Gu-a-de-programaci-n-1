using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    int dado1;
    int dado2;
    int dado3;

    // Start is called before the first frame update
    void Start()
    {
        dado1 = Random.Range(1, 7);
        dado2 = Random.Range(1, 7);
        dado3 = Random.Range(1, 7);

        Debug.Log(dado1 +  " " + dado2 + " " + dado3);

        if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Excelente");
        }
       
        else if(dado1==6 && dado2==6 || dado1==6 && dado3==6 || dado2==6 && dado3 == 6){
            Debug.Log("Muy Bien");
        }

        else if(dado1==6 || dado2==6 || dado3 == 6)
        {
            Debug.Log("Regular");
        }

        else
        {
            Debug.Log("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
