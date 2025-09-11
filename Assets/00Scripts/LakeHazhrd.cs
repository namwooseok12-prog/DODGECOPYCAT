using UnityEngine;

public class LakeHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();


            if (playerController != null)
            {

                playerController.Die();
            }
        }
    }
}