using UnityEngine;

public class Gravity : MonoBehaviour
{

    Rigidbody rb;
    const float G = 0.0674f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Attract(Gravity other)
    {
        Rigidbody otherRb = other.rb;
        Vector3 direction = rb.position - otherRb.position;
        float distance = direction.magnitude;
        float forceMagnitude = G * (rb.mass * otherRb.mass) /Mathf.Pow(distance, 2);
        Vector3 finalForce = forceMagnitude * direction.normalized;

        otherRb.AddForce(finalForce);
    }
}
