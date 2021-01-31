using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycasting : MonoBehaviour
{
    [SerializeField] float range;

    private IInterectable currentTarget;
    private Camera mainCamera;

    private Vector3 point;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        RaycastForInteractable();

        if (Input.GetMouseButtonDown(0))
        {
            if (currentTarget != null)
            {
                /* if (currentTarget.CanInteract())
                { */
                currentTarget.OnInteract(point);
                // }
            }
        }

    }

    private void RaycastForInteractable()
    {
        RaycastHit hit;

        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);


        if (Physics.Raycast(ray, out hit, range))
        {
            IInterectable interactable = hit.collider.GetComponent<IInterectable>();

            if (interactable != null)
            {
                Debug.DrawLine(ray.origin, hit.point, Color.red, 0.1f);

                point = hit.point;

                if (hit.distance <= range)
                {
                    if (interactable == currentTarget)
                    {
                        return;
                    }
                    else if (currentTarget != null)
                    {
                        currentTarget.OnEndHover();
                        currentTarget = interactable;
                        /* if (currentTarget.CanInteract())
                        { */
                        currentTarget.OnStartHover();
                        // }
                        return;
                    }
                    else
                    {
                        currentTarget = interactable;
                        /* if (currentTarget.CanInteract())
                        { */
                        currentTarget.OnStartHover();
                        // }
                        return;
                    }
                }
                else
                {
                    if (currentTarget != null)
                    {
                        currentTarget.OnEndHover();
                        currentTarget = null;
                        return;
                    }
                }
            }
            else
            {
                Debug.DrawLine(ray.origin, ray.direction * range, Color.white, 0.1f);

                if (currentTarget != null)
                {
                    currentTarget.OnEndHover();
                    currentTarget = null;
                    return;
                }
            }
        }
        else
        {
            if (currentTarget != null)
            {
                currentTarget.OnEndHover();
                currentTarget = null;
                return;
            }
        }
    }
}
