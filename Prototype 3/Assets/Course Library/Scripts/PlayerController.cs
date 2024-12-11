using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody pRb;
    public float jumpForce;
    public float gravityModifier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

}