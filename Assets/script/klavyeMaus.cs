using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klavyeMaus : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Sag ok tusuna bas�ld�");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("Sag ok tusundan cekildi");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Sag ok tusuna bas�l�yor");
        }





        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Sag ok tusuna bas�ld�");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Sag ok tusundan cekildi");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Sag ok tusuna bas�liyor");
        }










    }









}
