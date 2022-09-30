using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; // Tiempo que la jugadora tiene que esperar para disparar de nuevo
private float nextFire = 0; // tiempo desde el inicio después del cual el jugador puede disparar de nuevo

    
    void Update()
    {
        // Presiona la barra espaciadora, envía perro
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextFire = Time.time + fireRate;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
//Hecho por Jose Adolfo Martinez Olvera