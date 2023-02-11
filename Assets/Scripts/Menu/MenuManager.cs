using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    // �������� �����, ��������� �� �� ��� ������� ������
    [SerializeField]
    private string startGameScene;

    public void StartGame()
    {
        SceneManager.LoadScene(startGameScene);
    }
}
