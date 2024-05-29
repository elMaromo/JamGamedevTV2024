using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialOfPlayer : MonoBehaviour
{
    public List<Texture2D> drunkTextures;
    private Renderer rnd;

    public void Start()
    {
        rnd = GetComponent<Renderer>();
        int drunkSelected = GameManager.Instance.borrachoSeleccionado;
        rnd.material.SetTexture("_MainTex", drunkTextures[drunkSelected]);
    }
}
