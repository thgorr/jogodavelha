using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 clickPosition = -Vector3.one;

            //Tentativa 01: ScreenToWorldPoint
            //clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 5f));

            //Tentativa 02 : Raycast usando Colliders
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                clickPosition = hit.point;
            }
            

            //objetivo: detectar o objeto clicado
            Debug.Log(clickPosition);
        }
        
    }
    void TileHit()
    {
        //
    }
}
