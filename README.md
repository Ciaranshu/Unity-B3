
A.  **Background**

> The topic of our group project derived from the second given topic,
> "Tomb Raider". The original background of this story is: Egypt Tomb
> has a lot of treasures. One day, a raider gets into the tomb and wants
> to get the treasures. However, the tomb is like a maze and the
> treasures are containing in a chamber. The raider needs to find out
> the treasures and leave the tomb safely. Enemies and traps are waiting
> for him. Fortunately, the raider has some equipment that can help him.
>
> However, to enhance the entertainment of our game, this third-personal
> shooting game bases on a slightly different story: a girl fights with
> monsters in the 3D maze and tries to save her missing boyfriend.
>
> Technically, the Unity5 engine is used to create this 3D game. Hence,
> we are able to display the maze and the game character in a vivid 3D
> version. Most of those characters and scenes are built by voxel
> modeling, contributing to the unique game style, voxel style. This
> game style is widely spread with the population of the famous sandbox
> game, Minecraft. With the totally original game model, we are going to
> develop a third-personal game sharing the similar eye-catching element
> with the well-known Minecraft.
>
> Furthermore, our objectives include building an attractive 3D game
> with relative high completeness, incidentally with upgrading our
> professional skills in the field of data structure We will stick to
> the basic requirement to finish the first step of our game, then to
> create more funny and delicate components to make it more wonderful.

B.  **Design Principle**

> 1\. Characters and Scenes Building
>
> The single-minded girl, 3 kinds of monsters with different attacking
> skills, a powerful boss and mazes will all built in voxel modelling.
>
> 2\. Moving with Camera Following
>
> The moving and camera following will all follow TPS game type. This
> will endow our game with sense of identification between the player
> and the protagonist.
>
> 3\. Background Music
>
> We have found some compelling music to cooperate with the game.
>
> 4\. Life Value
>
> Player will have a life value to show how much remaining life with the
> range from 100 to 0. The value will decrease when the player is hit by
> monsters and increase when encounter those props.
>
> 5\. The Frequency the Monsters Show in
>
> When the player collides those transparent wall equipped with
> collider, the monster will show out only one time. This feature can be
> regarded as that the whole room of our designed maze are divided into
> several sub-chambers by those transparent walls.
>
> 6\. Three Different Kinds of Monster
>
> The first type is the guard, they will keep chasing the player and
> want to touch player. The second one is Necromancer, they will use
> magic to make hurt. The last kind is Ninja from remote Japan, they
> will randomly choose their direction to run straight forwards to hit
> player and then suicide. The monster models are all designed by
> ourselves.
>
> 7\. Monster Life Value
>
> Monster also have life value, but commonly will not show out.
>
> 8\. Gun shooting
>
> Player use gun to hit monsters, but the number of bullets is limited
> in an accurate number. And we will make the special effects of
> shooting and blood when monster dead. When monsters are hit by the
> bullet, its life value will decrease.
>
> 9\. Resurrection
>
> When the life value of player become zero, player will dead and
> resurrection in the start point in the current map.
>
> 10\. Shadow
>
> We use the part of the engine to make the shadow to make the game more
> real.
>
> 11\. Props
>
> The bullet bags and blood bags will appear in same special places.
> When player meet this props, the number of bullets or life value will
> increase.
>
> 12\. GUI
>
> Building with 3D GUI and special menu page.
>
> 13\. Boss
>
> There is a final boss that exists in our game with detailed
> information about its blood value and the decrease of its blood value
> during attack. Its first skill is fire hurt, it can burn through the
> wall to attack the player behind any wall successfully. This skill
> enforces the player not to hide behind the wall for any longer time.
> The second skill is chalk hurt, it can hurt the player out of a long
> distance but cannot fly through the wall. It is powerful because of
> the huge number of the chalks.

C.  **Model Discussion **

