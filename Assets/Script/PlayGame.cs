using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed;
    private float move;


    // Update is called once per frame
    void Update()
    {
        move=Input.GetAxisRaw("Horizontal");
        if(move!=0)
        {
            //Gerak
            rb.velocity = new Vector2(speed * move, rb.velocity.y);        }       
    }
}
