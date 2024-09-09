# 3D_Cinemachine

# 240909_Playground Scene
1. FreeLook Camera
:  특정 오브젝트 주변을 자유롭게 회전하며, 플레이어가 입력한 값에 따라 카메라의 시점을 제어
Follow: PlayerArmature
Look At: PlayerCameraRoot

2. Blend List Camera
: 두 개 이상의 카메라 간의 부드러운 전환을 위해 사용
Virtual camera Chindren +로 여러개의 카메라 생성 가능

3. State-Driven Camera
: 게임 오브젝트의 상태에 따라 카메라를 전환하는 시스템으로 "애니메이션" 상태에 따라 카메라를 전환할 때 유용하게 사용

4. ClearShot Camera
: 여러 카메라 중 가장 좋은 시야를 제공하는 카메라를 자동으로 선택해주는 시스템으로 "장애물"이나 시야를 가리는 오브젝트가 있을 때, 최적의 카메라 뷰를 선택하여 플레이어가 더 잘 볼 수 있도록 도와줌

5. Dolly Track
: 카메라가 정해진 경로(Track)를 따라 이동하도록 설정할 수 있는 기능으로 카메라의 이동 경로를 미리 설정해두고, 카메라가 이 경로를 따라 이동하면서 캐릭터나 오브젝트를 따라가도록 하는 시스템
(예) Enemy character에 자주 사용

6. Dolly Track with Car
: "자동차"와 같은 차량을 특정 경로를 따라 이동시키는 시스템

7. Target Group Camera
: 여러 개의 타겟(대상)을 그룹으로 묶어, 카메라가 이 그룹의 중심을 추적하고 그 그룹을 "모두 화면에 포함"시키도록 제어하는 기능

8. Mixing Camera
: 여러 개의 카메라 뷰를 믹싱(mixing) 하여 하나의 최종 카메라 뷰를 생성하는 시스템

9. 2D Camera
: 2D 게임 환경에서 카메라의 위치, 움직임, 전환 등을 효율적으로 관리하고, 보다 자연스러운 카메라 연출
"Framing Transposer"를 사용하여 카메라가 타겟을 부드럽게 추적