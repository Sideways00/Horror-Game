using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class HandPunch : MonoBehaviour
{
    public Transform leftHand;
    public Transform rightHand;

    public float punchDistance = 0.5f;
    public float punchSpeed = 8f;

    private Vector3 leftStartPosition;
    private Vector3 rightStartPosition;

    private bool leftPunching = false;
    private bool rightPunching = false;

    void Start()
    {
        leftStartPosition = leftHand.localPosition;
        rightStartPosition = rightHand.localPosition;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && !leftPunching)
        {
            StartCoroutine(PunchLeftHand());
        }

        if (Mouse.current.rightButton.wasPressedThisFrame && !rightPunching)
        {
            StartCoroutine(PunchRightHand());
        }
    }

    IEnumerator PunchLeftHand()
    {
        leftPunching = true;

        Vector3 punchPosition =
            leftStartPosition + Vector3.forward * punchDistance;

        while (Vector3.Distance(leftHand.localPosition, punchPosition) > 0.01f)
        {
            leftHand.localPosition = Vector3.MoveTowards(
                leftHand.localPosition,
                punchPosition,
                punchSpeed * Time.deltaTime
            );

            yield return null;
        }

        while (Vector3.Distance(leftHand.localPosition, leftStartPosition) > 0.01f)
        {
            leftHand.localPosition = Vector3.MoveTowards(
                leftHand.localPosition,
                leftStartPosition,
                punchSpeed * Time.deltaTime
            );

            yield return null;
        }

        leftPunching = false;
    }

    IEnumerator PunchRightHand()
    {
        rightPunching = true;

        Vector3 punchPosition =
            rightStartPosition + Vector3.forward * punchDistance;

        while (Vector3.Distance(rightHand.localPosition, punchPosition) > 0.01f)
        {
            rightHand.localPosition = Vector3.MoveTowards(
                rightHand.localPosition,
                punchPosition,
                punchSpeed * Time.deltaTime
            );

            yield return null;
        }

        while (Vector3.Distance(rightHand.localPosition, rightStartPosition) > 0.01f)
        {
            rightHand.localPosition = Vector3.MoveTowards(
                rightHand.localPosition,
                rightStartPosition,
                punchSpeed * Time.deltaTime
            );

            yield return null;
        }

        rightPunching = false;
    }
}
