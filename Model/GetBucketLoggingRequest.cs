

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ������־���õ����������
    /// </summary>
    public class GetBucketLoggingRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketLogging";
        }

    }
}
    
