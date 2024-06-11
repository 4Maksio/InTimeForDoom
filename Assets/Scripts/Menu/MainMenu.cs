using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject board;

    public void Start() => board.SetActive(false);
    public void Play() => SceneManager.LoadScene(1);
    public void Exit() => Application.Quit();
    public void About() => board.SetActive(true);
    public void Back() => board.SetActive(false);
}
