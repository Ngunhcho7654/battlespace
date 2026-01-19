using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Tìm thành phần hiển thị hình ảnh trên đối tượng này
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Bật/Tắt hiển thị liên tục để tạo hiệu ứng nhấp nháy
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}