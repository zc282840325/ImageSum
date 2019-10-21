using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSum
{
    public class PictureStitching
    {
        public PictureStitching(List<Bitmap> list, string destFileName)
        {
            List = list;
            this.destFileName = destFileName;
        }

        public List<Bitmap> List { get; set; }

        public string destFileName { get; set; }

        public Bitmap SavePic()
        {
            Bitmap source;
            Graphics resultGraphics;    //用来绘图的实例

            if (List.Count > 0)
            {
                Image img1 = List[0];
                source = new Bitmap(img1.Width * List.Count, img1.Height);

                resultGraphics = Graphics.FromImage(source); //以source大小来创建一块新的画布
                resultGraphics.DrawImage(img1, 0, 0, img1.Width, img1.Height);//先把img1画出
                for (int i = 1; i < List.Count; i++)
                {
                    Image img2 = List[i];
                    resultGraphics.DrawImage(img2, img1.Width * i, 0, img2.Width, img2.Height);//找到img1的位置再把img2画出
                }
                if (!string.IsNullOrEmpty(destFileName))
                {
                    source.Save(destFileName);
                }
                return source;
            }
            else
            {
                return null;
            }
        }
    }
}
