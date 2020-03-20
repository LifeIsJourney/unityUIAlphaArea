using System;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/AlphaArea")]
public class AlphaArea : MonoBehaviour
{
    private Image image;

    [SerializeField,Range(0f,1f),Tooltip("이미지 클릭 영역 허용치")]
    private float Alpha = 1f;
    
    private void Awake() => //이미지를 참조합니다.
        image = GetComponent<Image>();
    
    private void Update()
    {
        //알파 값 변경 -> 적용
        var alpha = Mathf.Lerp(1f, 0f, Alpha);
        image.alphaHitTestMinimumThreshold = alpha;
    }
}
