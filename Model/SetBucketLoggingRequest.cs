

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ������־���õ����������
    /// </summary>
    public class SetBucketLoggingRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketLogging";
        }

        /// <summary>
        /// Ͱ�ķ�����־���á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public LoggingConfiguration Configuration { get; set; }

    }
}
    
