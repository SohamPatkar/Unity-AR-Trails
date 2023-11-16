using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float rotationspeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _verticalInput = Input.GetAxis("Vertical") * speed;
        float _horizontalInput = Input.GetAxis("Horizontal") * rotationspeed;
        this.transform.Translate(0,0,_verticalInput * Time.deltaTime);
        this.transform.Rotate(0,_horizontalInput * Time.deltaTime,0);
    }
}
