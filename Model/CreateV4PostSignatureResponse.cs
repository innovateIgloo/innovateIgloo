
using System;
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// POST����Ȩ��Ӧ�����
    /// </summary>
    public class CreateV4PostSignatureResponse : CreatePostSignatureResponse
    {
        /// <summary>
        /// ǩ���㷨������������
        /// </summary>
        public string Algorithm
        {
            get;
            internal set;
        }

        /// <summary>
        /// Credential��Ϣ������������
        /// </summary>
        public string Credential
        {
            get;
            internal set;
        }

        /// <summary>
        /// ISO 8601��ʽ���ڣ�����������
        /// </summary>
        public string Date
        {
            get;
            internal set;
        }

    }
}
    
