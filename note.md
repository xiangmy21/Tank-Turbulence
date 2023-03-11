- unity Tank资源

- b站up做的

- csdn

  - [(254条消息) Unity 坦克动荡的碰撞反弹_野爹，合体！的博客-CSDN博客](https://blog.csdn.net/weixin_46522912/article/details/121444963)

    [(254条消息) 基于C++的坦克动荡游戏_c++坦克游戏_biyezuopin的博客-CSDN博客](https://blog.csdn.net/sheziqiong/article/details/125703912)

- 知乎有一篇3D的

- github



生成地图的逻辑是单个方块随机生成周边的围墙，中间是空地。多个方块组合铺满地图范围，地图边界都是围墙。

[「Unity」坦克动荡小游戏（一） - 知乎 (zhihu.com)](https://zhuanlan.zhihu.com/p/56284371)

[Unity3D游戏项目教程-我要自学网 (51zxw.net)](https://www.51zxw.net/List.aspx?cid=467)

## Process

- 碰撞设定：
  - 坦克需要手动控制移动，但是**可以不是Kinematic刚体**！Kinematic的意思是只由脚本控制。实际上脚本可以控制任意刚体。坦克设为Dynamic刚体，阻力和重力设为0.
  - 子弹与墙壁需要自动碰撞，子弹是Dynamic刚体，墙只需加上Collider，但为了合并碰撞盒设成了Static刚体。
  - 坦克、子弹 与 墙壁的碰撞都交给unity，那么就不能设置触发器了。子弹和坦克的碰撞就只能OnCollision检测了。注意OnCollision里面获取tag是 collison.gameObject.tag
  - 解决坦克入墙抖动问题：[(254条消息) Unity下，移动撞墙后抖动的解决方案_神一般的狄狄的博客-CSDN博客](https://blog.csdn.net/qq_37776196/article/details/114637972)
  - 坦克与坦克的碰撞消除，子弹与子弹的碰撞消除（改layer）。

IDEA:

- 翻转操作，变成一条线，可以躲迎面来的子弹，但是会被侧面来的子弹打中。

- 防护盾，前面来一条光线墙

开发：

- 地图
- 激光

问题：

- 激光反弹怎么做
- 撞墙抖动怎么消
- 发射音效延迟怎么整

## BUG

- 前进是Translate，默认是自身坐标轴，所以如果图片是朝上的，那么直接朝y轴走就行。
