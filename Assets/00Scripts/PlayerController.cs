using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;
    public float speed = 8f;
    
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float xInfut = Input.GetAxis("Horizontal");
        float zInfut = Input.GetAxis("Vertical");



        float xSpeed = xInfut * speed;  
        float zSpeed = zInfut * speed;



        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        PlayerRigidbody.linearVelocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }

    
}
