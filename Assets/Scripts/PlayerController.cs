using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerController : MonoBehaviour
{

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject; 

    private Rigidbody rb;
    private int count; 
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVecter = movementValue.Get<Vector2>();
        movementX = movementVecter.x;
        movementY = movementVecter.y;

    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 16)
        {
            winTextObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {

        // if orb Z value = greater than 0 add force in positive Z direction
        // else orb Z value = less than 0 add force in negative Z direction 




        Vector3 movement = new Vector3(movementX, 0.0f, movementY);


        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;


            SetCountText();
        }



    }


}
