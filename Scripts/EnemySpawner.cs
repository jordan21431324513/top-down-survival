using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public float TimeBetweenSpawns;
    public float SpawnRadius;
    public GameObject EnemyPrefab;
    float f;

    private void Start()
    {
        f = TimeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        f -= Time.deltaTime;
        if(f <= 0)
        {
            Instantiate(EnemyPrefab, Random.insideUnitCircle * SpawnRadius, new Quaternion());
            f = TimeBetweenSpawns;
        }

        TimeBetweenSpawns -= Time.deltaTime / 30;
        if (TimeBetweenSpawns <= 0.5f)
        {
            SceneManager.LoadScene("Win");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, SpawnRadius);
    }
}
