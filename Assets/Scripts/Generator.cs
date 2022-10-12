using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
   public GameObject obstacle;
   private GameObject createdWheel;
   private float scala; 
   public void newObstacle(){
      scala = Random.Range(1.75f, 3);
      createdWheel = Instantiate(obstacle, this.transform);
      createdWheel.transform.Find("Circle").localScale = new Vector3(scala, scala, 0);
   }
}
