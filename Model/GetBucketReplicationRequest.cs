

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�����������õ����������
    /// </summary>
    public class GetBucketReplicationRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketReplication";
        }

    }
}
    
