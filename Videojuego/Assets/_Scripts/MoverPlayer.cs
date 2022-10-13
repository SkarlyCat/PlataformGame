using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{

    private Rigidbody _rigidbody;

    public float speed;
    public float turnspeed;

    public bool canjump;
    public float forceJump;

    public Transform _initialPos;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

 
    void Update()
    {
        Move();
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Danger"))
        {
            transform.position = _initialPos.position;
  
        }

    }


    public void Move()
    {

        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        transform.Translate (0, 0, moveVertical *speed* Time.deltaTime);

        transform.Rotate (0, moveHorizontal, 0 *turnspeed*Time.deltaTime);

        if (canjump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(Vector3.up * forceJump, ForceMode.Impulse);            
            }
        }
    }
}
