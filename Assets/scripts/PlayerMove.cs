using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 1.0f;
    public float rotationSpeed=1.0f;
    private Rigidbody Physics;
    public float JumpForce=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState= CursorLockMode.Locked;
        Cursor.visible = false;

        Physics = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update(){
        //Movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal,0.0f,vertical) * Time.deltaTime * Speed);
    //rotacion
        float rotationY= Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,rotationY * Time.deltaTime * rotationSpeed));
        //salto
        if(Input.GetKeyDown(KeyCode.Space)){
            Physics.AddForce(new Vector3(0,JumpForce,0),ForceMode.Impulse);
        }
        
    }
}
