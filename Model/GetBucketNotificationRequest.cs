

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ��Ϣ֪ͨ���õ����������
    /// </summary>
    public class GetBucketNotificationRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketNotification";
        }

    }
}
    
