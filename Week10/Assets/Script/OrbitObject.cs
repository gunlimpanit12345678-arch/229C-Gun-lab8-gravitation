using UnityEngine;

public class OrbitObject : MonoBehaviour
{
    public Transform target;   // วัตถุที่ต้องการหมุนรอบ
    public float speed = 50f;  // ความเร็วในการหมุน
    public Vector3 axis = Vector3.up; // แกนที่หมุน

    void Update()
    {
        if (target != null)
        {
            transform.RotateAround(target.position, axis, speed * Time.deltaTime);
        }
    }
}
