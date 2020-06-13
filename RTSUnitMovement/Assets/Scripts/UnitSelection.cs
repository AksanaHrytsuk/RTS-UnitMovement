using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    public LayerMask unitLayerMask;
    
    private List<Unit> _selectedUnits = new List<Unit>();
    
    // Components
    private Camera _camera;
    private Player _player;

    private void Awake()
    {
        _camera = Camera.main;
        _player = GetComponent<Player>();
    }

    void Update()
    {
        // mouse Down
        if (Input.GetMouseButtonDown(0))
        {
           ToggleSelectionVisual(false);
           _selectedUnits = new List<Unit>();
           
           // отправить позицию миши на экране
           TrySelect(Input.mousePosition);
        }
        
        // вызывается, когда нажимаем ЛКМ
        void TrySelect(Vector2 screenPos)
        {
            // рейкаст от курсора мыши 

            Ray ray = _camera.ScreenPointToRay(screenPos);
            RaycastHit hit;

        }

        void ToggleSelectionVisual(bool selected)
        {
            foreach (Unit unit in _selectedUnits)
            { 
                unit.ToggleSelectionVisual(selected);
            }
        }
    }
}
