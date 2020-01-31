using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    #region Unity_Functions
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    #endregion

    #region Scene_Transitions

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void WinGame()
    {
        SceneManager.LoadScene("Win Scene");
    }

    public void LoseGame()
    {
        SceneManager.LoadScene("Game Over Scene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    #endregion
}
