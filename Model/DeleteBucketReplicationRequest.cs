

namespace OBS.Model
{
    /// <summary>
    /// ɾ��Ͱ�����������õ����������
    /// </summary>
    public class DeleteBucketReplicationRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "DeleteBucketReplication";
        }

    }
}
    
