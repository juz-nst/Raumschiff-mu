using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steuerung1 : MonoBehaviour {


    public float speed = 5;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate () {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed), ForceMode2D.Force);
	}
}
