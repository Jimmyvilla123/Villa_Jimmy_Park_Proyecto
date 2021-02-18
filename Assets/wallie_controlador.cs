using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallie_controlador : MonoBehaviour
{
    Rigidbody rb;
    Vector2 inputMov;
    Vector2 inputRot;
    public float velCamina = 10f;
    public float sensibilidadMause;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        inputMov.x = Input.GetAxis("Horizontal");
        inputMov.y = Input.GetAxis("Vertical");

        inputRot.x = Input.GetAxis("Mouse x") * sensibilidadMause;
        inputRot.y = Input.GetAxis("Mouse y")* sensibilidadMause;

    }
    private void FixedUpdate() {
        float vel = velCamina;
        rb.velocity = transform.forward * vel * inputMov.y 
            + transform.right *vel * inputMov.x;

        transform.rotation *= Quaternion.Euler(0, inputRot.x, 0);
    
    }
}
