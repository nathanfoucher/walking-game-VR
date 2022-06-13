using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundspawner;
    void Start()
    {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other){
        groundspawner.SpawnTile();
        Destroy(gameObject, 20);
    }
    
    void Update()
    {
        
    }
}
