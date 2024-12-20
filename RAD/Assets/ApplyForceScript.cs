using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForceScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody ourRigidBody;

    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(1000, transform.position - new Vector3(0, -1, 1), 3);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch!");
        collision.transform.position += 10* Vector3.down;
    }


}

