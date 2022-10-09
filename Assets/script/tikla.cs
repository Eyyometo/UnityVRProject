using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class tikla : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
   
            if (Input.GetMouseButtonDown(0))
         {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {

                      SceneManager.LoadScene(1);
                }
            }
         }
      }

      public void sahne_gecis(int sahne){
          SceneManager.LoadScene(sahne);
      }
    } 
