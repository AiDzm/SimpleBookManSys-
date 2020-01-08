using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace 图书馆管理系统
{
    #region 摄像头类辅助类
    class Camera
    {
        private IntPtr lwndC;       //保存无符号句柄
        private IntPtr mControlPtr; //保存管理指示器
        private int mWidth;
        private int mHeight;

        #region 默认构造
        /// <summary>
        /// 默认构造
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Camera(IntPtr handle, int width, int height)
        {
            mControlPtr = handle; //显示视频控件的句柄
            mWidth = width;      //视频宽度
            mHeight = height;    //视频高度
        }
        #endregion

        #region 打开视频设备
        /// <summary>
        /// 打开视频设备
        /// </summary>
        public void StartWebCam()
        {
            byte[] lpszName = new byte[100];
            byte[] lpszVer = new byte[100];
            CameraAPI.capGetDriverDescriptionA(0, lpszName, 100, lpszVer, 100);
            this.lwndC = CameraAPI.capCreateCaptureWindowA(lpszName, CameraAPI.WS_CHILD | CameraAPI.WS_VISIBLE, 0, 0, mWidth, mHeight, mControlPtr, 0);
            if (CameraAPI.SendMessage(lwndC, CameraAPI.WM_CAP_DRIVER_CONNECT, 0, 0))
            {
                CameraAPI.SendMessage(lwndC, CameraAPI.WM_CAP_SET_PREVIEWRATE, 100, 0);
                CameraAPI.SendMessage(lwndC, CameraAPI.WM_CAP_SET_PREVIEW, true, 0);
            }
        }
        #endregion

        #region 关闭视频设备
        /// <summary>
        /// 关闭视频设备
        /// </summary>
        public void CloseWebcam()
        {
            CameraAPI.SendMessage(lwndC, CameraAPI.WM_CAP_DRIVER_DISCONNECT, 0, 0);
        }
        #endregion

        #region 拍照
        ///   <summary>   
        ///   拍照
        ///   </summary>   
        ///   <param   name="path">要保存bmp文件的路径</param>   
        public void GrabImage(IntPtr hWndC, string path)
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(path);
            CameraAPI.SendMessage(lwndC, CameraAPI.WM_CAP_SAVEDIB, 0, hBmp.ToInt32());
        }
        #endregion
    }
    #endregion
}
