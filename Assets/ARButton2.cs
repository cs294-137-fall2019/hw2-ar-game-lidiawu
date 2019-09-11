using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARButton2 : MonoBehaviour, OnTouch3D
{
    public GameObject ball;

    public void OnTouch(int player)
    {
        Material m_Material = ball.GetComponent<Renderer>().material;
        if (player == 0)
        {
            m_Material.color = Color.blue;
        }
        else
        {
            m_Material.color = Color.red;
        }
        ball.SetActive(true);
    }
}
