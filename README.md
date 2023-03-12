# Tank-Turbulence
尝试复刻童年经典坦克动荡，制作中

## 版本
使用 Unity 2021.3.6f1c1 制作。

## 使用说明
- 绿色坦克：方向键上下控制前进后退，左右控制旋转，M键开火。
- 红色坦克：ED控制前进后退，SF控制旋转，Q键开火。
- 蓝色坦克：鼠标控制，坦克会朝向鼠标并随鼠标移动(直至鼠标在坦克某一半径范围内)，鼠标左键开火。

每人只有5发子弹，子弹发出后击中坦克或飞行15秒后自动消失，击中或消失后会补充相应子弹。

最后留下的人获胜，当只剩一辆坦克时会准备计分(UI还没写)，如果2.5秒内最后一辆坦克没有被击中则+1分，否则都不加。

PS：此游戏需要两人或三人共同游玩，趣味性很大程度上依赖各位的~~智障操作和~~风骚走位。

PS2：UI还没做，可能要自己调整一下窗口。

## 设计说明
除了现在已经实现的核心骨架（子弹反弹），预期实现的功能还有：
- 道具：激光炮（快速可反弹直线攻击），遥控导弹（方向键控制），追踪弹（发出一段时间后锁定最近敌人自动追踪），大炮弹（发出后再次开火会爆裂开），穿墙能量束（直线穿墙，可部分弯曲），等等
- 随机地图：现在的地图是用tilemap手画的，后期会尝试随机生成不同大小的地图，可能会出现开局就混战的有趣情况。
- AI：添加AI对手，给游戏上点难度。
- 增加UI界面、模式选择和计分板
- 尝试魔改，添加自创道具，如短直线护盾、坦克y轴翻转（变成一条线，可躲避迎面来的子弹）等。