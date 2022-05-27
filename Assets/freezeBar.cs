using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class freezeBar : MonoBehaviour
{
    float freeze = 100;
    float dFreeze = 1;
    public RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        freeze -= dFreeze * Time.deltaTime;
        var tmp = rectTransform.sizeDelta;
        tmp.x = freeze*2;
        rectTransform.sizeDelta = tmp;

        if (freeze <= 0.0f)
        {
            SceneManager.LoadScene("Retry", LoadSceneMode.Single);
        }
    }

    public void die()
    {
        freeze = 0.0f;
    }
}
