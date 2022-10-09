using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    float yaklas = 60;
    void Update()
    {
         GetComponent<Camera>().fieldOfView = yaklas;
         if (Input.GetButton("Fire2"))
         {
             yaklas -= 1;
             if (yaklas<30)
             {
                 yaklas = 30;
             }
         }
         if(!Input.GetButton("Fire2"))
         {
             yaklas += 1;
             if (yaklas>60)
             {
                 yaklas=60;
             }
         }
         
    }
    

}
