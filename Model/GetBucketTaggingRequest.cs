

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ��ǩ�����������
    /// </summary>
    public class GetBucketTaggingRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketTagging";
        }

    }
}
    
