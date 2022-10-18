using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{
    public GameObject key;
    public bool haveKey;

    private Rigidbody _rigidbody;

    public float speed;
    public float turnspeed;

    public bool canjump;
    public float forceJump;

    public Transform _initialPos;

    public GameObject[] plataforms;

    public bool isInGround;

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
            haveKey = false;
            Instantiate(key, key.transform.position, Quaternion.identity);
  
        }
        if (other.CompareTag("Key"))
        {
            haveKey = true;
            Destroy(other.gameObject);

        }

        if (other.CompareTag("PowerUpJump"))

        {
            canjump = true;

            plataforms[0].GetComponent<Rigidbody>().useGravity = true;
            plataforms[0].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            plataforms[1].GetComponent<Rigidbody>().useGravity = true;
            plataforms[1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

            Destroy (other.gameObject);
        }

        if (other.CompareTag("Ground")) isInGround = true;


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ground")) isInGround = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground")) isInGround = false;
    }

    public void Move()
    {

        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        transform.Translate (0, 0, moveVertical *speed* Time.deltaTime);

        transform.Rotate (0, moveHorizontal, 0 *turnspeed*Time.deltaTime);

        //Este es para saltar
        if (canjump && isInGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(Vector3.up * forceJump, ForceMode.Impulse);            
            }
        }
    }
}
