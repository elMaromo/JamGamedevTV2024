using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDrunk : MonoBehaviour
{
    public void selectD1()
    {
        GameManager.Instance.borrachoSeleccionado = 1;
    }

    public void selectD2()
    {
        GameManager.Instance.borrachoSeleccionado = 2;
    }

    public void selectD3()
    {
        GameManager.Instance.borrachoSeleccionado = 3;
    }

    public void selectD4()
    {
        GameManager.Instance.borrachoSeleccionado = 4;
    }

}
