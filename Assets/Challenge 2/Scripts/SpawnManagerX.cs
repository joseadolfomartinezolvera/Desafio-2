using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    void Start()
    {
    //se cambio el InvokeRepeating por Invoker siendo este un mejor metodo 
        Invoke("SpawnRandomBall", startDelay);
    }

    // Genera una bola aleatoria en una posición x en la parte superior de la pantalla
    //se reestrablecio startDeleay utilizando Random.Range() y volviendo a llamar al método SpawnRandomBall() nuevamente desde dentro del propio método.
    void SpawnRandomBall ()
    {
        startDelay = Random.Range(3, 5);

        int index = Random.Range(0, ballPrefabs.Length);
        
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // ubicacion de generacion aleatoria 
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    
        Invoke("SpawnRandomBall", startDelay);

    }

}

//Hecho por Jose Adolfo Martinez Olvera
