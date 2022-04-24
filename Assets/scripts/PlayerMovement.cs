using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    public float walk_speed = 3;
    [Range(0.0f, 10.0f)]
    public float punch_speed = 3;
    [Range(0.0f, 1.0f)]
    public float punch_time = 1;
    public Rigidbody2D rigidbody_component;

    private float start_punch = -100;
    private Vector2 punch_direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time - start_punch < punch_time){
            float frac_punch = (Time.time - start_punch) / punch_time;
            float speed = walk_speed + (punch_speed - walk_speed) * frac_punch;
            rigidbody_component.velocity = punch_direction * speed;

        }else{
            Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

            if (direction.magnitude > 0){
                punch_direction = direction.normalized;
            }

            rigidbody_component.velocity = direction * walk_speed;

            

            if (Input.GetButton("Punch")) {
                start_punch = Time.time;
            }
        }
    }
}
