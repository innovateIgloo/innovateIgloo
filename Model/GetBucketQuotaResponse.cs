

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ������Ӧ�����
    /// </summary>
    public class GetBucketQuotaResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ��
        /// </summary>
        public long StorageQuota
        {
            get;
            internal set;
        }

    }
}
    
