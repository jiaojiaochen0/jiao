using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;

    public float jumpforce;

    public float gravitymodifier;

    public bool isonground = true;
    
        void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymodifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isonground)
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isonground = false;
        }  
    }

    private void OnCollisionEnter(Collision other)
    {
        isonground = true;
    }
}

