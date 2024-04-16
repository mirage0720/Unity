using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int itmeCount;
    public GameManagerLogic manager;
    bool isJump;
    Rigidbody rigid;

    AudioSource audio;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update() {
        if (Input.GetButtonDown("Jump") && !isJump){
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
        void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
            isJump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item"){
            itmeCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itmeCount);
        }
        else if (other.tag == "Finish"){
            if(itmeCount == manager.totalItemCount) {
                //Game Clear
                if (manager.stage == 2)
                SceneManager.LoadScene(0);
                else
                SceneManager.LoadScene(manager.stage + 1);
            }
            else {
                //Restart..

                SceneManager.LoadScene(manager.stage);
            }


        }
    }
}
