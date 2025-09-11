using UnityEngine;
using UnityEngine.UI; // UI ���ö��̺귯�� (����)
using TMPro; // textmeshpro ���� ���̺귯��
using UnityEngine.SceneManagement;
using System.Diagnostics.Tracing;// �� ���� ���� ���̺귯��
public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ����� Ȱ��ȭ�� ���� ������Ʈ
    public TextMeshProUGUI timetext; //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public TextMeshProUGUI recordText; // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime; // �����ð�
    private bool isGameover;//���ӿ��� ����
    void Start()
    {
        // �����ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0f;
        isGameover = false;
    }


    void Update()
    {
        // ���ӿ����� �ƴѵ���

        if (!isGameover)
        {
            // �����ð� ����
            surviveTime += Time.deltaTime;
            // ������ ���� �ð��� timeText  �ؽ�Ʈ�� ������Ʈ�� ���� ǥ��
            timetext.text = "Time : " + (int)surviveTime;
        }
        else
        {
            // ���ӿ��� ���¿��� RŰ�� ������ {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //sample scene ���� �ε�
                SceneManager.LoadScene("MainGame");
            }
        }


    }

    //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        //���ӿ��� �ؽ�Ʈ ���ӿ�����Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);


        //bestTime Ű�� ���屭 ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        //���������� �ְ� ��Ϻ��� ���� �����ð��� �� ũ�ٸ�
        if (surviveTime > bestTime)
        {
            //�ְ� ��� ���� ���� ���� �ð� �����κ���
            bestTime = surviveTime;

            // ����� �ְ� ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        // �ְ� ��Ϥ��� recordText �ؽ�Ʈ ������Ʈ�� ���� ǥ��
        recordText.text = "Best Time" + (int)bestTime;
    }
}
