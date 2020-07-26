using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RadioController_ns;
using PlayerController_ns;



namespace UnityStandardAssets
{
    public class SelectPlayerControl : MonoBehaviour
    {
        public GameObject Camera1;
        public GameObject Player1;
        public GameObject Camera2;
        public GameObject Player2;
        private bool isPlayered;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (isPlayered == false)
                {
                    Camera2.SetActive(true);
                    Player2.GetComponent<RadioController>().enabled = true;
                    Camera1.SetActive(false);
                    Player1.GetComponent<PlayerController>().enabled = false;
                    isPlayered = true;
                }
                else
                {
                    Camera2.SetActive(false);
                    Player2.GetComponent<RadioController>().enabled = false;
                    Camera1.SetActive(true);
                    Player1.GetComponent<PlayerController>().enabled = true;
                    isPlayered = false;
                }
            }
        }
    }
}
