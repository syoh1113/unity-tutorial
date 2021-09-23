using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalItemCount;
    public Text stageCountText;

    void Awake()
    {
        stageCountText.text = "0 / " + totalItemCount;
    }

    public void GetItemCount(int count)
    {
        stageCountText.text = count.ToString() + " / " + totalItemCount;
    }
}
