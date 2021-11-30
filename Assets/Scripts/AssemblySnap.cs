using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblySnap : MonoBehaviour
{
    [SerializeField]
    GameObject ObjectToAccept;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ObjectToAccept)
        {
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
            // Turn off the ghost
            GetComponent<MeshRenderer>().enabled = false;
            // Turn off object manipulator after snapping
            other.GetComponent<ObjectManipulator>().enabled = false;
            other.GetComponent<Rigidbody>().freezeRotation = true;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
    
}
    }
}