

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�������������
    /// </summary>
    public class GetBucketQuotaRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketQuota";
        }

    }
}
    
