using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    bool[] ans;

    public GameObject Torch1;
    public GameObject Torch2;
    public GameObject Torch3;
    public GameObject Torch4;
    public GameObject door;

    toggle t1;
    toggle t2;
    toggle t3;
    toggle t4;

    public GameObject endGameObject;

    EndGameScript endGame;

    bool opened = false;

    // Start is called before the first frame update
    void Start()
    {
        ans = new bool[4];
        t1 = Torch1.GetComponent<toggle>();
        t2 = Torch2.GetComponent<toggle>();
        t3 = Torch3.GetComponent<toggle>();
        t4 = Torch4.GetComponent<toggle>();

        endGame = endGameObject.GetComponent<EndGameScript>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        // Debug.Log($"{ans[0]} {ans[1]} {ans[2]} {ans[3]}");

        if (t1.isBurning == ans[0] && t2.isBurning == ans[1] && t3.isBurning == ans[2] && t4.isBurning == ans[3] && !opened)
        {
            door.transform.Rotate(0, -133.953f, 0);
            door.transform.localPosition = new Vector3(0.019f, 0.3524344f, 0.3f);
            endGame.enableEnd();
            opened = true;
        }
    }

    public void setAnsArray(int id, bool value)
    {
        ans[id] = value;
    }
}
