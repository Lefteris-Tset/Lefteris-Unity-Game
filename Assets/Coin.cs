using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 180f;
    private void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerHandler ph = other.GetComponent<PlayerHandler>();
        if (ph != null)
        {
            ph.IncreasePoints();
            Destroy(this.gameObject);
        }
    }
}
