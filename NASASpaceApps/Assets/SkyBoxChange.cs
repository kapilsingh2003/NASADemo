using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChange : MonoBehaviour
{
    [SerializeField] public Material skybox1;
    [SerializeField] public Material skybox2;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMySkybox1()
    {

        RenderSettings.skybox = skybox1;
    }
    public void ChangeMySkybox2()
    {

        RenderSettings.skybox = skybox2;
    }
}
