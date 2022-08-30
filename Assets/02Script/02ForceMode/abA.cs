using UnityEngine;

public class abA : MonoBehaviour
{
    public float power = 5f;
    private Rigidbody rigid = null;

    void Start()
    {
        if (rigid == null)
        {
            rigid = this.GetComponent<Rigidbody>();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            print("Collision " + this.gameObject.name);
            // === 연속적인 힘 + 무게 무시 === //
            rigid.AddForce(Vector3.forward * power, ForceMode.Acceleration);
            // === 연속적인 힘 + 무게 무시 === //
        }
    }
}
