using UnityEngine;

public class SpinningReticle : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // rotationg around Z-axis
    private Vector3 rotationAxis = new Vector3(0, 0, 1);


    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(rotationAxis * rotationSpeed * Time.unscaledDeltaTime, Space.Self);
        //transform.Rotate(rotationAxis * rotationSpeed * Time.unscaledDeltaTime);
        transform.localRotation = Quaternion.Euler(0, 0, Time.time * 200f);

    }
}
