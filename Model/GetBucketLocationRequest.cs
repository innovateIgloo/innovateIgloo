

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ����λ�õ����������
    /// </summary>
    public class GetBucketLocationRequest : ObsBucketWebServiceRequest
    {
        internal override string GetAction()
        {
            return "GetBucketLocation";
        }
    }
}
    
