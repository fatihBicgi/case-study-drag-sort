using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fatihBicgi.CaseStudy.Unity
{
    public class ChangeTransform : MonoBehaviour

        //transform i�ini yap�yor ama en son set edilen objenin pozisyonu g�nderildi�i i�in kurala uyan
        //her hamlede di�erinin i�ine ge�iyor
    {
        public static event Action MouseUped;             

        private void OnMouseUp()
        {
            MouseUped?.Invoke();          
        }

        //public void BackStartPosition(Vector3 position)
        //{
        //    transform.position = position;
        //    transform.Translate(Vector3.up);
        //}
    }
}
