

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ����Ȩ�޵����������
    /// </summary>
    public class GetBucketAclRequest : ObsBucketWebServiceRequest
    {
        internal override string GetAction()
        {
            return "GetBucketAcl";
        }
    }
}
    
