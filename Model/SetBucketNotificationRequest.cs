

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ��Ϣ֪ͨ���õ����������
    /// </summary>
    public class SetBucketNotificationRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketNotification";
        }

        /// <summary>
        /// Ͱ����Ϣ֪ͨ���á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public NotificationConfiguration Configuration
        {
            get;
            set;
        }
    }
}
    
