

namespace OBS.Model
{
    /// <summary>
    /// ��ѯͰ�Ƿ���ڵ����������
    /// </summary>
    public class HeadBucketRequest : ObsBucketWebServiceRequest
    {
        internal override string GetAction()
        {
            return "HeadBucket";
        }
    }
}
    
