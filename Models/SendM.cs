﻿using OSerialPort.ViewModels;
using System;

namespace OSerialPort.Models
{
    public class SendModel : MainWindowBase
    {
        public string _SendHeader;
        public string SendHeader
        {
            get
            {
                return _SendHeader;
            }
            set
            {
                if (_SendHeader != value)
                {
                    _SendHeader = value;
                    RaisePropertyChanged("SendHeader");
                }
            }
        }

        public int _SendDataCount;
        public int SendDataCount
        {
            get
            {
                return _SendDataCount;
            }
            set
            {
                if (_SendDataCount != value)
                {
                    _SendDataCount = value;
                    RaisePropertyChanged("SendDataCount");
                }
            }
        }

        public string _SendData;
        public string SendData
        {
            get
            {
                return _SendData;
            }
            set
            {
                if (_SendData != value)
                {
                    _SendData = value;
                    RaisePropertyChanged("SendData");
                }
            }
        }

        public bool _HexSend;
        public bool HexSend
        {
            get
            {
                return _HexSend;
            }
            set
            {
                if (_HexSend != value)
                {
                    _HexSend = value;
                    RaisePropertyChanged("HexSend");

                    if (HexSend == true)
                    {
                        DepictInfo = "请输入十六进制数据用空格隔开，比如0A 1B 2C 3D";
                    }
                    else
                    {
                        DepictInfo = "串行端口调试助手";
                    }
                }
            }
        }

        public int _AutoSendNum;
        public int AutoSendNum
        {
            get
            {
                return _AutoSendNum;
            }
            set
            {
                if (_AutoSendNum != value)
                {
                    _AutoSendNum = value;
                    RaisePropertyChanged("AutoSendNum");
                }
            }
        }

        public void SendDataContext()
        {
            SendData = string.Empty;
            SendDataCount = 0;

            HexSend = false;
            AutoSendNum = 1000;
        }
    }
}