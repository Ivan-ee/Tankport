using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPlacement : MonoBehaviour
{
    public LayerMask clickMask;
    public GameObject portalPreview, leftPortal, rightPortal;
    public bool allowedToPlace = true;

    private Vector3 clickPosition;
    private Vector3 portalCenter;

    private void Start()
    {
        leftPortal.SetActive(false);
        rightPortal.SetActive(false);
        portalPreview.SetActive(false);
        portalCenter = new Vector3(0, 0, -5);
    }

    private void Update()
    {
        if (allowedToPlace)
        {
            portalPreview.SetActive(true);
            PositionPortalPreview();
            PlacePortal();
        }
        else
        {
            portalPreview.SetActive(false);
        }
    }

    void PositionPortalPreview()
    {
        clickPosition = -Vector3.one;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 300f) && !clickMask.Equals(hit.collider.gameObject.layer))
        {
            clickPosition = hit.point;
        }

        portalPreview.transform.position = clickPosition + portalCenter;
    }

    void PlacePortal()
    {
        if (Input.GetMouseButtonDown(0))
        {
            leftPortal.SetActive(true);
            leftPortal.GetComponent<AudioSource>().Play();
            leftPortal.GetComponent<Animator>().Play(0);
            leftPortal.transform.position = clickPosition + portalCenter;
        }

        if (Input.GetMouseButtonDown(1))
        {
            rightPortal.SetActive(true);
            rightPortal.GetComponent<AudioSource>().Play();
            rightPortal.GetComponent<Animator>().Play(0);
            rightPortal.transform.position = clickPosition + portalCenter;
        }
    }
}