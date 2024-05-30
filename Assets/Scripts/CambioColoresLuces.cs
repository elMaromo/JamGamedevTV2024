using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColoresLuces : MonoBehaviour
{
    public Material[] materials; // Array de materiales
    private Renderer objRenderer;
    private int currentMaterialIndex = 0;
    private float changeInterval = 0.5f;

    void Start()
    {
        if (materials.Length == 0)
        {
            Debug.LogError("No materials assigned to the ChangeColor script on " + gameObject.name);
            return;
        }

        objRenderer = GetComponent<Renderer>();
        objRenderer.material = materials[currentMaterialIndex];
        StartCoroutine(ChangeMaterialRoutine());
    }

    IEnumerator ChangeMaterialRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeInterval);
            ChangeToNextMaterial();
        }
    }

    void ChangeToNextMaterial()
    {
        currentMaterialIndex = (currentMaterialIndex + 1) % materials.Length;
        objRenderer.material = materials[currentMaterialIndex];
    }
}
