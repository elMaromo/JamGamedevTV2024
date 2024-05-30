using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonInicio : MonoBehaviour
{
    public void LoadScene(string seleccionDePersonajes)
    { 
    
        SceneManager.LoadScene(seleccionDePersonajes);

    }
}
