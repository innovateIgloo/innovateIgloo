

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ������־���õ���Ӧ�����
    /// </summary>
    public class GetBucketLoggingResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ�ķ�����־���á�
        /// </summary>
        public LoggingConfiguration Configuration
        {
            get;
            internal set;
        }
    }
}
    
