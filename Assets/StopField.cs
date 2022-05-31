using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopField : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody>();

        if (otherRigidbody != null)
        {
            otherRigidbody.velocity = new Vector3(0, 0, 0);
            otherRigidbody.angularVelocity = new Vector3(0, 0, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
