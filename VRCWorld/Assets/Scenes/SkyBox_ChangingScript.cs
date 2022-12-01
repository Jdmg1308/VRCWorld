using Boo.Lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBox_ChangingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Material yourMaterial;
    public Material yourMaterial2;
    void Start()
    {
        InvokeRepeating("LaunchProjectile", 2.0f, 5.3f);
        RenderSettings.skybox = yourMaterial;
    }

    void LaunchProjectile()
    {
        if (RenderSettings.skybox == yourMaterial) {
            RenderSettings.skybox = yourMaterial2;
        } else {
            RenderSettings.skybox = yourMaterial;
        }

    }

// Update is called once per frame
    void Update()
    {

    }
}
