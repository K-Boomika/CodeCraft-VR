using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTraining : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public Vector3 originalPositiont1;
    public Vector3 originalPositiont2;
    public Vector3 originalPositiont3;
    public Vector3 originalPositiont4;
    public Quaternion originalRotationt1;
    public Quaternion originalRotationt2;
    public Quaternion originalRotationt3;
    public Quaternion originalRotationt4;
    public float maxDistanceThreshold = 1f;
    void Start()
    {
        originalPositiont1 = text1.transform.position;
        originalPositiont2 = text2.transform.position;
        originalPositiont3 = text3.transform.position;
        originalPositiont4 = text4.transform.position;

        originalRotationt1 = text1.transform.rotation;
        originalRotationt2 = text2.transform.rotation;
        originalRotationt3 = text3.transform.rotation;
        originalRotationt4 = text4.transform.rotation;
    }
    public void ResetToOriginalPosition()
    {
        // Disable physics components
        Rigidbody rb1 = text1.GetComponent<Rigidbody>();
        Rigidbody rb2 = text2.GetComponent<Rigidbody>();
        Rigidbody rb3 = text3.GetComponent<Rigidbody>();
        Rigidbody rb4 = text4.GetComponent<Rigidbody>();

        rb1.isKinematic = true;
        rb2.isKinematic = true;
        rb3.isKinematic = true;
        rb4.isKinematic = true;

        // Move the objects back to their original position
        text1.transform.position = originalPositiont1;
        text2.transform.position = originalPositiont2;
        text3.transform.position = originalPositiont3;
        text4.transform.position = originalPositiont4;

        text1.transform.rotation = originalRotationt1;
        text2.transform.rotation = originalRotationt2;
        text3.transform.rotation = originalRotationt3;
        text4.transform.rotation = originalRotationt4;

        // Enable physics components back
        rb1.isKinematic = false;
        rb2.isKinematic = false;
        rb3.isKinematic = false;
        rb4.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance of each text from its original position
        float distance1 = Vector3.Distance(text1.transform.position, originalPositiont1);
        float distance2 = Vector3.Distance(text2.transform.position, originalPositiont2);
        float distance3 = Vector3.Distance(text3.transform.position, originalPositiont3);
        float distance4 = Vector3.Distance(text4.transform.position, originalPositiont4);

        // Check if any text has gone beyond the maximum distance threshold
        if (distance1 > maxDistanceThreshold ||
            distance2 > maxDistanceThreshold ||
            distance3 > maxDistanceThreshold ||
            distance4 > maxDistanceThreshold)
        {
            // Reset position and rotation
            ResetToOriginalPosition();
        }
    }
}
