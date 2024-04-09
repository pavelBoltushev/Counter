using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _periodicity;
    [SerializeField] private Text _viewText;

    private int _value = 0;
    private bool _isClicked = true;

    private void Start()
    {
        StartCoroutine(Count());
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _isClicked = !_isClicked;
    }

    private IEnumerator Count()
    {
        var wait = new WaitForSeconds(_periodicity);

        while (true)
        {
            if (_isClicked == false)
            {
                _value++;
                _viewText.text = _value.ToString();                
            }

            yield return wait;
        }
    }
}
