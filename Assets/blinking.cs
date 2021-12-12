using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinking : MonoBehaviour
{
    public Light mylight;
    public float minWaitTime;
    public float maxwaitTime;
    public float minLightIntensity;
    public float maxLightIntensity;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blinking());
    }
    IEnumerator Blinking()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxwaitTime));
            mylight.intensity = Random.Range(minLightIntensity,maxLightIntensity);
        }
    }
}