using UnityEngine;

public class Leaf : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody LeafRigidbody;
    void Start()
    {
        
     LeafRigidbody = GetComponent<Rigidbody>();

     LeafRigidbody.linearVelocity = transform.forward * speed;


        Destroy(gameObject, 3f);
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();


            if(playerController != null)
            {

                playerController.Die();
            }
        }
    }


    void Update()
    {
        
    }
}
