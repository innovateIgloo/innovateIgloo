

namespace OBS.Model
{
    /// <summary>
    /// ɾ��Ͱ���Ե����������
    /// </summary>
    public partial class DeleteBucketPolicyRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "DeleteBucketPolicy";
        }

    }
}
    
