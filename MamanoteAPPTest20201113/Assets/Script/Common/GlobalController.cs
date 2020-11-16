using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{

    public class GlobalController : MonoBehaviour
    {
        [SerializeField] private  HeaderController _HeaderController = null;

        public static HeaderController HeaderController = null;
        
        void Start()
        {
            HeaderController = _HeaderController;
            _HeaderController.Start();

             Debug.Log("GlobalController");
            
        }
    }

        

}
