using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!"); // Chạy 1 lần duy nhất khi nhấn Play
    }

    void Update()
    {
        Debug.Log("Update called! " + Time.frameCount); // Chạy liên tục mỗi khung hình
    }
}