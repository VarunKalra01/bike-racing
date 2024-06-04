using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuitGame : MonoBehaviour
{
    public Button quitButton;
    void Start()
    {
        quitButton.onClick.AddListener(QuitGameOnClick);
    }

    void Update()
    {

    }

    void QuitGameOnClick()
    {
        Application.Quit();
    }
}
