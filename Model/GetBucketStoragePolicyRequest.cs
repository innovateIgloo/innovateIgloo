

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�洢���Ե����������
    /// </summary>
    public class GetBucketStoragePolicyRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketStoragePolicy";
        }

    }
}
    
