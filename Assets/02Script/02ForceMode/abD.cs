using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abD : MonoBehaviour
{
    public float power = 5f;
    private Rigidbody rigid = null;

    void Start()
    {
        if (rigid == null)
        {
            rigid = this.GetComponent<Rigidbody>();
        }

        // === 순간적인 힘 + 무게 무시 === //
        rigid.AddForce(Vector3.up * power, ForceMode.VelocityChange);
        // === 순간적인 힘 + 무게 무시 === //
    }
}
