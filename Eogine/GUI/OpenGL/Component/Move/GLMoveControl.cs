using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using OpenTK;

namespace Eogine
{
    public class GLMoveControl : GLComponent
    {
        public enum Turn
        {
            TurnDirection,
            TurnPositionAroundTarget
        }
        public Turn TurnMode = Turn.TurnPositionAroundTarget;
        public Keys TurnKey = Keys.Space;
        private bool turnMove = false;

        public enum Key
        {
            Up,
            Down,
            Front,
            Back,
            Right,
            Left,
        }

        public float MoveSpeed = 5.0f;

        public GLMoveControl(GLObject glObject)
            : base(GLComponent.TYPE.MOVE_CONTROL, glObject)
        {
            InitMoveControl();
        }

        private void InitMoveControl()
        {
            EventController.SetKey(Key.Up.ToString(), Keys.Q);
            EventController.SetKey(Key.Down.ToString(), Keys.E);
            EventController.SetKey(Key.Front.ToString(), Keys.W);
            EventController.SetKey(Key.Back.ToString(), Keys.S);
            EventController.SetKey(Key.Right.ToString(), Keys.D);
            EventController.SetKey(Key.Left.ToString(), Keys.A);
            EventController.updateKeyEvent += new EoDelegate.VoidObject(UpdateKeyEvent);
        }
        private void UpdateKeyEvent(object key)
        {
            Move((Key)key);
        }

        private void Move(Key key)
        {
            Vector3 vMove = GetMoveVector(key, glObject);
            if (turnMove)
            {
                switch (TurnMode)
                {
                    case Turn.TurnDirection:
                        glObject.target += vMove;
                        break;
                    case Turn.TurnPositionAroundTarget:
                        glObject.position += vMove;
                        break;
                }
            }
            else
            {
                glObject.position += vMove;
                glObject.target += vMove;
            }
        }
        
        private Vector3 GetMoveVector(Key move, GLObject glObject)
        {
            switch (move)
            {
                case Key.Up:
                    return glObject.vUp * MoveSpeed;
                case Key.Down:
                    return glObject.vUp * MoveSpeed * -1.0f;
                case Key.Front:
                    return glObject.vDir * MoveSpeed;
                case Key.Back:
                    return glObject.vDir * MoveSpeed * -1.0f;
                case Key.Right:
                    return glObject.vRight * MoveSpeed;
                case Key.Left:
                    return glObject.vRight * MoveSpeed * -1.0f;
            }
            return Vector3.Zero;
        }
    }
}
