

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ������Դ�������õ���Ӧ�����
    /// </summary>
    public class GetBucketCorsResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ�Ŀ�����Դ�������á�
        /// </summary>
        public CorsConfiguration Configuration
        {
            get;
            internal set;
        }

    }
}
    
