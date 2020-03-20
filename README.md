# AlphaArea

해당 Asset의 기능 :  
유니티에서는 기본적으로 마름모꼴과 같은 UI를 사용하게 되면 투명한 곳 까지 클릭 영역으로 인식 되는 문제가 발생합니다.  
그래서 'AlphaArea'를 사용하게되면 Alpha의 허용 정도를 정하여 알파 영역은 클릭되지 않도록 해주는 Asset입니다.

## How to use Asset?
1.먼저 해당 Asset을 프로젝트에 내려받습니다.

![ex](https://github.com/bnm000215/unityUIAlphaArea/blob/master/Documentation~/Image/i1.png)  
2.사용할 UI 이미지를 준비합니다.  
![ex](https://github.com/bnm000215/unityUIAlphaArea/blob/master/Documentation~/Image/i2.png)    
3.해당 이미지의 Advanced에서 읽기/쓰기를 체크합니다.  
![ex](https://github.com/bnm000215/unityUIAlphaArea/blob/master/Documentation~/Image/i3.png)    
4.사용할 버튼 오브젝트에 `Alpha Area`컴포넌트를 추가해줍니다.  
5.Alpha 값이 0으로 갈수록 알파 영역은 인식되지 않습니다. (1은 전체 클릭 영역)
