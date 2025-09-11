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


        //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindFirstObjectByType<GameManager>(); 
        //가져온 GameManager 오브젝트의 EndGame() 매서드 실행
        gameManager.EndGame();
    }

    
}
