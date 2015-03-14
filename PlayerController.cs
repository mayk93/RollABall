using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed = 1.0f;
    private Rigidbody rb;
    private string PICKUP = "PickUp";
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    // Before phisycs calculations
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement*speed*Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == PICKUP)
        {
            other.gameObject.SetActive(false);
        }
    }
}
