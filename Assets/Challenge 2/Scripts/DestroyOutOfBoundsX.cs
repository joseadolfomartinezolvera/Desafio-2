using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;//se cambio su valor a negativo 
    private float bottomLimit = -5;

    
    void Update()
    {
        //en esta parte se hizo que leftLimit fuera negativo, se cambio el valor > de la posicion x por un < 
        //y se cambio z por y en el limite inferios
        // Destruir perros si la posición x es inferior al límite izquierdo
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destruye las bolas si la posición y es menor que bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
//Hecho por Jose Adolfo Martinez Olvera
