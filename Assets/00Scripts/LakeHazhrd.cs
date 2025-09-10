using UnityEngine;

public class LakeHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 "Player" 태그를 가졌는지 자동으로 확인합니다.
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 호수에 빠졌습니다! 사망 처리합니다.");

            // 여기에 플레이어 사망 로직을 작성합니다.
            // 예를 들어, 플레이어 오브젝트를 파괴합니다.
            Destroy(other.gameObject);
        }
    }
}