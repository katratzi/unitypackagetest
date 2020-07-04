using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelloWorld
{

    public class Hello : MonoBehaviour
    {
        public string logThis = "";

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Hello World" + logThis);
            }
        }
    }
}
