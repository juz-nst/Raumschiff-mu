using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steuerung : MonoBehaviour {

    public float speed = 5;


	void Update () {
        float horizontalePosition = GetComponent<Transform>().position.x + (Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        float verticalPosition = GetComponent<Transform>().position.y + (Input.GetAxis("Vertical") * Time.deltaTime * speed);
        GetComponent<Transform>().position = new Vector3(horizontalePosition, verticalPosition, 0);
    }
}
