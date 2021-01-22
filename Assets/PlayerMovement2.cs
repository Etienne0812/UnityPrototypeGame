using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed = 24f;
    public bool onTheGround = true;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizon = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertic = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizon, 0, vertic);

        if ( Input.GetKey("space") && onTheGround == true){
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            onTheGround = false;
        } 

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Vector3 movementSideways = new Vector3(horizon, 0.0f, 0.0f);
    } 

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Map" || collision.gameObject.tag == "Floor"){
            onTheGround = true;
        }
    }
    
}
