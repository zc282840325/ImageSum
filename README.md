# ImageSum
## 图片的拼接
### 创建位图:Bitmap source=new Bitmap(x,y);
### 创建画布:Graphics resultGraphics= Graphics.FromImage(source);
### 先把img1画出:resultGraphics.DrawImage(img1, 0, 0, img1.Width, img1.Height);
### 向左拼接：resultGraphics.DrawImage(img2, img1.Width, 0, img2.Width, img2.Height);
### 向下拼接：resultGraphics.DrawImage(img2, 0,img1.Height, img2.Width, img2.Height);
### 保存图片： source.Save(destFileName)；
