using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDrunk : MonoBehaviour
{
    public string sceneName;

    public void selectD1()
    {
        GameManager.Instance.borrachoSeleccionado = 3;
        LoadSceneOfGameplay();
    }

    public void selectD2()
    {
        GameManager.Instance.borrachoSeleccionado = 2;
        LoadSceneOfGameplay();
    }

    public void selectD3()
    {
        GameManager.Instance.borrachoSeleccionado = 1;
        LoadSceneOfGameplay();
    }

    public void selectD4()
    {
        GameManager.Instance.borrachoSeleccionado = 0;
        LoadSceneOfGameplay();
    }

    public void selectD5()
    {
        GameManager.Instance.borrachoSeleccionado = 4;
        LoadSceneOfGameplay();
    }

    public void selectD6()
    {
        GameManager.Instance.borrachoSeleccionado = 5;
        LoadSceneOfGameplay();
    }

    public void LoadSceneOfGameplay()
    {
        SceneManager.LoadScene(sceneName);
    }

}
