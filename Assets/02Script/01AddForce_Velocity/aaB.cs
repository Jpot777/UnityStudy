using UnityEngine;

public class aaB : MonoBehaviour
{
    public float speed = 0f;
    public bool finish = false;
    private Rigidbody rigid = null;

    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (finish == true)
        {
            return;
        }

        rigid.AddForce(Vector3.right * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            print("Finish " + this.gameObject.name);
            finish = true;
        }
    }
}
