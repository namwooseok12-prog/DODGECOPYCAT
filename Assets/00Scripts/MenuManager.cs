using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ���� �ʿ��մϴ�.

public class MenuManager : MonoBehaviour
{
    // '���� ����' ��ư�� ����� �Լ��Դϴ�.
    // public���� �����ؾ� ��ư���� �� �Լ��� ȣ���� �� �ֽ��ϴ�.
    public void StartGame()
    {
        // "MainGame" ���� �ε��մϴ�.
        SceneManager.LoadScene("MainGame");
    }
}