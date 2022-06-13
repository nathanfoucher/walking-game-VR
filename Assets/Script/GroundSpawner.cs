using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject[] groundTile;
    public int secNum;
    public bool creatingSection = false;
    Vector3 nextSpawnPoint;
     public float Speed = -2;
    int i=1;

    public void SpawnTile(){
     secNum =  Random.Range(0,6);
      GameObject temp = Instantiate(groundTile[secNum], nextSpawnPoint, Quaternion.identity);
       nextSpawnPoint.z += 25;
       nextSpawnPoint = temp.transform.GetChild(1).transform.position;
       
       
    } 


    private void Start()
    {
      for(int i =0; i<7; i++){
          SpawnTile();
         Debug.Log("tour numero " + i + "random "+ secNum + "\n");
       
      }
      
      
    }
    

}