> **1. Emery Model:**
>
> (Note: The scene has been cut to many almost same big pieces, every
> piece has its own number)
>
> Check the player tag;
>
> Find the game object have the player tag's position;
>
> Find the piece most close to the object;
>
> Find all way to the target piece;
>
> Find the shortest way;
>
> If the way is not blocked
>
> Move emery through the shortest way;
>
> If the way is blocked
>
> {Find all way to the target piece;
>
> Delete the blocked way;
>
> Find the shortest way;
>
> Move emery through the shortest way;}
>
> Get goal and stop;
>
> **Complexity Analysis: **
>
> Find the game object have the player tag's position: 1;
>
> Find the piece most close to the object: n;
>
> Find all way to the target piece: n2;
>
> Find the wrong way (worst): n\*n2;
>
> Complexity=1+n+n2+n3=θ（n3）
>
> **Relation between Data Structure:**
>
> Abstraction1: The map is into a structure of the position's
> information.
>
> Map = struct{x,y,z};
>
> Abstraction2: Object
>
> Object = struct{tag,name,transition};
>
> Transition = struct{position,scale,rotation};
>
> There are totally 3 different kinds of monster:
>
> The first type is the guard, they will automatically find the closest
> way to get to the player, keep chasing the player and hit player by
> touching the player. During this coding, we use A\* algorithm to get
> near to the player from current position with the nearest best way.
>
> f(n) = g(n) + H(n)
>
> g(n) = sum( previous distance cost)
>
> H(n) = D \* (abs ( current.x -- goal.x ) + abs ( current.y -- goal.y )
> + abs( current.z -- goal.z ))
>
> The second one is Necromancer(wizard), they will use magic to make
> hurt towards the player.
>
> Direction(attack) = sqrt( (player.x-current.x)^2^ +
> (player.y-current.y)^2^ + (player.z-current.z)^2^ )
>
> The last kind is zombie, they will repeatedly go along its way. If
> player touches it, player will be hurt but the zombies will still
> continue its way on the same line.
>
> Zombies.setMiddlePoint(point,distance);
>
> abs(Current.x-middle.x) \< distance
>
> There is a final boss that exists in our game with detailed
> information about its blood value and the decrease of its blood value
> during attack. Its first skill is fire hurt, it can burn through the
> wall to attack the player behind any wall successfully. This skill
> enforces the player not to hide behind the wall for any longer time.
> The second skill is chalk hurt, it can hurt the player out of a long
> distance but can not fly through the wall. It is powerful because of
> the huge number of the chalks.
>
> Boss.moveDirection = sqrt( (player.x-current.x)^2^ +
> (player.y-current.y)^2^)
>
> Boss.attackeDirection = sqrt( (player.x-current.x)^2^ +
> (player.y-current.y)^2^)
>
> BossAttack = struct{attackCore,startTime,waitTime,endTime}
>
> **2. Enemy show function:**
>
> Find the target collision be stroked by another one;
>
> Check the tag of another collision;
>
> If tag!=player's tag
>
> Nothing happened;
>
> If tag==player's tag
>
> {
>
> If (bool createfinish=false)
>
> Use create function (IEnumerator create)
>
> }
>
> IEnumerator create:
>
> Check the emery show out points' size;
>
> If size\<=0
>
> Function stop and return;
>
> If size\>0
>
> Function continue;
>
> Get emery number and wait time;
>
> For(emery number)
>
> {create emery ;
>
> Yeild return wait time};
>
> Set bool createfinish=ture;
>
> **Complexity Analysis:**
>
> Check tag: 1;
>
> Check the emery show out points' size:1;
>
> For(emery number):n;
>
> Complexity= θ（n）
>
> **Relation between Data Structure:**
>
> Background process's iterator save the time. It can be used to
> traverse some or all the elements in a standard template library
> container, and each iterator object represents a determined address in
> the container. The iterator modifies the interface of a regular
> pointer, which is a conceptual abstraction: those things that behave
> like an iterator can be called iterators. However, the iterator has a
> lot of different capabilities, it can abstract containers and general
> algorithm organic unity.
>
> The iterator enables the developer to support the foreach iteration in
> the class or structure without having to implement the IEnumerable or
> IEnumerator interface as a whole. Just provide an iterator that
> traverses the data structure in the class. When the compiler detects
> an iterator, the IEnumerable interface or the Current, MoveNext, and
> Dispose methods of the IEnumerator interface are automatically
> generated.
>
> An iterator is a piece of code that can return an ordered sequence of
> the same type of value; The iterator can be used as a code body for a
> method, operator, or get accessor; The iterator code uses the
> yieldreturn statement to return each element in turn, and the yield
> break terminates the iteration; You can implement multiple iterators
> in a class. Each iterator must have a unique name like any class
> member and can be called by the client in the foreach statement. The
> code is called as follows: foreach (int x in SimpleClass .Iterator2)
> {}; The iterator\'s return type must be any of IEnumerable and
> IEnumerator; The iterator is a block of ordered strings that produce
> values, unlike regular block blocks where one or more yield statements
> exist; The iterator is not a member, it is just a way to implement a
> function member. It is important to understand that a member that is
> implemented by an iterator can be overridden and overloaded by other
> members that may or may not be implemented by an iterator ; Iterator
> blocks are not unique elements in the C \# syntax, which are limited
> in several respects and are primarily used in the semantics of
> function member declarations, which are only syntactically just
> blocks; The yield keyword is used to specify the value returned. When
> the yieldreturn statement is reached, the current location is saved.
> The next time the iterator is called, it will resume execution from
> this location. The iterator is particularly useful for collection
> classes, and it provides a simple way to iterate over an unusually
> used data structure (such as a binary tree).
>
> **3. Props show function: **
>
> IEnumerator create:
>
> Check the props show out points' size;
>
> If size\<=0
>
> Function stop and return;
>
> If size\>0
>
> Function continue;
>
> Get props number and wait time;
>
> For(props number)
>
> {create props;
>
> Yeild return wait time};
>
> **Complexity Analysis:**
>
> Check the props show out points' size:1
>
> For(props number):n;
>
> Complexity= θ（n）
>
> **Relation between Data Structure:**
>
> Background process's iterator save the time. An iterator is a design
> pattern that is an object that traverses and selects objects in a
> sequence, and the developer does not need to understand the underlying
> structure of the sequence. An iterator is often called a
> \"lightweight\" object because the cost of creating it is small.
>
> Iterator, which provides a way to sequentially access the various
> elements of an aggregate object without exposing the internal
> representation of the object. When you need to access an aggregated
> object, and regardless of what these objects need to traverse, you
> should consider using the iterator mode. In addition, it is possible
> to consider using the iterator mode when it is necessary to traverse a
> plurality of ways of aggregation. The iterator pattern provides a
> uniform interface for traversing different aggregate structures such
> as start, next, whether to end, and which one of the current ones.
>
> **4. Main Character Model:**
>
> (Note: The scene has been cut into many almost same big pieces, every
> piece has its own number)

