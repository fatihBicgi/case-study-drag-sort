using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fatihBicgi.CaseStudy.Unity
{
    public class Drag : MonoBehaviour
    {
      
        Vector3 difference;
       
        private void OnMouseDown()
        {          
            difference = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            
        }
        private void OnMouseDrag()
        {
            Vector3 dragPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition - difference);
            transform.position = dragPoint;
            
        }

        
    }
}
