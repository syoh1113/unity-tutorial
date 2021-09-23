using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int coinCount;
    public GameManager manager;
    AudioSource audioSound;
    bool isJump;
    Rigidbody rigid;

    void Awake()
    {
        jumpPower = 30;
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audioSound = GetComponent<AudioSource>();
    }

    private void Update() 
    {
        if (!isJump && Input.GetButtonDown("Jump")) {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    // 물리 엔진 계산에 대해서는 FixedUpdate() 함수에서 구현하는 것을 권장함.
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "floorTag") {
            isJump = false;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "coinTag") {
            Coin coin = other.GetComponent<Coin>();
            this.coinCount++;
            audioSound.Play();
            other.gameObject.SetActive(false);
            manager.GetItemCount(this.coinCount);
        }
        else if (other.tag == "finishTag") {
            if (coinCount == manager.totalItemCount) {
                // Game Clear!
                SceneManager.LoadScene("coinEating_1");
            }
            else {
                // Restart
                SceneManager.LoadScene("coinEating");
            }
        }
        else if (other.tag == "managerTag") {
            SceneManager.LoadScene("coinEating");
        }
    }
}
