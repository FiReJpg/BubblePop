using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxHandler : MonoBehaviour
{
    public float skyboxRotation = 1.2f;

    void Update()
    {

        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxRotation);
        
    }
}
