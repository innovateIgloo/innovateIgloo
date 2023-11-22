

namespace OBS.Model
{
    /// <summary>
    /// �ϴ��������Ӧ�����
    /// </summary>
    public class PutObjectResponse : ObsWebServiceResponse
    {
       

        /// <summary>
        /// �����ETagУ��ֵ�� 
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// ����汾�š�
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }


        /// <summary>
        /// ����洢���͡�
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����ȫ·����
        /// </summary>
        public string ObjectUrl
        {
            get;
            internal set;
        }

       
    }
}
    
