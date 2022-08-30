using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abC : MonoBehaviour
{
    public float power = 5f;
    private Rigidbody rigid = null;

    void Start()
    {
        if (rigid == null)
        {
            rigid = this.GetComponent<Rigidbody>();
        }

        // === 순간적인 힘 + 무게 적용 === //
        rigid.AddForce(Vector3.up * power, ForceMode.Impulse);
        // === 순간적인 힘 + 무게 적용 === //
    }
}
