using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycasting : MonoBehaviour
{
    [SerializeField] float range;

    private IInterectable currentTarget;
    private Camera mainCamera;

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
                currentTarget.OnInteract();
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
                if (hit.distance <= interactable.MaxRange)
                {
                    if (interactable == currentTarget)
                    {
                        return;
                    }
                    else if (currentTarget != null)
                    {
                        currentTarget.OnEndHover();
                        currentTarget = interactable;
                        currentTarget.OnStartHover();
                        return;
                    }
                    else
                    {
                        currentTarget = interactable;
                        currentTarget.OnStartHover();
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
