using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBob : MonoBehaviour
{
    private Button ThisButton;
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        OnPointerEnter();
    }
    public void OnPointerEnter()
    {

        //  rectTransform.transform.localScale = Mathf.PingPong(new Vector3 (0,0,0), new Vector3(0, 0, 0));
        gameObject.transform.localScale = gameObject.transform.localScale += (1, 1, 1);
        Debug.Log("bounce");
    }

    }
//https://discussions.unity.com/t/4-6-ui-how-to-detect-mouse-over-on-button/115607
//https://docs.unity3d.com/ScriptReference/Mathf.PingPong.html
