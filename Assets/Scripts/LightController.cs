using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    //SOUND STUFF
    public AudioSource[] soundFX;
    bool m_Shower;
    bool m_Thunder;

    [Range(0, 10)]
    public float DATA = 8;
    private Light light;

    private void Start()
    {
        // retrieve the light component
        light = GetComponent<Light>();
    }

    private void Update()
    {
        // set the light intensity based on the slider
        light.intensity = DATA;

        /*  if (DATA <= 5)
          {
              soundFX[1].Stop();
              soundFX[0].Play();
              print("showers");

          }
          else
          {
              soundFX[0].Stop();
              soundFX[1].Play();
              print("Thunder");
              m_Thunder = false;
          }*/

    }


    void Opposite()
    {
        soundFX[0].Stop();
        /* soundFX[1].Play();
         print("Thunder");
         m_Shower = true;
         m_Thunder = true;*/
    }


}