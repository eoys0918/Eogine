using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;
using System.IO;

namespace Eogine
{
    public class GLTexture2D
    {
        private int mTextureId;
        private Bitmap mBitmap;
        private BitmapData mBmpData;

        public int Id
        {
            get { return this.mTextureId; }
        }

        public GLTexture2D(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    InitData(new Bitmap(filePath));
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public GLTexture2D(Bitmap bmp)
        {
            InitData(bmp);
        }

        private void InitData(Bitmap bmp)
        {
            if (bmp != null)
            {
                mBitmap = bmp;

                try
                {
                    mBmpData = mBitmap.LockBits(new Rectangle(0, 0, mBitmap.Width, mBitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    mTextureId = GL.GenTexture();
                    GL.BindTexture(TextureTarget.Texture2D, mTextureId);
                    GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, mBitmap.Width, mBitmap.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, mBmpData.Scan0);

                    mBitmap.UnlockBits(mBmpData);

                    GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
                    GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMinFilter.Linear);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void RenderFrame()
        {

        }
    }
}
