

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ������Ϣ�����������
    /// </summary>
    public class GetBucketStorageInfoRequest: ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketStorageInfo";
        }

    }
}
    
