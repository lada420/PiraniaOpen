using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerController_ns;

namespace RadioController_ns
{

    public class RadioController : MonoBehaviour
    {
        public float speed;

        private Rigidbody2D rb;
        private Vector2 moveVelocity;

        // Start is called before the first frame update
        void Start()
        {
            
            Time.timeScale = 1f;
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput.normalized * speed;


        }


        void FixedUpdate()
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);


        }
        
       


    }
}
