using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abB : MonoBehaviour
{
    public float power = 5f;
    private Rigidbody rigid = null;

    void Start()
    {
        if (rigid == null)
        {
            rigid = this.GetComponent<Rigidbody>();
        }

        // === 연속적인 힘 + 무게 적용 === //
        rigid.AddForce(Vector3.forward * power, ForceMode.Force);
        // === 연속적인 힘 + 무게 적용 === //
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            print("Collision " + this.gameObject.name);
            // === 연속적인 힘 + 무게 적용 === //
            rigid.AddForce(Vector3.forward * power, ForceMode.Force);
            // === 연속적인 힘 + 무게 적용 === //
        }
    }
}
