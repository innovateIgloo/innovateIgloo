

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�����������õ���Ӧ�����
    /// </summary>
    public class GetBucketReplicationResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ�Ŀ����������á�
        /// </summary>
        public ReplicationConfiguration Configuration
        {
            get;
            internal set;
        }
    }
}
    
