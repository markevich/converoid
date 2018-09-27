using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
namespace Player.Systems {
    public class Movement : ComponentSystem {

        private struct Group {
            public Rigidbody2D Rigidbody2D;
            public Transform Transform;
            public Player.Components.Input PlayerInput;

        }
        private Vector2 velocity = new Vector2();
        private float deltaTime;
        protected override void OnUpdate()
        {
            deltaTime = Time.deltaTime;
            foreach(var entity in GetEntities<Group>()){
                velocity.y = entity.PlayerInput.Vertical;
                velocity.x = entity.PlayerInput.Horizontal;
                entity.Rigidbody2D.AddRelativeForce (velocity * 30);

                Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (entity.Transform.position);
                float angle = AngleBetweenTwoPoints(positionOnScreen, entity.PlayerInput.MouseOnScreenPosition) + 90;
                var lerpedRotation = Mathf.MoveTowardsAngle(entity.Rigidbody2D.rotation, angle, 400 * deltaTime);
                entity.Rigidbody2D.MoveRotation(lerpedRotation);
            }
        }

        private float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }
    }
}