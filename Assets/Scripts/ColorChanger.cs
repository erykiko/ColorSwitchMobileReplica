using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] Templates temp;
    bool used = false;
    private Generator gen;
    private void Start() {
        gen = this.transform.parent.Find("Spawn").gameObject.GetComponent<Generator>();
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(!used){
            if(other.gameObject == temp.player){
                temp.player.GetComponent<PlayerController>().ColorSet();
                temp.player.GetComponent<Score>().ScoreAdd(1);
                gen.newObstacle();
                used = true;                          
            }
        }
    }
}
