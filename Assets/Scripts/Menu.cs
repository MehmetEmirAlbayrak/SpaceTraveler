using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Score.score = 0;
        Cursor.visible = false;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
