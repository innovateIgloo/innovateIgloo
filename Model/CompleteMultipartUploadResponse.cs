
namespace OBS.Model
{
    /// <summary>
    /// �ϲ��ε���Ӧ�����
    /// </summary>
    public class CompleteMultipartUploadResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// �ϲ��κ�õ��Ķ����url��
        /// </summary>
        public string Location
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ϲ������ڵ�Ͱ��
        /// </summary>
        public string BucketName
        {
            get;
            internal set;
        }


        /// <summary>
        /// �ϲ��κ�õ��Ķ�������
        /// </summary>
        public string ObjectKey
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ϲ��κ���ݸ����ε�ETagֵ������Ľ����
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ϲ��κ�õ��Ķ���汾�š�
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ϲ��κ�õ��Ķ����ȫ·����
        /// </summary>
        public string ObjectUrl
        {
            get;
            internal set;
        }
    }
}
    
