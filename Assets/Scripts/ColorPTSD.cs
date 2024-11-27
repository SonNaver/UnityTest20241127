using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ColorPTDS : MonoBehaviour
{
    Renderer color;
    float timer = 1f;
    float currentTime = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        color = GetComponent<Renderer>();
        
    }
    private void Update()
    {
        if (currentTime > timer)
        {
            StartCoroutine(Colorchange());
            currentTime = 0;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
        

    }

    public IEnumerator Colorchange()
    {
        color.material.color = Random.ColorHSV();
        yield return null;
    }
}
