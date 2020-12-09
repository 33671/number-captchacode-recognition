using System;
using System.Drawing;
using System.IO;
using Numpy;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tenNumbers = np.array(new int[10,108]);
            tenNumbers[0] = np.array(new int[108]
            {1, 1, 1, 1, 1, 0, 0, 0, 1,
             1, 1, 1, 0, 0, 1, 1, 0, 0,
             1, 1, 0, 0, 1, 1, 1, 1, 0,
             1, 1, 0, 1, 1, 1, 1, 1, 0,
             1, 1, 0, 1, 1, 1, 1, 1, 0,
             1, 0, 0, 1, 1, 1, 1, 1, 0,
             1, 0, 0, 1, 1, 1, 1, 0, 0,
             1, 0, 0, 1, 1, 1, 1, 0, 0,
             1, 0, 1, 1, 1, 1, 1, 0, 0,
             1, 0, 1, 1, 1, 1, 0, 0, 1,
             1, 0, 0, 1, 1, 1, 0, 1, 1,
             1, 1, 0, 0, 0, 0, 1, 1, 1 });
            tenNumbers[1] = np.array(new int[108]
            {1, 1, 1, 1, 1, 1, 0, 1, 1,
             1, 1, 1, 0, 0, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 1, 1, 1,
             1, 1, 1, 1, 1, 0, 1, 1, 1,
             1, 1, 1, 1, 0, 0, 1, 1, 1,
             1, 1, 1, 1, 0, 0, 1, 1, 1,
             1, 1, 1, 1, 0, 0, 1, 1, 1,
             1, 1, 1, 1, 0, 0, 1, 1, 1,
             1, 1, 0, 0, 0, 0, 0, 0, 1});
            tenNumbers[2] = np.array(new int[108]
            {1, 1, 1, 1, 0, 0, 0, 1, 1,
             1, 1, 0, 0, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 1, 1, 0, 0,
             1, 1, 1, 1, 1, 1, 1, 0, 0,
             1, 1, 1, 1, 1, 1, 1, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 1, 1, 1, 0, 1, 1, 1, 1,
             1, 1, 0, 0, 1, 1, 1, 1, 1,
             1, 0, 0, 1, 1, 1, 1, 1, 1,
             1, 0, 0, 1, 1, 1, 1, 1, 1,
             0, 0, 0, 0, 0, 0, 0, 1, 1 });
            tenNumbers[3] = np.array(new int[108]
            {1, 1, 1, 0, 0, 0, 0, 0, 1,
             1, 1, 1, 1, 1, 1, 1, 0, 0,
             1, 1, 1, 1, 1, 1, 1, 1, 0,
             1, 1, 1, 1, 1, 1, 1, 1, 0,
             1, 1, 1, 1, 1, 1, 1, 0, 1,
             1, 1, 1, 0, 0, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 1, 1, 0, 1,
             1, 1, 1, 1, 1, 1, 1, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             0, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 0, 0, 0, 0, 0, 1, 1, 1});
            tenNumbers[4] = np.array(new int[108]
            {1, 1, 1, 1, 1, 1, 1, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 0, 0, 0, 1,
             1, 1, 1, 1, 0, 0, 1, 0, 1,
             1, 1, 1, 0, 0, 1, 0, 0, 1,
             1, 1, 0, 0, 1, 1, 0, 0, 1,
             1, 1, 0, 1, 1, 1, 0, 1, 1,
             1, 0, 0, 0, 1, 0, 0, 0, 1,
             1, 0, 0, 0, 0, 0, 0, 0, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1});
            tenNumbers[5] = np.array(new int[108]
            {1, 1, 1, 0, 0, 0, 0, 0, 0,
             1, 1, 1, 0, 0, 0, 0, 0, 0,
             1, 1, 1, 0, 1, 1, 1, 1, 1,
             1, 1, 1, 0, 1, 1, 1, 1, 1,
             1, 1, 0, 0, 1, 1, 1, 1, 1,
             1, 1, 0, 0, 0, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 0, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 0, 0, 0, 0, 0, 1, 1, 1 });
            tenNumbers[6] = np.array(new int[108]
            {1, 1, 1, 1, 1, 0, 0, 0, 0,
             1, 1, 1, 0, 0, 0, 1, 1, 0,
             1, 1, 1, 0, 1, 1, 1, 1, 1,
             1, 1, 0, 1, 1, 1, 1, 1, 1,
             1, 1, 0, 1, 1, 1, 1, 1, 1,
             1, 0, 0, 0, 0, 0, 0, 0, 1,
             1, 0, 0, 1, 1, 1, 1, 0, 0,
             1, 0, 0, 1, 1, 1, 1, 0, 0,
             1, 0, 1, 1, 1, 1, 1, 0, 0,
             1, 0, 0, 1, 1, 1, 1, 0, 1,
             1, 0, 0, 1, 1, 1, 0, 0, 1,
             1, 1, 0, 0, 0, 0, 0, 1, 1});
            tenNumbers[7] = np.array(new int[108]
            {1, 0, 0, 0, 0, 0, 0, 0, 0,
             1, 1, 0, 0, 0, 0, 0, 0, 0,
             1, 1, 1, 1, 1, 1, 1, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 1, 1, 1, 1, 0, 1, 1, 1,
             1, 1, 1, 1, 0, 1, 1, 1, 1,
             1, 1, 1, 0, 0, 1, 1, 1, 1,
             1, 1, 0, 0, 1, 1, 1, 1, 1,
             1, 1, 0, 1, 1, 1, 1, 1, 1,
             1, 0, 0, 1, 1, 1, 1, 1, 1,
             1, 0, 1, 1, 1, 1, 1, 1, 1});
            tenNumbers[8] = np.array(new int[108]
            {1, 1, 1, 1, 0, 0, 0, 0, 1,
             1, 1, 1, 0, 0, 1, 1, 0, 0,
             1, 1, 0, 0, 1, 1, 1, 1, 0,
             1, 1, 0, 1, 1, 1, 1, 1, 0,
             1, 1, 0, 0, 1, 1, 1, 0, 1,
             1, 1, 1, 0, 0, 0, 0, 1, 1,
             1, 1, 0, 1, 1, 1, 0, 0, 1,
             1, 0, 0, 1, 1, 1, 1, 0, 1,
             1, 0, 0, 1, 1, 1, 1, 0, 0,
             1, 0, 0, 1, 1, 1, 1, 0, 1,
             1, 0, 0, 1, 1, 1, 0, 0, 1,
             1, 1, 0, 0, 0, 0, 1, 1, 1});
            tenNumbers[9] = np.array(new int[108]
            {1, 1, 1, 1, 0, 0, 0, 0, 1,
             1, 1, 1, 0, 0, 1, 1, 0, 0,
             1, 1, 0, 0, 1, 1, 1, 1, 0,
             1, 1, 0, 1, 1, 1, 1, 1, 0,
             1, 0, 0, 1, 1, 1, 1, 1, 0,
             1, 0, 0, 1, 1, 1, 1, 0, 0,
             1, 1, 0, 0, 1, 1, 0, 0, 0,
             1, 1, 1, 0, 0, 0, 1, 0, 0,
             1, 1, 1, 1, 1, 1, 1, 0, 1,
             1, 1, 1, 1, 1, 1, 0, 0, 1,
             1, 1, 1, 1, 1, 0, 0, 1, 1,
             1, 0, 0, 0, 0, 0, 1, 1, 1});
            byte[] bytes;
            using (FileStream fileStream = new FileStream("captcha.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);
            }
            Stream stream = new MemoryStream(bytes);
            Bitmap bmp = new Bitmap(stream);
            int[,] intArray = new int[bmp.Height, bmp.Width];
            //根据灰度产生二值位图intArray
            Color c;
            byte gray;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    c = bmp.GetPixel(j, i);
                    gray = (byte)(.21 * c.R + .71 * c.G + .071 * c.B);
                    if (gray <= 100) intArray[i, j] = 0;
                    else intArray[i, j] = 1;
                }
            }
            var npArray = np.array(intArray);
            var row_min = np.min(npArray, new int[1] {1}); // 每行最小值
            var row_start = np.argmin(row_min).ToString();  // 找到第一个有图像的行
            var row_end = np.argmin(np.flip(row_min)).ToString(); // 找到最后一个有图像的行
            var img_matrix = npArray[row_start + ":" + "-"+ row_end + ",:"]; // 只取有图像的行
            NDarray img_matrix_spited, col_min, col_start, col_end,width, width_rest,flattenedMatrix, res = np.array(new int[10]),codes = np.array(new int[4]);
            foreach (int x in new int[4] { 0, 1, 2, 3 })
            {
                img_matrix_spited = img_matrix[":," + (19 * x).ToString() + ":" + (19 * (x + 1)).ToString()];
                col_min = np.min(img_matrix_spited, new int[1] { 0 }); // 切片
                col_start = np.argmin(col_min);
                col_end = np.argmin(np.flip(col_min));
                width = col_min.shape[0] - (col_start + col_end); // 图像宽度
                width_rest = (NDarray)9 - width; // 宽度扩宽到 9 像素
                col_start -= (int)(Math.Ceiling((int)width_rest / 2.0));// 左边界
                col_end -= (int)(Math.Floor((int)width_rest / 2.0));// 右边界
                //排障
                if ((int)(col_start) < 0)
                {
                    col_start = (NDarray)0;
                    col_end -= (NDarray)1;
                }
                flattenedMatrix = img_matrix_spited[":," + col_start.ToString() + ":" + "-" + col_end.ToString()].flatten(); // 裁剪为 9 像素宽的图像,展开成一维
                for (int j = 0; j < 10; j++) res[j] = np.sum(np.bitwise_xor(flattenedMatrix, tenNumbers[j])); // 通过异或计算不同元素的数量
                codes[x] = np.argmin(res);// 取差异最小的下标
            }
            Console.WriteLine(String.Join("",codes.GetData<int>()));
        }
    }
}
