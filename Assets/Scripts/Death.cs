using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<TargetMover>(out TargetMover targetMover))
            Destroy(this.gameObject);
    }
}
