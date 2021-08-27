using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    //HOOSON HOW make 2D Endles Runner for beginers
    [SerializeField] private float planeSpeed;
    private Rigidbody2D planeRb;
    [SerializeField] private float yMargin;



    void Start()
    {
        planeRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //SoundManager.PlaySound("heli");
    }

    private void FixedUpdate() 
    {
        TouchInput();
    }

    private void TouchInput()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.y > 1)
            {
                //planeRb.velocity = new Vector2(mousePos.y * planeSpeed, planeRb.velocity.y);
                transform.Translate(0, planeSpeed * Time.deltaTime, 0);
                
            }
            else if (mousePos.y < -1)
            {
                //planeRb.velocity = new Vector2(-mousePos.y * planeSpeed, planeRb.velocity.y);
                transform.Translate(0, -planeSpeed * Time.deltaTime, 0);
            }
        }



        //Neleidzia pakilti auksciau yMargin arba nukristi
        float posY = transform.position.y;
        posY = Mathf.Clamp(posY, -yMargin, yMargin);
        transform.position = new Vector3(transform.position.x, posY, transform.position.z); 
        

    }
}
