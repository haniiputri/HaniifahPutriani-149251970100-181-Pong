using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl: MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Created by Haniifah Putriani - 149251970100-181");
        SceneManager.LoadScene("GameScene");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Saya");
    }
}
