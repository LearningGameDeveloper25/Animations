# Animation
## Sprite Sheet
### Add Spritesheet
> ##### Texture Type: Sprite (2D and UI).
> ##### Sprite Mode: Multiple.
> ##### Open Sprite Editor &rarr; Slice &rarr; Isometric Grid. 
> ![alt text](image.png)
> ![alt text](image-1.png)
### Inspector Animator
> ##### Window &rarr; Animation &rarr; Animator. 
> ##### Click: Component want check infor.
> ![alt text](image-2.png)
### Create AnimationController For Player
> ##### Create Player:
> ###### Sprite Renderer &rarr; Sprite: sprite0.
> ###### Animator &rarr; Controller: walk (walk_up, walk_down, walk_right, walk_left).
> ##### Code PlayerController:
> ![alt text](image-4.png) 
> ##### Code AnimationController:
> ![alt text](image-3.png)
## Layered Sprite
### Pivot
> ##### In Unity, the "pivot" is the reference point or rotation point of an object or sprite in 2D/3D space.
### Create AnimationController For Player
> ##### To create a correct animation, the states must be symmetrical.
> ##### Idle
> ![alt text](image-5.png)
> ##### Run
> ![alt text](image-6.png)
> ##### PlayerController
> ![alt text](image-7.png)
> ##### AnimationController
> ![alt text](image-8.png)
## Rigged Animation
### Skinning Editor
> ##### Create Bone.
> ##### Auto Weights &rarr; Associate Bones &rarr; Generate.
> ##### Back Preview Pose
> ![alt text](image-9.png)
## Sprite Swapping
### Sprite Libraries
> ##### Open Sprite Edit &rarr; Catagories rarr; Lables.
> ##### Add Sprite.
> ![alt text](image-10.png)
> ##### HeadAnimator &rarr; Blink: Blending Additive & Weights = 1.
### Add animation by unity
> ##### ![alt text](image-11.png)
