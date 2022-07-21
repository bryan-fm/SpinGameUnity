using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMovement : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        this.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            this.speed = this.speed == 0 ? 10 : 0;
        }

        transform.Rotate(0,0, this.speed);
    }
}
