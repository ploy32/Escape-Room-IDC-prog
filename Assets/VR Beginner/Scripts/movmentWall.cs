using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmentWall : MonoBehaviour
{
 [SerializeField] private Vector3 target = new Vector3(-11,4,15.6400003f);
 [SerializeField] private float speed = 1;
 public static bool Move = false;
 public static bool T2 = false;
 
 private void Update()
 {
    if(Move && T2){
       transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
 }
}
