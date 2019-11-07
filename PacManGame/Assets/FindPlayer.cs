using UnityEngine;
using UnityEngine.AI;

public class FindPlayer : MonoBehaviour
{
    public Transform player;
    NavMeshAgent agent;
    Animator animator;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        agent.SetDestination(player.position);

        if (Vector3.Distance(transform.position, player.position) <= 4)
        {
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("attack_03"))
            {
                animator.SetBool("attack_03", true);
            }
        }
        else
        {
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("run"))
            {
                animator.SetBool("run", true);
            }
        }
    }
}
