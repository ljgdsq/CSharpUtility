using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    up,down,left,right
}

public class RoutingObject : MonoBehaviour
{
    public int x;
    public int y;
    public int targetDistance;
    public int moveDistance;
    public int moveSum; // A*��ֵ Ŀ�����+�ƶ�����
    public bool isCanMove;
    public Direction direction;
}
