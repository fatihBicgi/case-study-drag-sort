using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fatihBicgi.CaseStudy.Unity
{
    public class Grid : MonoBehaviour
    {
        //bir de hesaplar mouseup da yapýldýðý için totalred deðeri 1 hamle geç geliyor her zaman
        //4lendiðinde deðil de bir hamle sonrasýnda yazýyor grid done diye

        
        Collector collector;

        Animator animator;

        public bool isDone=false;

        public List<GameObject> squareList = new List<GameObject>();

        public int totalRed = 0, totalBlue = 0, totalGreen = 0;

        private void Start()
        {
            animator = GetComponent<Animator>();
            foreach (Transform child in gameObject.transform)
            {
                squareList.Add(child.gameObject);
                collector = child.GetComponent<Collector>();                              
            }           
        }
        
        
        private void FixedUpdate()
            //en iyi yöntem deðil ama mouseuped da çalýþtýrýnca iþlemi geriden takip etme sorunu yaþadý
            //en azýndan çalýþýyor þu anda
        {
            ColorCheck();
        }

        private void ColorCheck()
        {
            totalRed = 0;
            totalBlue = 0;
            totalGreen = 0;

            foreach (GameObject gameObject in squareList)
            {
                collector = gameObject.GetComponent<Collector>();
                totalRed += collector.redCount;
                totalBlue += collector.blueCount;
                totalGreen += collector.greenCount;

                print(gameObject.name + " " + totalRed + collector.gameObject.name);
            }

            GridCheck();

            WinCheck();

        }

        private void GridCheck()
        {
            if (totalRed == 4 || totalBlue == 4 || totalGreen == 4)
            {
                isDone = true;
                animator.SetBool("isDoneAnim", true);
            }
            else
            {
                isDone = false;
                animator.SetBool("isDoneAnim", false);
            }
               

            
        }
        private void WinCheck()
        {

            if (isDone)
            {
                print("Grid Donee!!");
                

            }

        }
    }
}
