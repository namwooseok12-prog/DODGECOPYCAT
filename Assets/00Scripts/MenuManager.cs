using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위해 필요합니다.

public class MenuManager : MonoBehaviour
{
    // '게임 시작' 버튼에 연결될 함수입니다.
    // public으로 선언해야 버튼에서 이 함수를 호출할 수 있습니다.
    public void StartGame()
    {
        // "MainGame" 씬을 로드합니다.
        SceneManager.LoadScene("MainGame");
    }
}