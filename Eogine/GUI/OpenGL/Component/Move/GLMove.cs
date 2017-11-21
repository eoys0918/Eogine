using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace Eogine
{
    public class GLMove : GLComponent
    {
        public enum Direction
        {
            Up,
            Down,
            Front,
            Back,
            Right,
            Left,
        }

        private Direction mMoveDirection = Direction.Front;
        private float mMoveSpeed = 5.0f;
        private bool isMove = false;

        public Direction MoveDirection
        {
            get { return this.mMoveDirection; }
            set { this.mMoveDirection = value; }
        }
        public float MoveSpeed
        {
            get { return this.mMoveSpeed; }
            set { this.mMoveSpeed = value; }
        }

        public GLMove(GLObject glObject)
            : base(GLComponent.TYPE.MOVE, glObject)
        {
        }

        private Vector3 GetMoveVector(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return glObject.vUp * MoveSpeed;
                case Direction.Down:
                    return glObject.vUp * MoveSpeed * -1.0f;
                case Direction.Front:
                    return glObject.vDir * MoveSpeed;
                case Direction.Back:
                    return glObject.vDir * MoveSpeed * -1.0f;
                case Direction.Right:
                    return glObject.vRight * MoveSpeed;
                case Direction.Left:
                    return glObject.vRight * MoveSpeed * -1.0f;
            }
            return Vector3.Zero;
        }
        
        protected override void _Update()
        {
            if(isMove)
            {
                Vector3 vMove = GetMoveVector(MoveDirection);
                glObject.position += vMove;
                glObject.target += vMove;
            }
        }
    }
}
