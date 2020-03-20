# AlphaArea

해당 Asset은 유니티에서 UGUI를 사용할 때, 마름모꼴과 같은 UI를 사용하게 되면 투명한 곳 까지 클릭 되는 문제가 발생한다.  
그래서 해당 Asset을 사용하게되면 Alpha의 허용 정도를 정하여 알파 영역은 클릭되지 않도록 해주는 Asset이다.

## How to use Asset?
1.먼저 해당 Asset을 프로젝트에 내려받습니다.

![ex1](https://github.com/bnm000215/unityUIAlphaArea/blob/master/Documentation/Image/i1.png)  
2.사용할 UI 이미지를 준비합니다.  
![ex1](https://github.com/bnm000215/unityUIAlphaArea/blob/master/Documentation/Image/i2.png)    
3.해당 이미지의 Advanced에서 읽기/쓰기를 체크합니다.  
![ex1](https://github.com/bnm000215/unityUIAlphaArea/blob/master/Documentation/Image/i3.png)    
4.사용할 버튼 오브젝트에 `Alpha Area`컴포넌트를 추가해줍니다.  
5.Alpha 값이 0으로 갈수록 알파 영역은 인식되지 않습니다. (1은 전체 클릭 영역)
