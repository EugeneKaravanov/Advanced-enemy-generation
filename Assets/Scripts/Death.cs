using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<TargetMover>())
            Destroy(this.gameObject);
    }
}
