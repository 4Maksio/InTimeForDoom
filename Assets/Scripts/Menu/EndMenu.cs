using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Replay() => SceneManager.LoadScene(1);
    public void Exit() => Application.Quit();
}
