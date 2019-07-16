using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countPoint : MonoBehaviour
{
    static public int cnt = 0;
    public Text cntText;
    // Start is called before the first frame update
    void Start()
    {
        cntText.text = "Score: " + cnt;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ArmyPilot")
        {
            Destroy(gameObject);
            cnt = cnt + 1;
            Debug.Log("점수: " + cnt);
            cntText.text = "Score: " + cnt;
        }
    }
}
