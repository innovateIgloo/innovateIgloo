

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ�����������õ����������
    /// </summary>
    public class SetBucketReplicationRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketReplication";
        }

        /// <summary>
        /// Ͱ�Ŀ����������á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public ReplicationConfiguration Configuration
        {
            get;
            set;
        }
    }
}
    
