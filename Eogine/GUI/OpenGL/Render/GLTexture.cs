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
    public class GLTexture
    {
        private int mTextureId = -1;
        private Bitmap mBitmap = null;
        private BitmapData mBmpData = null;

        public int Id
        {
            get { return this.mTextureId; }
        }

        public GLTexture(string filePath)
        {
            
            if (File.Exists(filePath))
            {
                mBitmap = new Bitmap(filePath);
            }

        }
        public GLTexture(Bitmap bmp)
        {
            if (bmp != null)
            {
                mBitmap = bmp;
            }
        }

        public void Bind()
        {
            if (mBitmap != null)
            {
                try
                {
                    if (mBmpData == null)
                    {
                        if (mTextureId == -1) mTextureId = GL.GenTexture();
                        mBmpData = mBitmap.LockBits(new Rectangle(0, 0, mBitmap.Width, mBitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        GL.BindTexture(TextureTarget.Texture2D, mTextureId);
                        GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, mBitmap.Width, mBitmap.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, mBmpData.Scan0);
                        mBitmap.UnlockBits(mBmpData);
                        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
                        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
                        GL.Enable(EnableCap.Texture2D);
                    }
                    //GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
                    GL.ShadeModel(ShadingModel.Smooth);
                    //GL.Enable(EnableCap.DepthTest);
                    //GL.DepthFunc(DepthFunction.Lequal);
                    //GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);
                    GL.BindTexture(TextureTarget.Texture2D, mTextureId);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
