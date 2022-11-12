using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fatihBicgi.CaseStudy.Unity
{
    public class Grid : MonoBehaviour
    {
        //bir de hesaplar mouseup da yap�ld��� i�in totalred de�eri 1 hamle ge� geliyor her zaman
        //4lendi�inde de�il de bir hamle sonras�nda yaz�yor grid done diye

        
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
            //en iyi y�ntem de�il ama mouseuped da �al��t�r�nca i�lemi geriden takip etme sorunu ya�ad�
            //en az�ndan �al���yor �u anda
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
