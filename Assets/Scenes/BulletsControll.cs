using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsControll : MonoBehaviour
{
    public Transform randomT;   //랜덤한 위치를 설정
    public GameObject Capsule;   //총알 객체
    public Text gameover;

    void Start()
    {
        gameover.text = "";
        InvokeRepeating("FallBullet", 1, 5); 
    }

    void FallBullet()   //총알이 떨어지도록 함
    {
        float randomX = Random.Range(-50f, 50f);
        if (true)
        {
            //Debug.Log("생성");
            randomT.position = new Vector3(Random.Range(-30f, 30f), 10f, Random.Range(-30f, 30f));    //랜덤한 좌표 설정
            GameObject instance = Instantiate(Capsule, randomT.position, randomT.rotation) as GameObject;    //인스턴스를 그 좌표에 생성
            Destroy(instance, 5.0f);    //4초 후에 인스턴스가 사라지도록 함
        }

    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "ArmyPilot")
        {
            Debug.Log("게임 끝");
            gameover.text = "Game Over";
            Application.Quit();
        }
    }

}
