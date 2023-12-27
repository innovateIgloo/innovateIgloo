
using System;
namespace OBS.Model
{
    /// <summary>
    /// ��ȡ����Ԫ���ݵ����������
    /// </summary>
    public class GetObjectMetadataRequest : ObsBucketWebServiceRequest
    {
        internal override string GetAction()
        {
            return "GetObjectMetadata";
        }

        /// <summary>
        /// ��������
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
        /// ����汾�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string VersionId
        {
            get;
            set;
        }

        /// <summary>
        /// ��������SSE-C����ͷ����Ϣ
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public SseCHeader SseCHeader
        {
            get;
            set;
        }
    }
}
    
