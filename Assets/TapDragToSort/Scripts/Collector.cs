using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fatihBicgi.CaseStudy.Unity
{   
    public class Collector : MonoBehaviour
    {       

        Transform otherTransform;
        String otherTag;

        public int redCount=0,blueCount=0,greenCount=0;       

        bool isCollectorLoaded=false;

        void Start()
        {          
            //Debug.Log(transform.childCount);       
        }
        private void OnTriggerEnter(Collider other)
        {
            if (!isCollectorLoaded) ChangeTransform.MouseUped += DoThings;

            //Debug.Log(gameObject.name + ": is Listening");           

            ReferencesToOther(other);
        }       

        private void OnTriggerExit(Collider other)
        {
            ChangeTransform.MouseUped -= DoThings;            

            ReduceFromCollected();

            //Debug.Log(gameObject.name + ": is NOT Listening");
        }

        private void ReduceFromCollected()
        {
            isCollectorLoaded = false;

            if (otherTag == "Red")
            {
                redCount = 0;                
                
            }
            else if (otherTag == "Blue")
            {
                blueCount = 0;              
                
            }
            else if (otherTag == "Green")
            {
                greenCount = 0;                
                
            }
        }        
        private void DoThings()
        {
            
            if (!isCollectorLoaded)
            {
                Collect();               
            } 
            //else
            //dolu deðilse kabul etme
        }

        private void Collect()
        {
            isCollectorLoaded = true;

            if (otherTag == "Red")
            {
                redCount = 1;
                
            }
            else if (otherTag == "Blue")
            {
                blueCount = 1;
                
            }
            else if (otherTag == "Green")
            {
                greenCount = 1;
                
            }
            MakeChildOther();
            MakePositionSame();
        }
        
        private void MakeChildOther()
        {
            otherTransform.parent = gameObject.transform;
        }
        private void MakePositionSame()
        {          
            otherTransform.position = gameObject.transform.position;
            otherTransform.Translate(Vector3.up *0.8f);         
        }
               
        private void ReferencesToOther(Collider other)
        {
            otherTransform = other.transform;
            otherTag = other.tag;
        }
    }
}
