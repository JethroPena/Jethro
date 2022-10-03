using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class S3GameHandler1 : MonoBehaviour
{
    public GameObject P2Health;
    public int player2HP = 100;
    public VideoClip VD6, VD7, VD8, VD9, VD10;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        P2Health.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player2HP + "";
    }
     void dealDamage(int damageAmount, int playerHP){
            playerHP -= damageAmount;
            player2HP = playerHP;
    }

    void attack(float accuracy, IEnumerator attackname, VideoClip video){
        int x = Random.Range(1, 101);

        if(x <= accuracy){
            StartCoroutine(attackname);
            Debug.Log("Attack Success!");
        }
        else{
            Debug.Log("Attack Missed!");
        }
    }
    
    public void p1Lowpunch(){
        attack(95, p1Lowpunchdelay(), VD6);
    }
    public void p1Highpunch(){
        attack(75, p1Highpunchdelay(), VD7);
    }
    public void p1Lowkick(){
        attack(90, p1Lowkickdelay(), VD8);
    }
    public void p1Highkick(){
        attack(65, p1Highkickdelay(), VD9);
    }
    public void p1Special(){
        attack(95, p1Highkickdelay(), VD10);
    }
    IEnumerator p1Highpunchdelay(){
        yield return new WaitForSeconds(3F);
        dealDamage(10, player2HP);
    }
    IEnumerator p1Lowpunchdelay(){
        yield return new WaitForSeconds(2F);
        dealDamage(5, player2HP);
    }
    IEnumerator p1Lowkickdelay(){
        yield return new WaitForSeconds(2F);
        dealDamage(3, player2HP);
    }
    IEnumerator p1Highkickdelay(){
        yield return new WaitForSeconds(2F);
        dealDamage(7, player2HP);
    }
    IEnumerator p1Specialdelay(){
        yield return new WaitForSeconds(2F);
        dealDamage(15, player2HP);
    }
}
