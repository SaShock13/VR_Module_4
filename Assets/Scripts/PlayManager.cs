using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayManager 
{
    public static void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.pause=true;
    }
    public static void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
}