1)  Moving and fire control

    Set the values of life bar, left bullets, character moving speed

    Get the component of main character

    Connect key "a", "s", "d", "w" to unit vector of different
    directions.

    When key above are pressed,

    Produce a vector

    Component move and rotate along the vector

    Connect "space" to bullet fire

    When "space" is pressed,

    Bullets will be fired and bullet number decreased

2)  Props function

    Get the component of main character

    When component meet object with tag "life" or "bullet",

    Add corresponding life value and bullet value

    Refresh prop queue and reset props in map

    Ensure they are valid

3)  Resurrection function

    If life value is equal to or less than 0,

    Store the player history in a queue and sort it

    Reset parameters of main character and the position of main
    character to the beginning

> **Complexity Analysis: **

1)  Get the component of main character: 1

    Connect key "a", "s", "d", "w" to unit vector of different
    directions: 1

    When key above are pressed, produce a vector: 1

    Component move and rotate along the vector: 1

    Connect "space" to bullet fire: 1

    When "space" is pressed, bullet will be fired and bullet number
    decreased: 1

    Complexity=θ（1）

2)  Get the component of main character: 1

    When component meet object with tag "life" or "bullet" in case
    statement,

    Add corresponding life value and bullet value: 1

    Refresh prop queue and reset props in map: n

    Ensure they are valid

    Complexity=θ（n）

