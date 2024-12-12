using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody pRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround=true;
    public bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            pRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        } else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over :(");
        }
    }
}