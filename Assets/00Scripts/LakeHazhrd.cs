using UnityEngine;

public class LakeHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� "Player" �±׸� �������� �ڵ����� Ȯ���մϴ�.
        if (other.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ ȣ���� �������ϴ�! ��� ó���մϴ�.");

            // ���⿡ �÷��̾� ��� ������ �ۼ��մϴ�.
            // ���� ���, �÷��̾� ������Ʈ�� �ı��մϴ�.
            Destroy(other.gameObject);
        }
    }
}