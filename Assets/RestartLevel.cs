using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartLevel : MonoBehaviour
{

    public Button RestartButton, QuitButton;

    void Start()
    {
        RestartButton.onClick.AddListener(RestartOnClick);
        QuitButton.onClick.AddListener(QuitGame);
        Cursor.lockState = CursorLockMode.None;
    }

    void RestartOnClick()
    {
        SceneManager.LoadScene("Level0");
    }

    void QuitGame() 
    {
        Application.Quit();
    }
}
