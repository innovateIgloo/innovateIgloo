


namespace OBS.Model
{
    /// <summary>
    /// ��ʼ���ֶ��ϴ��������Ӧ�����
    /// </summary>
    public class InitiateMultipartUploadResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ����
        /// </summary>
        public string BucketName
        {
            get;
            internal set;
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string ObjectKey
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ֶ��ϴ������ID��
        /// </summary>
        public string UploadId
        {
            get;
            internal set;
        }

    }
}
    
