using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject mainMenuPanel;
    [SerializeField] GameObject exitPanel;
    [SerializeField] GameObject helpPanel;

    private void Start()
    {
        PlayManager.PauseGame();
        mainPanel.SetActive(true);
        mainMenuPanel.SetActive(true);
    }

    public void OnStartBtnClick()
    {
        mainPanel.SetActive(false);
        PlayManager.ResumeGame();
    }

    public void OnHelpBtnClick()
    {
        mainMenuPanel.SetActive(false);
        helpPanel.SetActive(true);
    }

    public void OnExitBtnClick()
    {
        mainMenuPanel.SetActive(false);
        exitPanel.SetActive(true);
        PlayManager.PauseGame();
    }

    public void OnYestBtnClick()
    {
        mainPanel.SetActive(false);
        Application.Quit();
    }
    public void OnNoBtnClick()
    {
        exitPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    public void OnOkBtnClick()
    {
        helpPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
