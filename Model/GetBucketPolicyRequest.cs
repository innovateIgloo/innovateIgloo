

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ���Ե����������
    /// </summary>
    public class GetBucketPolicyRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketPolicy";
        }

    }
}
    
