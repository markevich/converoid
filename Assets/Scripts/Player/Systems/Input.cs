using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
namespace Player.Systems {
    public class Input : ComponentSystem {

        private struct Group {
            public Player.Components.Input PlayerInput;
        }
        protected override void OnUpdate()
        {
            foreach(var entity in GetEntities<Group>()){
                entity.PlayerInput.Horizontal = UnityEngine.Input.GetAxis("Horizontal");
                entity.PlayerInput.Vertical = UnityEngine.Input.GetAxis("Vertical");

                entity.PlayerInput.MouseOnScreenPosition = (Vector2)Camera.main.ScreenToViewportPoint(UnityEngine.Input.mousePosition);
            }
        }
    }
}