3)  If life value is equal to or less than 0,

    Store the player history in a queue and sort it: 1+n+nlogn

    Reset parameters of main character and the position of main
    character to the beginning: 1

    Complexity=θ（nlogn）

> **Relation between Data Structure:**
>
> Abstraction1: The position information in the maps.
>
> Map = struct{x,y,z};
>
> Abstraction2: PlayerCtrl =
> struct{tag,name,transition,isDead,hp,ammo,moveSpeed,rotateSpeed};
>
> Transition = struct{position,scale,rotation};
>
> Abstraction3:hpbar=struct{hpnumber}
>
> Abstraction4:ammo=struct{ammoNumber}

From the beginning, initialize the life and bullet value.

hpbar.fillAmount = (float)hp / 100;

> hpnumber.text = hp.ToString();

ammoNumber.text = ammo.ToString();

v = Input.GetAxis (\"Vertical\");

Initialize the other basis parameters as well.

private Transform tr;

//移动速度变量

public float moveSpeed=10.0f;

//旋转速度变量

public float rotSpeed=100.0f;

//初始化血量

public int hp =100;

//初始化弹药数量

public int ammo = 100;

//死亡状态

public bool isDead = false;

//复活等待时间

private float waitingTime=3.0f;

Use Player's transition to implement moving control which is related to
Map struct

//主人公移动

Vector3 moveDir = (Vector3.forward \* v);

> tr.Translate(moveDir.normalized \* Time.deltaTime \* moveSpeed,
> Space.Self);

//主人公旋转

> tr.Rotate(Vector3.up \* Time.deltaTime \* rotSpeed \*
> Input.GetAxis(\"Horizontal\"));

When resetting the current map.

//等待复活时间 期间不可移动

moveSpeed = 0;

rotSpeed = 0;

yield return new WaitForSeconds(waitingTime);

//重置人物血量

hp = 100;

//重置人物弹药量

if (ammo \< 100) ammo = 100;

//在某一位置复活

tr.position = new Vector3(0.0f, 0.0f, 0.0f);

> **5. Camera following:**

Set the distance, height related to the main character object

Keep camera look at the main character object

Use dampTrace to make the tracing fluent

> **Complexity Analysis: **

Set the distance, height related to the main character object: 1

Keep camera look at the main character object: 1

Use damp trace to make the tracing fluent: 1

Complexity=θ（1）

> **Relation between Data Structure:**
>
> Abstraction1: The position information in the maps.
>
> Map = struct{x,y,z};
>
> Abstraction2: The following camera.
>
> CameraFollow = struct{dist,height,dampTrace};

At the beginning, set the parameters of camera.

//public Transform targetTr;//主人公对象Transform

//public float dist = 2.5f;//摄像机与主人公距离

//public float height = 1.0f;//摄像机高度

//public float dampTrace = 100.0f;//平滑追踪变量

private Transform tr;//摄像机Transform

Change the angle of camera when necessary.

//放置在触发斜坡处，以改变Camera视角

Vector3 rotation = tr.localEulerAngles;

rotation.x = 9f; // 在这里修改坐标轴的值

tr.localEulerAngles = rotation;

> **6. Bullet Control Model:**
>
> **-Bullet Object Pool:**
>
> Create a list data structure to be the container of an object pool;
>
> Define the attributes and detail of the bullet which is the element of
> object pool;
>
> Dynamic generate a group of bullets and link it to its corresponding
> object pool;
>
> Trigger the bullet by popping up the last created object in the object
> pool;
>
> Attach this popped objected with physical initialization according to
> the state of player;

Delete the bullet from the memory when it hit enemies or the frontier of
scene.

If the object pool is empty, recreate a group of bullets.

> **Complexity Analysis: **
>
> Create a list data structure to be the container of an object pool: 1;
>
> Define the attributes and detail of the bullet which is the element of
> object pool: 1;
>
> Dynamic generate a group of bullets and link it to its corresponding
> object pool: n;
>
> Trigger the bullet by popping up the last created object in the object
> pool:1;
>
> Attach popped objected with initialization according to the state of
> player：1

Delete the bullet from the memory when it hit enemies or the frontier of
scene: nlog2n.

If the object pool is empty, recreate a group of bullets: n.

> Complexity=c+2n+nlog2n=θ（nlog2n）
>
> **Relation between Data Structure:**
>
> Those game objects which are repeatedly and rapidly created and
> destroyed will incredibly decrease the game performance and the
> gameplay, since its disordered allocation in the memory will cause
> demanding challenge for restricted computational resources. One of the
> good solution for this tricky and inevitable problem is creating an
> object pool and then picking up the object from it instead of rapidly
> creating and deleting those identical objects.
>
> After consideration, the bullet objects in our game are equipped with
> this efficient mechanism to ensure our game performance. At the
> beginning, a data structure, list, will be created to implement the
> container of bullet object pool. This can be regarded as a set. The
> element in this set is the object of the object pool.
>
> Firstly, we should to develop an instance which has specific
> definition of the bullet object, including attribution of rigid body,
> mass and model. Then, a function should be designed to dynamic arrange
> the list of object pool. Roughly, this process is like the
> manipulation of a stack with the functionality of first-in-last-out.
> After that, if the bullet is triggered by the user. This program
> should firstly ask the object pool for popping out a bullet object and
> then initialize its speed and position according to the coordinate of
> the player's attributions. Under the circumstance that there is not
> any object that could be popped in the object pool. The program will
> instantiate a new object and then set its state as active. Then, it
> will delete this new created object from the object pool.

D.  **Demonstration**

> ![WechatIMG6](/Unity B3/Assets/image2.png)
>
> In the start page, there are 3 level options. Different level options
> are corresponding to various attacking abilities and generating rates
> of enemies.
>
> ![WechatIMG3](/Unity B3/Assets/image3.png){![WechatIMG4](/Unity B3/Assets/image4.png)
>
> After choosing the level, player will get into the game page. I am the
> colorful girl with 100 blood value and 100 number of bullets. Press
> ↑↓←→ to control the girl and press blank to send out bullet.
>
> ![WechatIMG7](/Unity B3/Assets/image5.png)
>
> Well-designed UI: During the game, Player can press
> ![](/Unity B3/Assets/image6.png) to choose continuing my game or quit
> the game. The life bar and ammo indicate the gaming state of
> player.![](/Unity B3/Assets/image7.png) ![](/Unity B3/Assets/image8.png)
>
> Props for recovering bullets and life value.
>
> ![](/Unity B3/Assets/image9.png)
>
> ![](/Unity B3/Assets/image10.png)
>
> This is the trap which will slow down the movement of player.

E.  **Conclusion **

> Summarize the project and mention its special features again.
>
> To sum up, we developed a third-personal shooting game with
> outstanding 3D graphics and gameplay. Literally, this game is totally
> base on a 3D physical simulative engine and advanced graphic system.
> Equipped with those techniques and our solid understanding of data
> structure. We not only successfully finish all developments of
> required and extra functionality, but also facilitate the efficiency
> of this game project by closely analyzing the time and storage
> complexity of our game.
>
> Additionally, we are proud of that our game enjoys the following
> features:

1.  3D third-personal shooting game

2.  Voxel game style and original model

3.  Outstanding efficient optimization

4.  Hidden divided chamber and complicated structure of maze

5.  Smart and proper tracking ability of enemies

6.  Well-developed UI and background music

7.  Compelling special effects of attacks

8.  Effective management of those game object

<!-- -->

F.  **Reference:**

<!-- -->

1.  Clark Kerr. *Unity 5 Master Class: Practical Game Development with
    Unity*. Post and Telecom Press, 2016.

2.  Mark Allen Weiss. *Data Structures and Algorithm Analysis in C++*.
    Post and Telecom Press, 2013.

3.  Aisha Ihram. *Quick C\#*. www.codeproject.com.

<!-- -->
