using UnityEngine;

public class DistanceTransition : Transition
{
    [SerializeField] private float transitionRange;
    [SerializeField] private float rangeSpread;

    private void Start()
    {
        transitionRange += Random.Range(-rangeSpread, rangeSpread);
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, Target.transform.position) < transitionRange)
            NeedTransit = true;
    }
}
