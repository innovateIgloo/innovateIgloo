
using System;
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// ���ƶε����������
    /// </summary>
    public class CopyPartRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "CopyPart";
        }

        /// <summary>
        /// ԴͰ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string SourceBucketName
        {
            get;
            set;
        }


        /// <summary>
        /// Դ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string SourceObjectKey
        {
            get;
            set;
        }


        /// <summary>
        /// Դ����İ汾�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string SourceVersionId
        {
            get;
            set;
        }

      

        /// <summary>
        /// Ŀ���������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ObjectKey
        {
            get;
            set;
        }

        /// <summary>
        /// �ֶ��ϴ������ID�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string UploadId
        {
            get;
            set;
        }


        /// <summary>
        /// Ŀ��εķֶκš�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public int PartNumber
        {
            get;
            set;
        }

        /// <summary>
        /// ����Դ����ķ�Χ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public ByteRange ByteRange
        {
            get;
            set;
        }


        /// <summary>
        /// Դ����SSE-C����ͷ����Ϣ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public SseCHeader SourceSseCHeader
        {
            get;
            set;
        }

        /// <summary>
        /// ������SSE-C����ͷ����Ϣ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public SseCHeader DestinationSseCHeader
        {
            get;
            set;
        }

    }
}
    
