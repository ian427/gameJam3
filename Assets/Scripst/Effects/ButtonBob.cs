using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBob : MonoBehaviour
{

    private bool CanRun = true; 
    private float delayBetweenScales = 0.01f;
    Vector3 Scaleup = new Vector3(0.01f, 0.01f, 0.01f);

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       //OnPointerEnter();
    }
    public void OnPointerEnter()
    {
        if (CanRun == true)
        {
            StartCoroutine(ScaleObject());
            CanRun = false;
        }
    }

    IEnumerator ScaleObject()
    {
        for (int i = 0; i < 27; i++)
        {
            transform.localScale += Scaleup;
            yield return new WaitForSeconds(delayBetweenScales);
            Debug.Log("out");
        }

        for (int i = 0; i < 27; i++)
        {
            transform.localScale -= Scaleup;
            yield return new WaitForSeconds(delayBetweenScales);
            Debug.Log("in");
        }
        CanRun = true;
    }
}

//https://discussions.unity.com/t/4-6-ui-how-to-detect-mouse-over-on-button/115607
//https://docs.unity3d.com/ScriptReference/Mathf.PingPong.html
