using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public Button startButton;
    void Start()
    {
        startButton.onClick.AddListener(StartGameOnClick);
    }

    void Update()
    {

    }

    void StartGameOnClick()
    {
        SceneManager.LoadScene("Game");
    }
}
