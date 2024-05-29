using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialOfEnemy : MonoBehaviour
{
    public int preferedDrunk;
    public List<Texture2D> drunkTextures;
    private Renderer rnd;

    public void Start()
    {
        rnd = GetComponent<Renderer>();
        int drunkSelected = GameManager.Instance.borrachoSeleccionado;

        if (drunkSelected == preferedDrunk)
        {
            drunkSelected = 0;
        }
        else
        {
            drunkSelected = preferedDrunk;
        }

        rnd.material.SetTexture("_MainTex", drunkTextures[drunkSelected]);
    }
}
