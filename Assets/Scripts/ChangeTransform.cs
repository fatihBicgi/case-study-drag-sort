using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fatihBicgi.CaseStudy.Unity
{
    public class ChangeTransform : MonoBehaviour

        //transform iþini yapýyor ama en son set edilen objenin pozisyonu gönderildiði için kurala uyan
        //her hamlede diðerinin içine geçiyor
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
