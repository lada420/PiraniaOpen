using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RadioController_ns;

namespace PlayerController_ns
{

    public class PlayerController : MonoBehaviour
    {
        public float speed_p;

        private Rigidbody2D rb_p;
        private Vector2 moveVelocity;



        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 1f;
            
        }

        // Update is called once per frame
        void Update()
        {
            Time.timeScale = 1f;
            rb_p = GetComponent<Rigidbody2D>();

            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput.normalized * speed_p;

        }


        void FixedUpdate()
        {
            rb_p.MovePosition(rb_p.position + moveVelocity * Time.fixedDeltaTime);


        }



    }
}
