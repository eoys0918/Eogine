using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Eogine
{
    public class GLGrid : GLObject
    {
        public float GridSizeWidth { get; set; }
        public float GridSizeHeight { get; set; }

        public int GridCountWidth { get; set; }
        public int GridCountHeight { get; set; }

        public int GridCount
        {
            get { return GridCountWidth * GridCountHeight; }
        }
        
        public int GridVertexCountWidth
        {
            get
            {
                return GridCountWidth + 1;
            }
        }
        public int GridVertexCountHeight
        {
            get
            {
                return GridCountHeight + 1;
            }
        }

        public int GridVertexCount
        {
            get { return GridVertexCountWidth * GridVertexCountHeight; }
        }

        public enum TYPE
        {
            Mesh, Line
        }
        private TYPE mGridType;
        public void SetGridType(TYPE type)
        {
            switch (mGridType = type)
            {
                case TYPE.Mesh:
                    InitMesh();
                    break;
                case TYPE.Line:
                    InitLine();
                    break;
            }
        }
        
        public GLGrid()
        {
            //texture = new GLTexture(global::Eogine.Properties.Resources.login_bg_04);
            GridCountWidth = 10;
            GridCountHeight = 10;
            GridSizeWidth = 10.0f;
            GridSizeHeight = 10.0f;
            SetGridType(TYPE.Line);
        }

        private void InitVertex()
        {
            float startX = 0.0f - (GridSizeWidth * GridCountWidth * 0.5f);
            float startZ = 0.0f + (GridSizeHeight * GridCountHeight * 0.5f);

            verticies = new GLVertex[GridVertexCount];

            for (int i = 0; i < GridVertexCount; i++)
            {
                Vector3 pos = new Vector3();
                pos.X = startX + (GridSizeWidth * (i % GridVertexCountWidth));
                pos.Y = 0.0f;
                pos.Z = startZ - (GridSizeHeight * ((int)(i / GridVertexCountWidth)));

                Vector2 uv = new Vector2();
                uv.X = (startX - pos.X) / (GridSizeWidth * GridCountWidth);
                uv.Y = (startZ - pos.Z) / (GridSizeHeight * GridCountHeight);

                verticies[i] = new GLVertex(pos, uv, Color.White);
            }
        }

        private void InitLine()
        {
            InitVertex();

            indexes = new uint[GridCount * 8];

            for (int i = 0; i < GridCount; i++)
            {
                int indexTopLeft = i + ((int)(i / (GridCountWidth)));
                int indexTopRight = indexTopLeft + 1;
                int indexBottomLeft = indexTopLeft + (GridCountWidth + 1);
                int indexBottomRight = indexBottomLeft + 1;

                indexes[(i * 8) + 0] = (uint)indexTopLeft;
                indexes[(i * 8) + 1] = (uint)indexTopRight;

                indexes[(i * 8) + 2] = (uint)indexBottomLeft;
                indexes[(i * 8) + 3] = (uint)indexBottomRight;

                indexes[(i * 8) + 4] = (uint)indexTopLeft;
                indexes[(i * 8) + 5] = (uint)indexBottomLeft;

                indexes[(i * 8) + 6] = (uint)indexTopRight;
                indexes[(i * 8) + 7] = (uint)indexBottomRight;
            }
            RenderType = PrimitiveType.Lines;
            updateVertices = true;
        }

        private void InitMesh()
        {
            InitVertex();

            indexes = new uint[GridCount * 6];

            for (int i = 0; i < GridCount; i++)
            {
                int indexTopLeft = i + ((int)(i / GridCountWidth));
                int indexTopRight = indexTopLeft + 1;
                int indexBottomLeft = indexTopLeft + (GridCountWidth + 1);
                int indexBottomRight = indexBottomLeft + 1;

                indexes[(i * 6) + 0] = (uint)indexTopLeft;
                indexes[(i * 6) + 1] = (uint)indexTopRight;
                indexes[(i * 6) + 2] = (uint)indexBottomRight;

                indexes[(i * 6) + 3] = (uint)indexTopLeft;
                indexes[(i * 6) + 4] = (uint)indexBottomRight;
                indexes[(i * 6) + 5] = (uint)indexBottomLeft;
            }
            RenderType = PrimitiveType.Triangles;
            updateVertices = true;
        }

    }
}
