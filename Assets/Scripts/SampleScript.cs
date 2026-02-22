using UnityEngine;

public class SampleScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 10f;

    void Update()
    {
        if (rb != null)
        {
            rb.AddForce(Vector3.forward * forceAmount);
        }
    }
}