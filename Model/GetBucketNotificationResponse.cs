

namespace OBS.Model
{

    /// <summary>
    ///  ��ȡͰ��Ϣ֪ͨ���õ���Ӧ�����
    /// </summary>
    public class GetBucketNotificationReponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ����Ϣ֪ͨ���á�
        /// </summary>
        public NotificationConfiguration Configuration
        {
            get;
            internal set;
        }

    }
}
    
