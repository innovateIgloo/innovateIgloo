

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�洢���Ե���Ӧ�����
    /// </summary>
    public class GetBucketStoragePolicyResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ�Ĵ洢���͡�
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }
    }
}
    
